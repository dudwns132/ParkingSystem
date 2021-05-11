using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_make
{
    public partial class LoginForm : Form
    {
        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        public LoginForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //창 닫기
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string result = conn.Login(idBox1.Text);
            if (result == MessageList.FAIL)
            {
                MessageBox.Show("아이디가 틀렸습니다!");
                return;
            }
            else if(pwBox.Text == result)
            {
                User temp = DataBaseConnection.Instance.GetUser(idBox1.Text);
                if (temp == null) MessageBox.Show("GetUser() Error");
                else User.user = temp;

                idBox1.Text = "";
                pwBox.Text = "";
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                idBox1.Text = "";
                pwBox.Text = "";
                MessageBox.Show("패스워드가 틀렸습니다!");
            }  
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            signUpForm signUpForm = new signUpForm();
            signUpForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            signUpForm.Show();
            this.Hide();
        }

        void childForm_Closed(object sender, FormClosedEventArgs e)
        {
            Show();
        }


        private void IdFindBtn_Click(object sender, EventArgs e)
        {
            IdFindForm idFindForm = new IdFindForm();
            idFindForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            idFindForm.Show();
            this.Hide();
        }

        private void pwFindBtn_Click(object sender, EventArgs e)
        {
            PwFindForm pwFindForm = new PwFindForm();
            pwFindForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            pwFindForm.Show();
            this.Hide();
        }
    }
}
