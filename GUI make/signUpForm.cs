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
    public partial class signUpForm : Form
    {
        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        MessageList mList = new MessageList();
        public signUpForm()
        {
            InitializeComponent();

            MessageBox.Show(mList.hash[MessageList.HintType.HINT_TYPE_1].ToString());
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if (pwBox.Text == pwCheck.Text)
            {
                MessageBox.Show(mList.hash[hintBox1.SelectedItem].ToString());
                string result = conn.SignUp(idBox.Text,
                        pwBox.Text,
                        emailBox.Text,
                        nickBox.Text,
                        Int32.Parse(mList.hash[hintBox1.SelectedItem].ToString()),
                        hintBox.Text);
                if(result == MessageList.SUCCESS)
                {
                    MessageBox.Show("회원가입 성공");
                }
                else
                {
                    MessageBox.Show("회원가입 실패");
                }
            }
            else
            {
                pwBox.Text = "";
                pwCheck.Text = "";
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }
        }
    }
}
