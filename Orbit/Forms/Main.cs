using Orbit.Functions;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Orbit
{
    public partial class Main : Form
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern bool IsWow64Process(System.IntPtr hProcess, out bool lpSystemInfo);
        public bool IsWow64Process(System.Diagnostics.Process process)
        {
            bool retVal = false;
            IsWow64Process(process.Handle, out retVal);
            return retVal;
        }
        #region Variables
        private string dllPath { get; set; }

        public static Label ProcStatus = new();
        public static TextBox ProcName = new();
        #endregion
        public Main()
        {
            External External = new(this.Handle);
            InitializeComponent();
            #region Design Intilization
            this.StartPosition = FormStartPosition.Manual;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            
            this.Opacity = 0;
            InjectBtn.MouseEnter += Design.Buttons.Enter.OnHover;
            InjectBtn.MouseLeave += Design.Buttons.Leave.OnHover;

            ExitBtn.MouseEnter += Design.Buttons.Enter.OnHover;
            ExitBtn.MouseLeave += Design.Buttons.Leave.OnHover;

            SelectBtn.MouseEnter += Design.Buttons.Enter.OnHover;
            SelectBtn.MouseLeave += Design.Buttons.Leave.OnHover;

            SelectDll.MouseEnter += Design.Buttons.Enter.OnHover;
            SelectDll.MouseLeave += Design.Buttons.Leave.OnHover;

            bitVersion.MouseEnter += Design.Buttons.Enter.OnHover;
            bitVersion.MouseLeave += Design.Buttons.Leave.OnHover;

            TopbarTitle.MouseDown += External.MoveForm;
            OrbitLogo.MouseDown += External.MoveForm;
            this.MouseDown += External.MoveForm;
            #endregion


        }
        private void MainOnLoad(object sender, EventArgs e)
        {
            ProcStatus = ProcessStatus;
            ProcName = ProcessName;
            if (IntPtr.Size == 4)
            {
                bitVersion.Text = "x32";
            }
            else
            {
                bitVersion.Text = "x64";
            }
            FormAnimation.Start();
        }
        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SelectDll_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "DLL Files (*.dll)|*.dll";
            fileDialog.Title = "Select DLL File";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dllPath = fileDialog.FileName;
                SelectDll.Text = new FileInfo(dllPath).Name;
                SelectDll.ForeColor = Color.FromArgb(248, 94, 49);
                DllBuild.Text = Utility.IsDll64(dllPath) ? "x64" : "x32";

            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProcessName.Text))
            {
                Forms.ProcessSelector pSelect = new();
                pSelect.Show();
            }
            ProcessStatus.Text = Utility.GetProcessStatus(ProcessName.Text);

        }

        private void InjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProcessName.Text)) return;
            if (string.IsNullOrEmpty(dllPath)) return;
            if (ProcessStatus.Text == "Not Running") return;
            if (DllBuild.Text == "x64" && IntPtr.Size == 4 && ProcessStatus.Text.Contains("x32") || DllBuild.Text == "x32" && IntPtr.Size == 8 && ProcessStatus.Text.Contains("x64") || DllBuild.Text == "x64" && IntPtr.Size == 8 && ProcessStatus.Text.Contains("x32") || DllBuild.Text == "x32" && IntPtr.Size == 4 && ProcessStatus.Text.Contains("x64"))
            {
                Logs.Text = Logs.Text + "DLL platform build not compatible with injector build" + Environment.NewLine;
                return;
            };
            InjectionWorker.RunWorkerAsync();
        }

        private void InjectionWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Injector.Inject(dllPath, ProcessName.Text, Logs);
        }

        private void FormAnimation_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.1;
            }
            
        }
    }
}    