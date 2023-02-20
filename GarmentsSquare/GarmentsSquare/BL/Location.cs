using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarmentsSquare.BL
{
    public class Location
    {
        private double latitude;
        private double longitude;

        // constructors 
        public Location()
        {
            this.latitude = 0;
            this.longitude = 0;
        }
        public Location(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public void Change(double L1, double L2)
        {
            this.latitude = L1;
            this.longitude = L2;
        }
        // getters setters

        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
    }
}
