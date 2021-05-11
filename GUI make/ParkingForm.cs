using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_make
{
    public partial class ParkingForm : Form
    {
        int[,] array =
        {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };

        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        public int pCode;
        List<Camera> cList = new List<Camera>();
        public int Passvalue
        {
            set 
            {
                pCode = value;
            }
        }

        public ParkingForm()
        {
            InitializeComponent();
        }

        private void Parking_Ground_Paint(object sender, PaintEventArgs e)
        {
            cList = conn.GetCameras(pCode);
            int x = 10,
                y = 10,
                width = 30,
                height = 54;

            Graphics g = e.Graphics;

            Pen p = new Pen(Color.White, 2);
            int count = 0;
            
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++) { 
                    if(array[i, j] == 1) { 
                        Rectangle rec = new Rectangle(x, y, width, height);
                        RectangleF recF = new Rectangle(x+10, y, width-10, height);

                        if(count < cList.Count) {
                            if(cList[count].car_num != 0) { 
                                e.Graphics.DrawString(InserBackSlash(cList[count].car_num), Font, Brushes.White, recF);
                            }
                        }
                        count++;
                        g.DrawRectangle(p, rec);

                    }
                    x += width;
                }
                x = 10;
                y += height;
            }

        }

        private string InserBackSlash(int carNum)
        {
            string result = "";
            while (true)
            {
                int rest = carNum % 10;
                carNum = carNum / 10;
                result = rest + result;
                if (carNum != 0) result = "\n" + result;
                else return result;
            }
        }
    }
}
