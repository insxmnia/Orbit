using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orbit.Functions
{
    internal class Utility
    {
        #region pInvokes
        [DllImport("kernel32.dll")]
        public static extern bool IsWow64Process(System.IntPtr hProcess, out bool lpSystemInfo);
        public static bool IsWow64Process(Process process) //false == 64bit, true == 32 bit
        {
            bool retVal = false;
            IsWow64Process(process.Handle, out retVal);
            return retVal;
        }
        #endregion

        public static List<string> ProcessNames()
        {
            List<string> TempList = new List<string>();
            foreach (var proc in Process.GetProcesses())
            {
                if (!TempList.Contains(proc.ProcessName))
                {
                    TempList.Add(proc.ProcessName);
                }
            }
            TempList.Sort();
            return TempList;
        }

        public static string GetProcessStatus(string pName)
        {
            Process[] processes = Process.GetProcessesByName(pName);

            if (processes.Length == 0)
            {
                return "Not Running";
            }
            else
            {
                try
                {
                    bool is64Bit = IsWow64Process(processes[0]);
                    if (is64Bit && IntPtr.Size == 8)
                    {
                        return "Running (x32)";
                    }
                    else if (!is64Bit && IntPtr.Size == 4)
                    {
                        return "Running (x64)";
                    }
                    else
                    {
                        return "Running";
                    }
                }
                catch (Exception)
                {
                    return "Running (System Process)";
                }
            }
        }

        public static string ReturnLastSplit(string data, char splitter)
        {
            string[] split = data.Split(splitter);
            return split[split.Length - 1];
        }

        public static ushort GetImageArchitecture(string filepath)
        {
            using (var stream = new System.IO.FileStream(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            using (var reader = new System.IO.BinaryReader(stream))
            {
                if (reader.ReadUInt16() != 23117)
                    throw new BadImageFormatException("Not a valid Portable Executable image", filepath);
                stream.Seek(0x3A, System.IO.SeekOrigin.Current);
                stream.Seek(reader.ReadUInt32(), System.IO.SeekOrigin.Begin);
                
                if (reader.ReadUInt32() != 17744)
                    throw new BadImageFormatException("Not a valid Portable Executable image", filepath);
                stream.Seek(20, System.IO.SeekOrigin.Current);
                return reader.ReadUInt16();
            }
        }

        public static bool IsDll64(string filepath)
        {
            return GetImageArchitecture(filepath) == 0x20b;
        }
    }
}
