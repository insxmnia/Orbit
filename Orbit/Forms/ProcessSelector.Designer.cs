namespace Orbit.Forms
{
    partial class ProcessSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessSelector));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OrbitLogo = new System.Windows.Forms.Label();
            this.TopbarTitle = new System.Windows.Forms.Label();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.FontTemplate = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainPanel.Controls.Add(this.OrbitLogo);
            this.MainPanel.Controls.Add(this.TopbarTitle);
            this.MainPanel.Controls.Add(this.ProcessList);
            this.MainPanel.Controls.Add(this.ExitBtn);
            this.MainPanel.Location = new System.Drawing.Point(19, 18);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(350, 391);
            this.MainPanel.TabIndex = 9;
            // 
            // OrbitLogo
            // 
            this.OrbitLogo.AutoSize = true;
            this.OrbitLogo.BackColor = System.Drawing.Color.Transparent;
            this.OrbitLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrbitLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.OrbitLogo.Location = new System.Drawing.Point(74, 8);
            this.OrbitLogo.Name = "OrbitLogo";
            this.OrbitLogo.Size = new System.Drawing.Size(71, 21);
            this.OrbitLogo.TabIndex = 10;
            this.OrbitLogo.Text = "Selector";
            // 
            // TopbarTitle
            // 
            this.TopbarTitle.AutoSize = true;
            this.TopbarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopbarTitle.ForeColor = System.Drawing.Color.White;
            this.TopbarTitle.Location = new System.Drawing.Point(14, 8);
            this.TopbarTitle.Name = "TopbarTitle";
            this.TopbarTitle.Size = new System.Drawing.Size(131, 21);
            this.TopbarTitle.TabIndex = 9;
            this.TopbarTitle.Text = "Process Selector";
            // 
            // ProcessList
            // 
            this.ProcessList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ProcessList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProcessList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcessList.ForeColor = System.Drawing.Color.Gray;
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.ItemHeight = 21;
            this.ProcessList.Location = new System.Drawing.Point(14, 39);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.ScrollAlwaysVisible = true;
            this.ProcessList.Size = new System.Drawing.Size(323, 336);
            this.ProcessList.TabIndex = 8;
            this.ProcessList.TabStop = false;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.OnSelectedItem);
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExitBtn.Location = new System.Drawing.Point(327, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(20, 21);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FontTemplate
            // 
            this.FontTemplate.AutoSize = true;
            this.FontTemplate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontTemplate.Location = new System.Drawing.Point(35, 2);
            this.FontTemplate.Name = "FontTemplate";
            this.FontTemplate.Size = new System.Drawing.Size(0, 20);
            this.FontTemplate.TabIndex = 10;
            // 
            // ProcessSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(386, 425);
            this.Controls.Add(this.FontTemplate);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessSelector";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel MainPanel;
        private Label ExitBtn;
        private ListBox ProcessList;
        private Label OrbitLogo;
        private Label TopbarTitle;
        private Label FontTemplate;
    }
}