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
            this.HomeIcon = new System.Windows.Forms.PictureBox();
            this.XPacientInterface = new System.Windows.Forms.PictureBox();
            this.MedicSpecialistPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SpecialistButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPacientInterface)).BeginInit();
            this.MedicSpecialistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistButton)).BeginInit();
            this.SuspendLayout();
            // 
            // BineAtiVenit
            // 
            this.BineAtiVenit.BackColor = System.Drawing.Color.Transparent;
            this.BineAtiVenit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BineAtiVenit.Location = new System.Drawing.Point(145, 124);
            this.BineAtiVenit.Name = "BineAtiVenit";
            this.BineAtiVenit.Size = new System.Drawing.Size(309, 45);
            this.BineAtiVenit.TabIndex = 0;
            this.BineAtiVenit.Text = "Bine ati revenit!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Black;
            this.TimeLabel.Location = new System.Drawing.Point(1161, 91);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(72, 31);
            this.TimeLabel.TabIndex = 10;
            this.TimeLabel.Text = "Time";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(986, 126);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(97, 43);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.HomeIcon);
            this.panel1.Controls.Add(this.XPacientInterface);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 66);
            this.panel1.TabIndex = 12;
            // 
            // HomeIcon
            // 
            this.HomeIcon.Image = ((System.Drawing.Image)(resources.GetObject("HomeIcon.Image")));
            this.HomeIcon.Location = new System.Drawing.Point(38, 9);
            this.HomeIcon.Name = "HomeIcon";
            this.HomeIcon.Size = new System.Drawing.Size(66, 44);
            this.HomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeIcon.TabIndex = 19;
            this.HomeIcon.TabStop = false;
            // 
            // XPacientInterface
            // 
            this.XPacientInterface.Image = ((System.Drawing.Image)(resources.GetObject("XPacientInterface.Image")));
            this.XPacientInterface.Location = new System.Drawing.Point(1328, 13);
            this.XPacientInterface.Name = "XPacientInterface";
            this.XPacientInterface.Size = new System.Drawing.Size(57, 37);
            this.XPacientInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XPacientInterface.TabIndex = 18;
            this.XPacientInterface.TabStop = false;
            this.XPacientInterface.Click += new System.EventHandler(this.XPacientInterface_Click);
            // 
            // MedicSpecialistPanel
            // 
            this.MedicSpecialistPanel.BackColor = System.Drawing.Color.Transparent;
            this.MedicSpecialistPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MedicSpecialistPanel.BackgroundImage")));
            this.MedicSpecialistPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MedicSpecialistPanel.Controls.Add(this.label1);
            this.MedicSpecialistPanel.Controls.Add(this.SpecialistButton);
            this.MedicSpecialistPanel.Location = new System.Drawing.Point(143, 202);
            this.MedicSpecialistPanel.Name = "MedicSpecialistPanel";
            this.MedicSpecialistPanel.Size = new System.Drawing.Size(298, 158);
            this.MedicSpecialistPanel.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(15, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Medici Specialisti";
            // 
            // SpecialistButton
            // 
            this.SpecialistButton.BackColor = System.Drawing.Color.Transparent;
            this.SpecialistButton.Image = ((System.Drawing.Image)(resources.GetObject("SpecialistButton.Image")));
            this.SpecialistButton.Location = new System.Drawing.Point(98, 3);
            this.SpecialistButton.Name = "SpecialistButton";
            this.SpecialistButton.Size = new System.Drawing.Size(106, 112);
            this.SpecialistButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpecialistButton.TabIndex = 0;
            this.SpecialistButton.TabStop = false;
            this.SpecialistButton.Click += new System.EventHandler(this.SpecialistButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(143, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 158);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(524, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 158);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(524, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 158);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(903, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 158);
            this.panel6.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(903, 433);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 158);
            this.panel7.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1397, 653);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MedicSpecialistPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.HomeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XPacientInterface)).EndInit();
            this.MedicSpecialistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpecialistButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label BineAtiVenit;
        private Label TimeLabel;
        private Label DateLabel;
        private Panel panel1;
        private Panel MedicSpecialistPanel;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox XPacientInterface;
        private System.Windows.Forms.Timer timer1;
        private PictureBox HomeIcon;
        private Label label1;
        private PictureBox SpecialistButton;
    }
}