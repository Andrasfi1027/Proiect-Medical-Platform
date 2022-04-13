namespace WinFormsApp1
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BineAtiVenit = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.XPacientInterface = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XPacientInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // BineAtiVenit
            // 
            this.BineAtiVenit.AutoSize = true;
            this.BineAtiVenit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BineAtiVenit.Location = new System.Drawing.Point(145, 116);
            this.BineAtiVenit.Name = "BineAtiVenit";
            this.BineAtiVenit.Size = new System.Drawing.Size(298, 50);
            this.BineAtiVenit.TabIndex = 0;
            this.BineAtiVenit.Text = "Bine ati revenit!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1161, 85);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(70, 32);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(986, 118);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(98, 47);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.XPacientInterface);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 62);
            this.panel1.TabIndex = 12;
            // 
            // XPacientInterface
            // 
            this.XPacientInterface.Image = ((System.Drawing.Image)(resources.GetObject("XPacientInterface.Image")));
            this.XPacientInterface.Location = new System.Drawing.Point(1328, 12);
            this.XPacientInterface.Name = "XPacientInterface";
            this.XPacientInterface.Size = new System.Drawing.Size(57, 35);
            this.XPacientInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XPacientInterface.TabIndex = 18;
            this.XPacientInterface.TabStop = false;
            this.XPacientInterface.Click += new System.EventHandler(this.XPacientInterface_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(143, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 148);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(143, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 148);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(524, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 148);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(524, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 148);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(903, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 148);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(903, 406);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 148);
            this.panel7.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1397, 612);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BineAtiVenit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XPacientInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BineAtiVenit;
        private Label TimeLabel;
        private Label DateLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox XPacientInterface;
        private System.Windows.Forms.Timer timer1;
    }
}