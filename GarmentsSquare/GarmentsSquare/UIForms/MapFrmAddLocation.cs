using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GarmentsSquare.UIForms
{
    public partial class MapFrmAddLocation : Form
    {
        GMapOverlay markers;
        GMapOverlay markersShop;
        GMapOverlay routes;
        BL.Location location;
        string area;

        public MapFrmAddLocation(BL.Location location, string area)
        {
            InitializeComponent();

            // overlays over map
            markers = new GMapOverlay("markers");
            markersShop = new GMapOverlay("shops");
            routes = new GMapOverlay("routes");

            // adding them in map
            gMapAPI.Overlays.Add(markers);
            gMapAPI.Overlays.Add(markersShop);
            gMapAPI.Overlays.Add(routes);

            this.location = location;
            this.area = area;
        }

        private void MapFrm_Load(object sender, EventArgs e)
        {
            // API key
            GoogleMapProvider.Instance.ApiKey = @"AIzaSyDEhr2LJnyoNt6wO5JUraz27F04PowVhzQ";

            // draging over map setting
            gMapAPI.DragButton = MouseButtons.Left;

            // Google Maps
            gMapAPI.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gMapAPI.MinZoom = 5; // minimum zoom
            gMapAPI.MaxZoom = 30; // maximum zoom
            gMapAPI.Zoom = 15; // current zoom

            // initial position
            double lat = 31.5799;
            double lng = 74.3563;

            txtLat.Text = "31.5799";
            txtLng.Text = "74.3563";

            rtxtArea.Text = "UET,Lahore,Pakistan";

            //map.Position = new PointLatLng(lat, lng);

            // marking on map
            createMarker(lat, lng, markers, GMarkerGoogleType.red_dot);
            location.Latitude = lat;
            location.Longitude = lng;

            // selecting position
            gMapAPI.SetPositionByKeywords("UET,Lahore,Pakistan");
        }

        // marking on the map
        public void createMarker(double lat, double lng, GMapOverlay overlay, GMarkerGoogleType type)
        {
            overlay.Clear();
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, type);
            overlay.Markers.Add(marker);
        }

        private void btnSearchPoint_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(txtLat.Text);
            double lng = Convert.ToDouble(txtLng.Text);
            PointLatLng pointNew = new PointLatLng(lat, lng);

            gMapAPI.Position = new PointLatLng(lat, lng);

            List<string> addresses = new List<string>(); 

            List<Placemark> plc = null;
            var st = GMapProviders.GoogleMap.GetPlacemarks(pointNew, out plc);
            if (st == GeoCoderStatusCode.OK && plc != null)
            {
                foreach(var p in plc)
                {
                    addresses.Add(p.Address); 
                }

                rtxtArea.Text = addresses[0];
            }
            else
            {
                rtxtArea.Text = "";
            }
            location.Latitude = lat;
            location.Longitude = lng;
            PointLatLng point1 = new PointLatLng(lat, lng);
            createRoute(point1);
            createMarker(lat, lng, markersShop, GMarkerGoogleType.blue_dot);
        }

        private void btnSearchArea_Click(object sender, EventArgs e)
        {
            try
            {
                area = rtxtArea.Text;
                gMapAPI.SetPositionByKeywords(area);

                GeocodedWaypoint waypoint = new GeocodedWaypoint();
                

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void gMapAPI_MouseClick(object sender, MouseEventArgs e)
        {
            if ( checkBoxMouse.Checked == true && e.Button == MouseButtons.Left)
            {
                double lat = gMapAPI.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapAPI.FromLocalToLatLng(e.X, e.Y).Lng;

                List<string> addresses = new List<string>();
                var point = gMapAPI.FromLocalToLatLng(e.X, e.Y);
                List<Placemark> plc = null;
                var st = GMapProviders.GoogleMap.GetPlacemarks(point, out plc);
                if (st == GeoCoderStatusCode.OK && plc != null)
                {
                    foreach (var p in plc)
                    {
                        addresses.Add(p.Address);
                    }

                    rtxtArea.Text = addresses[0];
                }
                else
                {
                    rtxtArea.Text = "";
                }

                txtLat.Text = lat.ToString();
                txtLng.Text = lng.ToString();

                location.Latitude = lat;
                location.Longitude = lng;

                PointLatLng point1 = new PointLatLng(lat, lng);
                createRoute(point1);
                createMarker(lat, lng, markersShop, GMarkerGoogleType.blue_dot);
            }
        }

        private void createRoute(PointLatLng point1)
        {
            routes.Clear();
            PointLatLng point2 = new PointLatLng(31.5799, 74.3563);
            var route = GoogleMapProvider.Instance.GetRoute(point1, point2, false, false, 14);
            var r = new GMapRoute(route.Points, "My Routes");
            double distance = r.Distance;
            txtDistance.Text = distance.ToString();
            r.Stroke = new Pen(Color.Red, 3);

            routes.Routes.Add(r);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
