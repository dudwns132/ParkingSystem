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
    public partial class IdFindForm : Form
    {
        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        public IdFindForm()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            IdFindForm.show();
        }

        private void ReturnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PwFind_Click(object sender, EventArgs e)
        {
            PwFindForm pwFindForm = new PwFindForm();
            pwFindForm.FormClosed += new FormClosedEventHandler(PwFormClosed);
            pwFindForm.Show();
            this.Hide();
        }

        private void PwFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string result = conn.FindIdByEmail(idBox1.Text.ToString());

            if (result.Contains("MySql") == true)
            {
                MessageBox.Show("존재하지 않는 이메일 입니다.");
            }
            else
            { 
                MessageBox.Show("아이디는 " + result + "입니다.");
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
