using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCSystem
{
    public partial class Form_login : Form
    {
        public string sno, sname;
        public Form_login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("../../img/back1.jpg");
            // 二进制文件在debug目录中，需要返回二级目录
        }


        private void login_Click(object sender, EventArgs e)
        {
            if (input_sno.Text.ToString().Length == 0)
            {
                MessageBox.Show("请输入学号","Error");
                return;
            }
            this.sno = input_sno.Text;
            string cmdstring = "SELECT sname FROM Stu WHERE sno = '" + this.sno + "';";
            OleDbCommand cmd = new OleDbCommand(cmdstring, oleDbConnection_Stu);
            oleDbConnection_Stu.Open();
            object fst = cmd.ExecuteScalar();   //返回查询结果第一行第一列

            if (null == fst)    //找不到学号
            {
                MessageBox.Show("请输入正确的学号", "Error");
                oleDbConnection_Stu.Close();
                return;
            }
            else
            {
                out_sname.Text = fst.ToString();    //显示学号
                this.sname = fst.ToString();
                oleDbConnection_Stu.Close();
            }

            
            enter.Visible = true;
            login.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_SCT formSC = new Form_SCT(sno, sname);  // 创建一个新的窗口对象
            formSC.Show();
        }

    }
}
