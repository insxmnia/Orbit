using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orbit.Functions
{
    [Flags]
    public enum AllocationType
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Reset = 0x80000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }
    internal class Injector
    {
        #region pInvokes
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, uint processId);
        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr LoadLibrary([MarshalAs(20)] string lpFileName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hHandle);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress,
   int dwSize, AllocationType dwFreeType);
        #endregion
        public static void Inject(string dllPath, string processName, TextBox log)
        {
            try
            {
                bool mCheck = false;
                log.Text = "";
                log.Text = log.Text + "Searching for process" + Environment.NewLine;
                Process[] processes = Process.GetProcessesByName(processName);
                if (processes.Length == 0)
                {
                    log.Text = log.Text + "Could not find process: " + processName + Environment.NewLine;
                    return;
                }
                Process process = processes[0];
                log.Text = log.Text + "Attempting to open process" + Environment.NewLine;
                IntPtr processHandle = OpenProcess(2035711U, false, (uint)process.Id);
                if (processHandle == IntPtr.Zero)
                {
                    log.Text = log.Text + "Could not open process: " + processName + Environment.NewLine;
                    return;
                }
                log.Text = log.Text + "Allocating memory in process" + Environment.NewLine;
                IntPtr address = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)dllPath.Length, 4096U, 64U);
                if (address == IntPtr.Zero)
                {
                    log.Text = log.Text + "Could not allocate memory in process: " + processName + Environment.NewLine;
                    return;
                }
                log.Text = log.Text + "Preparing DLL bytes" + Environment.NewLine;
                byte[] bytes = Encoding.ASCII.GetBytes(dllPath);
                log.Text = log.Text + "Writing DLL to process" + Environment.NewLine;
                IntPtr bytesWritten;
                WriteProcessMemory(processHandle, address, bytes, bytes.Length, out bytesWritten);
                if (bytesWritten.ToInt32() != bytes.Length)
                {
                    log.Text = log.Text + "Could not write to process: " + processName + Environment.NewLine;
                    return;
                }
                IntPtr hModule = LoadLibrary("kernel32.dll");
                log.Text = log.Text + "Getting LoadLibraryA address" + Environment.NewLine;
                IntPtr loadLibraryAddress = GetProcAddress(hModule, "LoadLibraryA");
                if (loadLibraryAddress == IntPtr.Zero)
                {
                    log.Text = log.Text + "Could not find LoadLibraryA" + Environment.NewLine;
                    return;
                }
                IntPtr threadid = IntPtr.Zero;
                log.Text = log.Text + "Creating remote thread" + Environment.NewLine;
                IntPtr remoteThread = CreateRemoteThread(processHandle, IntPtr.Zero, 0U, loadLibraryAddress, address, 0U, out threadid);
                if (remoteThread == IntPtr.Zero)
                {
                    log.Text = log.Text + "Could not create remote thread: " + processName + Environment.NewLine;
                    return;
                }
                WaitForSingleObject(remoteThread, uint.MaxValue);
                VirtualFreeEx(processHandle, address, 0, AllocationType.Release);
                log.Text = log.Text + "Cleaned up memory" + Environment.NewLine;
                CloseHandle(remoteThread);
                processes = Process.GetProcessesByName(processName);
                foreach (ProcessModule module in processes[0].Modules)
                {  
                    if (module.ModuleName == Functions.Utility.ReturnLastSplit(dllPath, '\\'))
                    {
                        mCheck = true;
                    }
                }
                if (!mCheck)
                {
                    log.Text = log.Text + "DLL refused by process" + Environment.NewLine;
                    Main.ProcStatus.Text = "DLL refused";
                    return;
                }
                log.Text = log.Text + "DLL injected" + Environment.NewLine;
                Main.ProcStatus.Text = "Injected";


            }
            catch (Exception ex)
            {
                log.Text = log.Text + "Error: " + ex.Message + Environment.NewLine;
            }
        }
    }
}
