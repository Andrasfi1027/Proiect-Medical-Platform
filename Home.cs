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
using WinFormsApp1.Extension;

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
        // 1. Create an Overlay
        GMapOverlay markers = new GMapOverlay("markers");
        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.MapProvider = GoogleMapProvider.Instance;
            map.MinZoom = 5; // Minimum Zoom Level
            map.MaxZoom = 100; // Maximum Zoom Level
            map.Zoom = 10; // Current Zoom Level
            map.SetPositionByKeywords("Satu Mare,  Romania");
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

        // 1. Create an Overlay
        //GMapOverlay markers = new GMapOverlay("markers");
        private void button1_Click(object sender, EventArgs e)
        {
            //Reverse Geocoding
            if (!(txtLat.Text.Trim().Equals("") && txtLong.Text.Trim().Equals("")))
            {
                var point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                LoadAndMark(point);
                //LoadMap(point);
                // AddMarker(point);
                GeoCoderStatusCode statusCode;
                var placemark = GoogleMapProvider.Instance.GetPlacemark(point, out statusCode);
                if (statusCode == GeoCoderStatusCode.OK)
                {
                    txtAddress.Text = placemark?.Address;
                }
                else
                {
                    txtAddress.Text = "Something Went Wrong. Returned Status: " + statusCode;
                }
            }
            else
            {
                //Geocoding
                if (txtAddress.Text.Trim().Equals(""))
                {
                    GeoCoderStatusCode statusCode;
                    var pointLatLng = GoogleMapProvider.Instance.GetPoint(txtAddress.Text.Trim(), out statusCode);
                    if (statusCode == GeoCoderStatusCode.OK)
                    {
                        var pt = pointLatLng ?? default(PointLatLng);
                        txtLat.Text = pointLatLng?.Lat.ToString();
                        txtLong.Text = pointLatLng?.Lng.ToString();
                        LoadAndMark(pt);
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Returned Status Code: " + statusCode);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Data To Load");
                }
            }
            /*
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.SetPositionByKeywords("Arad,  România");
            map.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong));
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5; //Minimum Zoom Level
            map.MaxZoom = 100; //Maximum Zoom Level
            map.Zoom = 10; //Current Zoom Level
            PointLatLng point = new PointLatLng(lat, longt);
            Bitmap bmpMarker = Image.FromFile("");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            2. Add all available markers to that Overlay
            markers.Markers.Add(marker);
            3. Cover map with Overlay
            */
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
            map.RefreshMap();
            lbDistance.Text = route.Distance + @" km";
            //RefreshMap();
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(_points, "My Area")
            {
                Stroke = new Pen(Color.Blue, 2),
                Fill = new SolidBrush(Color.BurlyWood)
            };
            var polygons = new GMapOverlay("polygons");
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);
            map.RefreshMap();
            //RefreshMap();
        }

        private void btnRemoveOverlay_Click(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMouseClick.Checked == true && e.Button == MouseButtons.Right)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                txtLat.Text = lat + "";
                txtLong.Text = lng + "";

                //Load Location
                //map.Position = point;
                LoadMap(point);

                /*Adding Marker
                var markers = new GMapOverlay("markers");
                var marker = new GMarkerGoogle(pointToAdd, markerType);
                markers.Markers.Add(marker);
                */
                map.Overlays.Add(markers);
                AddMarker(point);

                // Get Address
                var addresses = GetAddress(point);

                //Display Address
                if (addresses != null)
                    txtAddress.Text = "Address: \n-------------------\n" + String.Join(", ", addresses.ToArray());
                else
                    txtAddress.Text = "Unable To Load Address";
            }
        }

        private void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.arrow)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType)
            {
                ToolTipText = $"Latitude: {Math.Round(map.Position.Lat)}, \n Longitude: {Math.Round(map.Position.Lng)}" //string interpolation
            };

            var toolTip = new GMapToolTip(marker)
            {
                Fill = new SolidBrush(Color.DarkBlue),
                Foreground = new SolidBrush(Color.White),
                Offset = new Point(50, -50),
                Stroke = new Pen(new SolidBrush(Color.Red))
            };

            marker.ToolTip = toolTip;

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statusCode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<String> addresses = new List<string>();
                foreach (var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;
        }

        private void LoadAndMark(PointLatLng point)
        {
            LoadMap(point);
            AddMarker(point);
        }

        private void btnSearchInsidePoly_Click(object sender, EventArgs e)
        {
            var pointToSearch = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
            //var pointToSearch = new PointLatLng(*specific coordinate(devinput)*);
            if(!SearchInsidePolygons(pointToSearch)) //== false
            {
                if(!SearchInPolygons(pointToSearch)) // == false
                {
                    MessageBox.Show("Location Not Found!");
                    return;
                }
            }
            MessageBox.Show("Location Found!");
        }
        /* private void RefreshMap()
         {
             map.Zoom--;
             map.Zoom++;
         }*/

        private bool SearchInPolygons(PointLatLng pointToSearch)
        {
            var overlays = map.Overlays;
            foreach (var overlay in overlays)
            {
                var polygons = overlay.Polygons;
                foreach(var polygon in polygons)
                {
                    foreach(var point in polygon.Points)
                    {
                        if(point == pointToSearch)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
    }

        private bool SearchInsidePolygons(PointLatLng pointToSearch)
        {
            var overlays = map.Overlays;
            foreach (var overlay in overlays)
            {
                var polygons = overlay.Polygons;

                foreach (var polygon in polygons)
                {
                    if (polygon.IsInside(pointToSearch))
                    {
                        polygon.Fill = new SolidBrush(Color.FromArgb(120, 10, 200, 100));
                        LoadMap(pointToSearch);
                        AddMarker(pointToSearch, GMarkerGoogleType.lightblue);
                        map.RefreshMap();
                        var ps = polygon.Points;
                        var ps1 = polygon.LocalPoints;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}