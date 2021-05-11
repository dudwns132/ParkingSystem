using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_make
{

    public partial class MainForm : Form
    {
        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        List<Parking> result;
        List<Parking> sortedResult;
        static User user = User.user;
        static GeographyVector nowGv = new GeographyVector(user.u_latitude, user.u_longitude);

        static int init = 0;
        int level = 13;
        public MainForm()
        {
            InitializeComponent();
            //MessageBox.Show(user.u_parking_time.ToString());
            MessageBox.Show(user.u_car_num.ToString());
            carNumBox.Text += user.u_car_num;
        }

        void childForm_Closed(Object sender, FormClosedEventArgs e)
        {
            Show();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Image img = NaverMapApi.MapDownload(nowGv, level);
            if (img != null) e.Graphics.DrawImage(img, new Point(0, 0));
            e.Graphics.FillEllipse(Brushes.Red, 170, 195, 10, 10);
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (level <= 15) {
                level = level + 1;
                Image img = NaverMapApi.MapDownload(nowGv, level);
                this.pictureBox1.Image = img;
            }
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (level >= 5) {
                level = level - 1;
                Image img = NaverMapApi.MapDownload(nowGv, level);
                this.pictureBox1.Image = img;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //if(e.X <= 155 && e.X >= 145 && e.Y <= 155 && e.Y >= 145) MessageBox.Show("현재 지점을 클릭하였습니다 !");
            //else MessageBox.Show("현재 위치가 아닙니다!");
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            result = conn.GetParkings(search_box.Text);

            if (result != null) {
                foreach (Parking parking in result) {
                    parking.distanceFromNow = GeographyVector.getDistance(new GeographyVector(user.u_latitude, user.u_longitude), new GeographyVector(parking.p_latitude, parking.p_longitude));

                }
                sortedResult = SortedParkingList(result);
                changeParking();

            }
            else
            {
                MessageBox.Show("결과가 없습니다.");
            }
        }

        private List<Parking> SortedParkingList(List<Parking> list) {
            for (int count = 1; count < list.Count(); count++) {
                for (int i = 0; i < list.Count() - count; i++) {
                    if (list[i].distanceFromNow > list[i + 1].distanceFromNow)
                    {
                        Parking temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }
            return list;
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            if (sortedResult != null)
            {
                if (init <= 0) init = sortedResult.Count - 1;
                else init--;
                changeParking();
            }
            else
            {
                return;
            }
        }


        private void next_btn_Click(object sender, EventArgs e)
        {
            if (sortedResult != null) {
                if (init >= sortedResult.Count - 1) init = 0;
                else init++;
                changeParking();
            }
            else
            {
                return;
            }
        }

        private void changeParking(){
            Parking p = sortedResult[init];

            p_name_text.Text = p.p_name;
            p_address_text.Text = p.p_address;
            p_pri_cost.Text = p.p_pri_cost.ToString() + "원";
            p_10m_cost.Text = p.p_cost_10m.ToString() + "원";
            now_max.Text = p.p_now_num + " / " + p.p_max_num;
            open_time.Text = p.p_open_time;
            close_time.Text = p.p_close_time;
            p_distance_text.Text = p.distanceFromNow + "m";
            nowGv.latitude = p.p_latitude;
            nowGv.longitude = p.p_longitude;
            //MessageBox.Show(p.p_latitude + ", " + p.p_longitude);
            Image img = NaverMapApi.MapDownload(nowGv, level);
            this.pictureBox1.Image = img;
        }


        private void showParkingForm()
        {

            Parking p = sortedResult[init];
            ParkingForm pForm = new ParkingForm();
            pForm.FormClosed += new FormClosedEventHandler(childForm_Closed);

            pForm.Passvalue = p.p_code;
            pForm.Show();
            this.Hide();
        }
        private void p_name_text_Click(object sender, EventArgs e)
        {
            if (sortedResult == null) return;
            showParkingForm();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parked_status_Click(object sender, EventArgs e)
        {
            Camera camera = conn.GetCamera(user.u_car_num);

            Parking parking = conn.GetParking(camera.p_code);

            MessageBox.Show(parking.p_name);
        }
    }
}
