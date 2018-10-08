using Ptc.NanlienCR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ptc.Demo.Domain.GoogleMap
{
    public class GooglePlacesPoint : Coordinate
    {
        public GooglePlacesPoint() : base()
        {


        }

        public GooglePlacesPoint(double Longitude, double Latitude) : base(Longitude, Latitude)
        {
            this.Longitude = Longitude;
            this.Latitude = Latitude;
        }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string LocationName { get; set; }

        public Boolean IsSpecific { get; set; }

        public decimal Rating { get; set; }

        public string ID { get; set; }

        public string Image { get; set; }
    }
}