using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_make
{
    class NaverMapApi
    {
        const string CLIENT_ID = "tur9orf38w";
        const string CLIENT_SECRET = "CBByzcuaFh75rNz3N7IRqFlf6ZkYuHyR2VohW2vC";
        const string NAVER_API_REQUEST_URL = "https://naveropenapi.apigw.ntruss.com/map-static/v2/raster?w=350&h=400&format=png";

        //static string tempAddr = "https://naveropenapi.apigw.ntruss.com/map-static/v2/raster?w=350&h=470&center=128.622030,35.896483&level=15&format=png";

        public static double longitude = 128.622030;
        public static double latitude = 35.896483;
        private static string positionCenter = "&center=" + longitude + "," + latitude;

        public static Image MapDownload(GeographyVector gv, int level)
        {
            latitude = gv.latitude;
            longitude = gv.longitude;
            positionCenter = "&center=" + longitude + "," + latitude;
            //MessageBox.Show(user.getAddrLevel(10));
            string tempAddr = getAddrLevel(level);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tempAddr);
            request.Headers.Add("X-NCP-APIGW-API-KEY-ID", CLIENT_ID);
            request.Headers.Add("X-NCP-APIGW-API-KEY", CLIENT_SECRET);

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                //Console.WriteLine($"StatusCode: {response.StatusCode}");
                Stream ReceiveStream = response.GetResponseStream();
                Image img = System.Drawing.Image.FromStream(ReceiveStream);
                //img.Save(@"\map.png", System.Drawing.Imaging.ImageFormat.Png);
                return img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                return null;
            }
        }

        public static string getAddrLevel(int level)
        {
            string buffer = "&level=" + level;
            return NAVER_API_REQUEST_URL + buffer + positionCenter;
        }
    }
}
