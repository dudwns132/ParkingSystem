using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GUI_make
{
    class User
    {
        public string u_nick;
        public double u_latitude;
        public double u_longitude;
        public int u_status;
        public int u_car_num;
        public DateTime u_parking_time;

        public static User user = null;

        public User(string u_nick,
            double u_latitude,
            double u_longitude,
            int u_status,
            int u_car_num)
        {
            this.u_nick = u_nick;
            this.u_latitude = u_latitude;
            this.u_longitude = u_longitude;
            this.u_status = u_status;
            this.u_car_num = u_car_num;
            this.u_parking_time = new DateTime();
        }
    }
}
