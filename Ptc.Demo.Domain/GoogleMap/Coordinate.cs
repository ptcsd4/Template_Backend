using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptc.Demo.Domain.GoogleMap
{

    public class Coordinate
    {

        public Coordinate()
        {
        }
        public Coordinate(double Longitude, double Latitude)
        {
            this.lat = Latitude;
            this.lng = Longitude;
        }

        /// <summary>
        /// 經度
        /// </summary>
        public double lng { get; set; }

        /// <summary>
        /// 緯度
        /// </summary>
        public double lat { get; set; }

        public override string ToString()
        {
            return $"{ this.lat.ToString() },{this.lng.ToString()}";
        }


    }
}
