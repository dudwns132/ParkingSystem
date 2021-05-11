using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_make
{
    class GeographyVector
    {
        public double latitude;
        public double longitude;

        public GeographyVector(double latitude, double logitude)
        {
            this.latitude = latitude;
            this.longitude = logitude;
        }

        public static int getDistance(GeographyVector v1, GeographyVector v2)
        {
            int result;

            double latitudeDistance = 111941 * Math.Abs(v1.latitude - v2.latitude);
            double longitudeDistance = 90000 * Math.Abs(v1.longitude - v2.longitude);

            double temp = latitudeDistance * latitudeDistance + longitudeDistance * longitudeDistance;
            result = (int)Math.Sqrt(temp);
            return result;
        }
    }
}
