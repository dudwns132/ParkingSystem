using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_make
{
    class Camera
    {
        public int p_code;
        public int c_code;
        public int car_num;

        public Camera(int p_code,
                int c_code,
                int car_num)
        {
            this.p_code = p_code;
            this.c_code = c_code;
            this.car_num = car_num;
        }
    }
}
