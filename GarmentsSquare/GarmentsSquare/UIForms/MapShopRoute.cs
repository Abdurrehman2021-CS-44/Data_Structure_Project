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
    public partial class MapShopRoute : Form
    {
        GMapOverlay markers;
        GMapOverlay routes;
        BL.Location location;
        string area;

        public MapShopRoute(BL.Location location, string area)
        {
            InitializeComponent();

            // overlays over map
            markers = new GMapOverlay("markers");
            routes = new GMapOverlay("routes");

            // adding them in map
            gMapAPI.Overlays.Add(markers);
            gMapAPI.Overlays.Add(routes);

            this.location = location;
            this.area = area;
        }


        // marking on the map
        public void createMarker(double lat, double lng)
        {
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MapShopRoute_Load(object sender, EventArgs e)
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
            // selecting position
            gMapAPI.SetPositionByKeywords("UET,Lahore,Pakistan");
            txtLat.Text = "31.5799";
            txtLng.Text = "74.3563";

            rtxtArea.Text = area;

            // marking on map
            createMarker(lat, lng);

            //gMapAPI.Position = new PointLatLng(location.Latitude, location.Longitude);
            createMarker(location.Latitude, location.Longitude);

            PointLatLng point1 = new PointLatLng(lat, lng);
            PointLatLng point2 = new PointLatLng(location.Latitude, location.Longitude);

            var route = GoogleMapProvider.Instance.GetRoute(point1, point2, false, false, 14);
            var r = new GMapRoute(route.Points, "My Routes");
            r.Stroke = new Pen(Color.Red, 3);

            double distance = r.Distance;
            txtDistance.Text = distance.ToString();

            routes.Routes.Add(r);
        }
    }
}
