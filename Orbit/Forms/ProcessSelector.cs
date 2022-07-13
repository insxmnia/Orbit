using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbit.Forms
{
    public partial class ProcessSelector : Form
    {

        public ProcessSelector()
        {
            InitializeComponent();
            Functions.External External = new(this.Handle);
            #region Design Intilization
            ExitBtn.MouseEnter += Design.Buttons.Enter.OnHover;
            ExitBtn.MouseLeave += Design.Buttons.Leave.OnHover;

            ProcessList.DrawItem += Design.Lists.Draws.DrawItem;

            this.MouseDown += External.MoveForm;
            MainPanel.MouseDown += External.MoveForm;
            #endregion

            ProcessList.DataSource = Functions.Utility.ProcessNames();
        }

        private void OnSelectedItem(object sender, EventArgs e)
        {
            Main.ProcName.Text = ProcessList.SelectedItem.ToString();
            Main.ProcStatus.Text = Functions.Utility.GetProcessStatus(ProcessList.SelectedItem.ToString());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
