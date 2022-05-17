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

        private void DownButtonW_Click(object sender, EventArgs e)
        {
            GF1.Hide();
            Inaltime.Hide();
            GB1.Hide();
            GF2.Show();
            Inaltime2.Show();
            GB2.Show();
            UpButtonW.Show();
            DownButtonW.Hide();
            DownButtonW2.Show();
        }

        private void UpButtonW_Click(object sender, EventArgs e)
        {
            UpButtonW.Hide();
            DownButtonW2.Hide();
            DownButtonW.Show();
            GF2.Hide();
            Inaltime2.Hide();
            GB2.Hide();
            GF1.Show();
            Inaltime.Show();
            GB1.Show();
        }

        private void DownButtonW2_Click(object sender, EventArgs e)
        {
            DownButtonW2.Hide();
            UpButtonW2.Show();
            GF2.Hide();
            Inaltime2.Hide();
            GB2.Hide();
            GF3.Show();
            Inaltime3.Show();
            GB3.Show();
        }

        private void UpButtonW2_Click(object sender, EventArgs e)
        {
            UpButtonW2.Hide();
            GF3.Hide();
            Inaltime3.Hide();
            GB3.Hide();
            GF2.Show();
            Inaltime2.Show();
            GB2.Show();
            DownButtonW2.Show();
        }

        private void Tensiunea_Click(object sender, EventArgs e)
        {
            TensionPanel.Show();
        }

        private void BackButtonTension_Click(object sender, EventArgs e)
        {
            TensionPanel.Hide();
        }

        private void Glicemie_Click(object sender, EventArgs e)
        {
            GlicemiePanel.Show();
        }

        private void BackButtonG_Click(object sender, EventArgs e)
        {
            GlicemiePanel.Hide();
        }

        private void TempButton_Click(object sender, EventArgs e)
        {
            TemperaturePanel.Show();
        }

        private void BackButtonTemp_Click(object sender, EventArgs e)
        {
            TemperaturePanel.Hide();
        }

        private void SaturatieButton_Click(object sender, EventArgs e)
        {
            SaturationPanel.Show();
        }

        private void BackButtonSA_Click(object sender, EventArgs e)
        {
            SaturationPanel.Hide();
        }
    }
}