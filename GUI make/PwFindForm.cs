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
    public partial class PwFindForm : Form
    {
        readonly DataBaseConnection conn = DataBaseConnection.Instance;
        MessageList mList = new MessageList();
        public PwFindForm()
        {
            InitializeComponent();
        }


        private void ReturnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string result = conn.FindPwByHint(IdBox.Text,
                    Int32.Parse(mList.hash[HintTypeBox.SelectedItem].ToString()),
                    AnswerBox.Text);

            if (result.Contains("MySql") == true)
            {
                MessageBox.Show("패스워드 찾기에 실패했습니다");
            }
            else
            {
                MessageBox.Show("패스워드는 " + result + "입니다.");
            }
        }
    }
}
