namespace Orbit
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopbarTitle = new System.Windows.Forms.Label();
            this.OrbitLogo = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProcessStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SelectBtn = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logs = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DllBuild = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectDll = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.InjectBtn = new System.Windows.Forms.Label();
            this.bitVersion = new System.Windows.Forms.Label();
            this.InjectionWorker = new System.ComponentModel.BackgroundWorker();
            this.FormAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TopbarTitle
            // 
            this.TopbarTitle.AutoSize = true;
            this.TopbarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopbarTitle.ForeColor = System.Drawing.Color.White;
            this.TopbarTitle.Location = new System.Drawing.Point(249, 9);
            this.TopbarTitle.Name = "TopbarTitle";
            this.TopbarTitle.Size = new System.Drawing.Size(202, 21);
            this.TopbarTitle.TabIndex = 2;
            this.TopbarTitle.Text = "Welcome to Orbit Injector";
            // 
            // OrbitLogo
            // 
            this.OrbitLogo.AutoSize = true;
            this.OrbitLogo.BackColor = System.Drawing.Color.Transparent;
            this.OrbitLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrbitLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.OrbitLogo.Location = new System.Drawing.Point(342, 9);
            this.OrbitLogo.Name = "OrbitLogo";
            this.OrbitLogo.Size = new System.Drawing.Size(48, 21);
            this.OrbitLogo.TabIndex = 3;
            this.OrbitLogo.Text = "Orbit";
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ExitBtn.Location = new System.Drawing.Point(673, -1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(36, 21);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(709, 1);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.ProcessStatus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.SelectBtn);
            this.panel1.Controls.Add(this.ProcessName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(22, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 128);
            this.panel1.TabIndex = 8;
            // 
            // ProcessStatus
            // 
            this.ProcessStatus.AutoSize = true;
            this.ProcessStatus.BackColor = System.Drawing.Color.Transparent;
            this.ProcessStatus.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.ProcessStatus.Location = new System.Drawing.Point(131, 72);
            this.ProcessStatus.Name = "ProcessStatus";
            this.ProcessStatus.Size = new System.Drawing.Size(0, 19);
            this.ProcessStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(372, 62);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 1);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // SelectBtn
            // 
            this.SelectBtn.AutoSize = true;
            this.SelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SelectBtn.Location = new System.Drawing.Point(370, 39);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(55, 21);
            this.SelectBtn.TabIndex = 7;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessName.ForeColor = System.Drawing.Color.LightGray;
            this.ProcessName.Location = new System.Drawing.Point(143, 40);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(224, 23);
            this.ProcessName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Process :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.Logs);
            this.panel2.Location = new System.Drawing.Point(22, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 145);
            this.panel2.TabIndex = 9;
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Logs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Logs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logs.ForeColor = System.Drawing.Color.DarkGray;
            this.Logs.Location = new System.Drawing.Point(10, 9);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logs.Size = new System.Drawing.Size(415, 125);
            this.Logs.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.DllBuild);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.SelectDll);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.InjectBtn);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(469, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 286);
            this.panel3.TabIndex = 10;
            // 
            // DllBuild
            // 
            this.DllBuild.AutoSize = true;
            this.DllBuild.BackColor = System.Drawing.Color.Transparent;
            this.DllBuild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DllBuild.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DllBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.DllBuild.Location = new System.Drawing.Point(54, 187);
            this.DllBuild.Name = "DllBuild";
            this.DllBuild.Size = new System.Drawing.Size(0, 19);
            this.DllBuild.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Build:";
            // 
            // SelectDll
            // 
            this.SelectDll.AutoSize = true;
            this.SelectDll.BackColor = System.Drawing.Color.Transparent;
            this.SelectDll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectDll.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectDll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SelectDll.Location = new System.Drawing.Point(47, 157);
            this.SelectDll.Name = "SelectDll";
            this.SelectDll.Size = new System.Drawing.Size(84, 19);
            this.SelectDll.TabIndex = 13;
            this.SelectDll.Text = "Select DLL...";
            this.SelectDll.Click += new System.EventHandler(this.SelectDll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "DLL :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(79, 275);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 1);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // InjectBtn
            // 
            this.InjectBtn.AutoSize = true;
            this.InjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.InjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InjectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InjectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InjectBtn.Location = new System.Drawing.Point(78, 252);
            this.InjectBtn.Name = "InjectBtn";
            this.InjectBtn.Size = new System.Drawing.Size(60, 21);
            this.InjectBtn.TabIndex = 8;
            this.InjectBtn.Text = "INJECT";
            this.InjectBtn.Click += new System.EventHandler(this.InjectBtn_Click);
            // 
            // bitVersion
            // 
            this.bitVersion.AutoSize = true;
            this.bitVersion.BackColor = System.Drawing.Color.Transparent;
            this.bitVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bitVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bitVersion.Location = new System.Drawing.Point(0, -1);
            this.bitVersion.Name = "bitVersion";
            this.bitVersion.Size = new System.Drawing.Size(0, 21);
            this.bitVersion.TabIndex = 11;
            // 
            // InjectionWorker
            // 
            this.InjectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InjectionWorker_DoWork);
            // 
            // FormAnimation
            // 
            this.FormAnimation.Interval = 10;
            this.FormAnimation.Tick += new System.EventHandler(this.FormAnimation_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(708, 357);
            this.Controls.Add(this.bitVersion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OrbitLogo);
            this.Controls.Add(this.TopbarTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orbit - Main";
            this.TransparencyKey = System.Drawing.Color.Pink;
            this.Load += new System.EventHandler(this.MainOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label TopbarTitle;
        private Label OrbitLogo;
        private Label ExitBtn;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private TextBox ProcessName;
        private Label label3;
        private Label SelectBtn;
        private TextBox Logs;
        private Label InjectBtn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label ProcessStatus;
        private Label label4;
        private Label label2;
        private Label SelectDll;
        private Label bitVersion;
        private System.ComponentModel.BackgroundWorker InjectionWorker;
        private System.Windows.Forms.Timer FormAnimation;
        private Label DllBuild;
        private Label label5;
    }
}