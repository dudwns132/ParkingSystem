using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_make
{
    class Parking
    {

        public int p_code;
        public string p_name;
        public string p_address;
        public double p_latitude; // 위도
        public double p_longitude; // 경도
        public int p_max_num;
        public int p_now_num;
        public int p_pri_cost;
        public int p_cost_10m;
        public string p_open_time;
        public string p_close_time;
        public int distanceFromNow; 

        public Parking(int p_code,
            string p_name,
            string p_address,
            double p_latitude,
            double p_logitude,
            int p_max_num,
            int p_now_num,
            int p_pri_cost,
            int p_cost_10m,
            string p_open_time,
            string p_close_time)
        {
            this.p_code = p_code;
            this.p_name = p_name;
            this.p_address = p_address;
            this.p_latitude = p_latitude;
            this.p_longitude = p_logitude;
            this.p_max_num = p_max_num;
            this.p_now_num = p_now_num;
            this.p_pri_cost = p_pri_cost;
            this.p_cost_10m = p_cost_10m;
            this.p_open_time = p_open_time;
            this.p_close_time = p_close_time;
        }
    }
}
