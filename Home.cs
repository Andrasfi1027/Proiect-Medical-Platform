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
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace WinFormsApp1
{
    public partial class Home : Form, IDisposable
    {
        private List<PointLatLng> _points;
        public Home()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
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
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCYi6W-X0xmRapyFQk8LCyiaLAU3YVj1P8";
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            map.ShowCenter = false;
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
            Information.Show();
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

        private void MapButton_Click(object sender, EventArgs e)
        {
            Harta harta = new Harta();
            this.Hide();
            harta.ShowDialog();
        }

        private void ServiceMap_Click(object sender, EventArgs e)
        {
            ServicePanel.Show();
        }

        private void BackButtonService_Click(object sender, EventArgs e)
        {
            ServicePanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5; //Minimum Zoom Level
            map.MaxZoom = 100; //Maximum Zoom Level
            map.Zoom = 10; //Current Zoom Level

            PointLatLng point = new PointLatLng(lat, longt);

            //Bitmap bmpMarker = Image.FromFile("");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);

            // 1. Create an Overlay
            GMapOverlay markers = new GMapOverlay("markers");

            // 2. Add all available markers to that Overlay
            markers.Markers.Add(marker);

            // 3. Cover map with Overlay
            map.Overlays.Add(markers);
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text),
                Convert.ToDouble(txtLong.Text)));
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance
                .GetRoute(_points[0], _points[1], false, false, 14); 
            // beginning(0), destination(1), infoDisplay, walkOrDrive?, zoomLevel
            var r = new GMapRoute(route.Points, "My Route") 
            { Stroke = new Pen(Color.Red, 5) };

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);

            lbDistance.Text = route.Distance + " km";
        }
    }
}