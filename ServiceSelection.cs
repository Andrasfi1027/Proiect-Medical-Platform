using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ServiceSelection : Form
    {
        public ServiceSelection()
        {
            InitializeComponent();
        }

        private void XPacientInterface_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void DownButton1_Click(object sender, EventArgs e)
        {
            PanelFirst.Visible = false;
            PanelNext.Visible = true;
        }

        private void DownButton2_Click(object sender, EventArgs e)
        {
            PanelNext2.Visible = true;
            PanelNext.Visible = false;
        }

        private void UpperButton1_Click(object sender, EventArgs e)
        {
            PanelNext.Visible = false;
            PanelFirst.Visible = true;
        }

        private void UpperButton2_Click(object sender, EventArgs e)
        {
            PanelNext.Visible = true;
            PanelNext2.Visible = false;
        }

        private void ServiceSelection_Load(object sender, EventArgs e)
        {
            PanelNext.Visible = false;
            PanelNext2.Visible = false;
        }
    }
}
