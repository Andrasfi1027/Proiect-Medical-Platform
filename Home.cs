using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace WinFormsApp1
{
        public partial class Home : Form, IDisposable
    {
        public Home()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void XPacientInterface_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void SpecialistButton_Click(object sender, EventArgs e)
        {
            ServiceSelection service = new ServiceSelection();
            this.Hide();
            service.ShowDialog();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info_Click(object sender, EventArgs e)
        {
           Information .Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Information.Hide();
        }

        private void Greutea_Click(object sender, EventArgs e)
        {
            WeightPanel.Show();
        }

        private void BackButtonWeight_Click(object sender, EventArgs e)
        {
            WeightPanel.Hide();
        }
    }
}
