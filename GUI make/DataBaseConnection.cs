using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Signers;

namespace GUI_make
{
    //DB Singleton object
    class DataBaseConnection{

        private static DataBaseConnection instance = null;

        public MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3306;Database=parking_project;Uid=root;Pwd=root");
        public static DataBaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBaseConnection();
                    instance.connection.Open();
                }
                return instance;
            }
        }

        public string Login(string id)
        {
            string sql = "SELECT u_pw FROM parking_project.user WHERE u_id='" + id + "'";
            string result;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {

                table.Read();

                if (table == null)
                {
                    result = MessageList.FAIL;
                }
                else
                {
                    result = table["u_pw"].ToString();
                }
                table.Close();
            }
            catch(Exception ex)
            {
                table.Close();
                result = ex.ToString();
            }
            return result;
        }

        public string SignUp(string id, string pw, string email, string nick, int hintType, string hint)
        {
            string temp = string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", id, pw, nick, email, hintType, hint);
            string sql = "INSERT INTO `parking_project`.`user` (`u_id`, `u_pw`, `u_nick`, `u_email`, `u_pass_hint_type`, `u_pass_hint_value`) VALUES " + temp;
            string result;
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    result = MessageList.SUCCESS;
                }
                else
                {
                    result = MessageList.FAIL;
                }
            }
            catch(Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }

        public List<Parking> GetParkings(string keyword)
        {
            
            string sql = string.Format("SELECT * FROM parking_project.parking where p_name like '%{0}%';", keyword);
            List<Parking> result = new List<Parking>();

            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                if (table == null)
                {
                    result = null;
                }

                while (table.Read())
                {
                    result.Add(new Parking(Int32.Parse(table["p_code"].ToString()),
                        table["p_name"].ToString(),
                        table["p_address"].ToString(),
                        Double.Parse(table["p_latitude"].ToString()),
                        Double.Parse(table["p_longitude"].ToString()),
                        Int32.Parse(table["p_max_num"].ToString()),
                        Int32.Parse(table["p_now_num"].ToString()),
                        Int32.Parse(table["p_pri_cost"].ToString()),
                        Int32.Parse(table["p_cost_10m"].ToString()),
                        table["p_open_time"].ToString(),
                        table["p_close_time"].ToString()));
                }

                table.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                table.Close();
                result = null;
            }
            return result;
        }

        public Parking GetParking(int p_code)
        {

            string sql = string.Format("SELECT * FROM parking_project.parking where p_code={0};", p_code);
            Parking result;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                if (table == null)
                {
                    result = null;
                }

                table.Read();
                result = new Parking(Int32.Parse(table["p_code"].ToString()),
                        table["p_name"].ToString(),
                        table["p_address"].ToString(),
                        Double.Parse(table["p_latitude"].ToString()),
                        Double.Parse(table["p_longitude"].ToString()),
                        Int32.Parse(table["p_max_num"].ToString()),
                        Int32.Parse(table["p_now_num"].ToString()),
                        Int32.Parse(table["p_pri_cost"].ToString()),
                        Int32.Parse(table["p_cost_10m"].ToString()),
                        table["p_open_time"].ToString(),
                        table["p_close_time"].ToString());

                table.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                table.Close();
                result = null;
            }
            return result;
        }
        public string FindIdByEmail(string email)
        {
            string sql = "SELECT u_id FROM parking_project.user WHERE u_email='" + email + "'";
            string result;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                table.Read();

                if (table == null)
                {
                    result = MessageList.FAIL;
                }
                else
                {
                    result = table["u_id"].ToString();
                }
                table.Close();
            }
            catch (Exception ex)
            {
                table.Close();
                result = ex.ToString();
            }
            return result;
        }

        public string FindPwByHint(string id, int hintType, string hint)
        {
            string temp = string.Format("where u_id='{0}' AND u_pass_hint_type={1} AND u_pass_hint_value='{2}';", id, hintType, hint);
            string sql = "SELECT u_pw FROM parking_project.user " + temp;
            string result;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                table.Read();

                if (table == null)
                {
                    result = MessageList.FAIL;
                }
                else
                {
                    result = table["u_pw"].ToString();
                }
                table.Close();
            }
            catch (Exception ex)
            {
                table.Close();
                result = ex.ToString();
            }
            return result;
        }

        public List<Camera> GetCameras(int p_code)
        {
            string sql = string.Format("SELECT * FROM parking_project.camera where p_code={0};", p_code);
            List<Camera> result = new List<Camera>(); 
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                if (table == null)
                {
                    result = null;
                }
                else
                {
                    while (table.Read())
                    { 
                        result.Add(new Camera(Int32.Parse(table["p_code"].ToString()),
                                               Int32.Parse(table["c_code"].ToString()),
                                               Int32.Parse(table["car_num"].ToString())));
                    }
                }
                table.Close();
            }
            catch
            {
                table.Close();
                result = null;
            }
            return result;
        }

        public Camera GetCamera(int car_num)
        {
            string sql = string.Format("SELECT * FROM parking_project.camera where car_num={0};", car_num);
            Camera result;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                if (table == null)
                {
                    result = null;
                }
                table.Read();

                result = new Camera(Int32.Parse(table["p_code"].ToString()),
                                    Int32.Parse(table["c_code"].ToString()),
                                    Int32.Parse(table["car_num"].ToString()));

                table.Close();
            }
            catch
            {
                table.Close();
                result = null;
            }
            return result;
        }
        public User GetUser(string id)
        {
            string sql = string.Format("SELECT * FROM parking_project.user where u_id='{0}';", id);
            User result = null;
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader table = command.ExecuteReader();
            try
            {
                if (table == null)
                {
                    result = null;
                }
                else
                {
                    table.Read();
                    result = new User(table["u_nick"].ToString(),
                                double.Parse(table["u_latitude"].ToString()),
                                double.Parse(table["u_longitude"].ToString()),
                                int.Parse(table["u_status"].ToString()),
                                Int32.Parse(table["u_car_num"].ToString()));
                }
                table.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("GetUser()_Exception : " + ex.ToString());
                table.Close();
                result = null;
            }
            return result;
        }
    }
}

















