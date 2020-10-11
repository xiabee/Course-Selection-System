using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCSystem
{
    public partial class Form_SCT : Form
    {
        private string SSno, SSname;
        private int CTnum;
        private double CTcredit;
        private bool submited;

        public Form_SCT()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("../../img/back2.jpg");
            // 二进制文件在debug目录中，需要返回二级目录
        }
        public Form_SCT(string sno, string sname)  // 窗体构造函数
        {
            SSno = sno;
            SSname = sname;
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("../../img/back2.jpg");
            // 二进制文件在debug目录中，需要返回二级目录
        }

        private double countCredit()  // 计算当前学分
        {
            int CTnum = dataSet_yixuan1.Tables[0].Rows.Count;
            double credit = 0;
            for (int i = 0; i < CTnum; i++)
                credit += Convert.ToDouble(dataSet_yixuan1.Tables[0].Rows[i][3].ToString());
            return credit;
        }

        private bool checkRequire()  // 检查是否满足选课要求
        {
            if (CTnum > 5 || CTnum < 3)
            {
                MessageBox.Show("课程数量须在3-5之间！","Error");
                return false;
            }
            if (CTcredit > 12 || CTcredit < 9)
            {
                MessageBox.Show("课程总学分须在9-12之间！", "Error");
                return false;
            }
            return true;
        }

        private void display()
        // 显示已选和可选课程信息
        {
            string oldselect1 = oleDbDataAdapter_kexuan.SelectCommand.CommandText;
            string oldselect2 = oleDbDataAdapter_yixuan.SelectCommand.CommandText;

            string wheresmt1 = " WHERE cno NOT IN ( SELECT cno FROM SC WHERE sno = '" + SSno + "');";
            //查询可选课程
            string wheresmt2 = " WHERE cno IN ( SELECT cno FROM SC WHERE sno = '" + SSno + "');";
            //查询已选课程

            string sql1 = oldselect1 + wheresmt1;
            string sql2 = oldselect1 + wheresmt2;
            // 使用命令对象进行查询操作

            oleDbDataAdapter_kexuan.SelectCommand.CommandText = sql1;
            dataSet_kexuan1.Clear();
            oleDbDataAdapter_kexuan.Fill(dataSet_kexuan1);
            oleDbDataAdapter_kexuan.SelectCommand.CommandText = oldselect1;

            oleDbDataAdapter_yixuan.SelectCommand.CommandText = sql2;
            dataSet_yixuan1.Clear();
            oleDbDataAdapter_yixuan.Fill(dataSet_yixuan1);
            oleDbDataAdapter_yixuan.SelectCommand.CommandText = oldselect2;
            // 填充表单

            label_Cnum.Text = dataSet_yixuan1.Tables[0].Rows.Count.ToString();
            label_Ccre.Text = countCredit().ToString();
            CTnum = dataSet_yixuan1.Tables[0].Rows.Count;
            CTcredit = countCredit();
        }
        private void Form_SCT_Load(object sender, EventArgs e)
        {
            //学号、姓名Label赋值
            label_sno.Text = SSno;
            label_sname.Text = SSname;
            display();
            
        }

        private void Form_SCT_FormClosing(object sender, FormClosingEventArgs e)  // 窗口关闭的事件
        {
            if (this.submited)
                return;
            // 直接提交
            DialogResult dr;
            dr = MessageBox.Show("当前选课状态未提交，确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }



        private void but_sel_Click(object sender, EventArgs e)  //选课按钮
        {
            //使用数据集对象进行插入
            if (null == dataGridView_kexuan.CurrentRow)
                return;
            //未实例化，直接结束函数

            int curRow = dataGridView_kexuan.CurrentRow.Index;

            DataRow row = dataSet_SC1.SC.NewRow();
            row["sno"] = this.SSno;
            row["cno"] = dataGridView_kexuan.Rows[curRow].Cells[0].Value.ToString();    //获取课程号
            row["sta"] = 0;
            // 0 为临时保存
            dataSet_SC1.SC.Rows.InsertAt(row, 0);
            oleDbDataAdapter_SC.Update(dataSet_SC1, "SC");
            display();
            this.submited = false;
            // 记录修改

            this.Text = "选课系统*";
        }

        private void but_del_Click(object sender, EventArgs e)  //退课按钮
        {
            //使用命令对象进行删除
            if (null == dataGridView_yixuan.CurrentRow)
                return;
            // 未实例化，直接结束函数

            int curRow = dataGridView_yixuan.CurrentRow.Index;
            string sno = this.SSno;
            string cno = dataGridView_yixuan.Rows[curRow].Cells[0].Value.ToString();    //获取课程号

            string strdel = "DELETE SC WHERE sno = " + sno + " AND cno = " + cno + ";";
            
            OleDbCommand del = new OleDbCommand(strdel, oleDbConnection1);
            this.oleDbConnection1.Open();
            del.ExecuteNonQuery();
            this.oleDbConnection1.Close();
            
            display();
            this.submited = false;
            // 记录修改

            this.Text = "选课系统*";
        }


        private void submit_Click(object sender, EventArgs e)
        {
            string upt = "UPDATE SC SET sta = 1 WHERE Sno = " + SSno + ";";
            // 使用命令对象

            DialogResult MsgBoxResult;
            MsgBoxResult = MessageBox.Show("确认提交吗", "提示",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
            if (MsgBoxResult == DialogResult.No)
                return;
            
            if (!checkRequire())
                return;
            // 检查选课是否符合选课规定

            OleDbCommand del = new OleDbCommand(upt, oleDbConnection1);
            this.oleDbConnection1.Open();
            del.ExecuteNonQuery();
            this.oleDbConnection1.Close();

            MessageBox.Show("提交成功！", "");
            this.submited = true;
            // 记录修改

            this.Text = "选课系统";
        }
    }
}
