namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void MedicButton_Click(object sender, EventArgs e)
        {
            LoginMedic.Show();
        }

        private void XButtonPacient_Click(object sender, EventArgs e)
        {
            LoginPacient.Hide();
        }

        private void PacientButton_Click(object sender, EventArgs e)
        {
            LoginPacient.Show();
        }

        private void XButtonMedic_Click(object sender, EventArgs e)
        {
            LoginMedic.Hide();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButtonPacient_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }
    }
}