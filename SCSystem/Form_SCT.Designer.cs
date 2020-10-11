namespace SCSystem
{
    partial class Form_SCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SCT));
            this.title = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.Label();
            this.yixuan = new System.Windows.Forms.Label();
            this.kexuan = new System.Windows.Forms.Label();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbDataAdapter_yixuan = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter_kexuan = new System.Data.OleDb.OleDbDataAdapter();
            this.label_sno = new System.Windows.Forms.Label();
            this.label_sname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cnum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Ccre = new System.Windows.Forms.Label();
            this.dataSet_kexuan1 = new SCSystem.DataSet_kexuan();
            this.but_sel = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.dataSet_yixuan1 = new SCSystem.DataSet_yixuan();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter_SC = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet_SC1 = new SCSystem.DataSet_SC();
            this.dataGridView_yixuan = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_kexuan = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startweekDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endweekDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_kexuan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_yixuan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yixuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kexuan)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(472, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(222, 28);
            this.title.TabIndex = 0;
            this.title.Text = "XIABEE 选课系统";
            // 
            // rules
            // 
            this.rules.AutoSize = true;
            this.rules.BackColor = System.Drawing.Color.Transparent;
            this.rules.Cursor = System.Windows.Forms.Cursors.Default;
            this.rules.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rules.Location = new System.Drawing.Point(113, 58);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(104, 19);
            this.rules.TabIndex = 1;
            this.rules.Text = "选课规则：";
            // 
            // yixuan
            // 
            this.yixuan.AutoSize = true;
            this.yixuan.BackColor = System.Drawing.Color.Transparent;
            this.yixuan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yixuan.Location = new System.Drawing.Point(967, 131);
            this.yixuan.Name = "yixuan";
            this.yixuan.Size = new System.Drawing.Size(89, 20);
            this.yixuan.TabIndex = 2;
            this.yixuan.Text = "已选课程";
            // 
            // kexuan
            // 
            this.kexuan.AutoSize = true;
            this.kexuan.BackColor = System.Drawing.Color.Transparent;
            this.kexuan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kexuan.ForeColor = System.Drawing.Color.Black;
            this.kexuan.Location = new System.Drawing.Point(967, 365);
            this.kexuan.Name = "kexuan";
            this.kexuan.Size = new System.Drawing.Size(89, 20);
            this.kexuan.TabIndex = 3;
            this.kexuan.Text = "可选课程";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT  Cou.cno, Cou.cname, Cou.tname, Cou.credit, Cou.start_week, Cou.end_week, " +
    "Cou.start_time, Cou.end_time\r\nFROM   Cou";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=CS";
            // 
            // oleDbDataAdapter_yixuan
            // 
            this.oleDbDataAdapter_yixuan.DeleteCommand = this.oleDbDeleteCommand;
            this.oleDbDataAdapter_yixuan.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter_yixuan.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cou", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cno", "cno"),
                        new System.Data.Common.DataColumnMapping("cname", "cname"),
                        new System.Data.Common.DataColumnMapping("tname", "tname"),
                        new System.Data.Common.DataColumnMapping("credit", "credit"),
                        new System.Data.Common.DataColumnMapping("start_week", "start_week"),
                        new System.Data.Common.DataColumnMapping("end_week", "end_week"),
                        new System.Data.Common.DataColumnMapping("start_time", "start_time"),
                        new System.Data.Common.DataColumnMapping("end_time", "end_time")})});
            this.oleDbDataAdapter_yixuan.UpdateCommand = this.oleDbUpdateCommand;
            // 
            // oleDbDeleteCommand
            // 
            this.oleDbDeleteCommand.CommandText = "DELETE FROM [Cou] WHERE (([cno] = ?) AND ([cname] = ?) AND ([tname] = ?) AND ([cr" +
    "edit] = ?) AND ([start_week] = ?) AND ([end_week] = ?) AND ([start_time] = ?) AN" +
    "D ([end_time] = ?))";
            this.oleDbDeleteCommand.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_cno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_cname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_tname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_time", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbUpdateCommand
            // 
            this.oleDbUpdateCommand.CommandText = resources.GetString("oleDbUpdateCommand.CommandText");
            this.oleDbUpdateCommand.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("cno", System.Data.OleDb.OleDbType.VarChar, 0, "cno"),
            new System.Data.OleDb.OleDbParameter("cname", System.Data.OleDb.OleDbType.VarChar, 0, "cname"),
            new System.Data.OleDb.OleDbParameter("tname", System.Data.OleDb.OleDbType.VarChar, 0, "tname"),
            new System.Data.OleDb.OleDbParameter("credit", System.Data.OleDb.OleDbType.Integer, 0, "credit"),
            new System.Data.OleDb.OleDbParameter("start_week", System.Data.OleDb.OleDbType.Integer, 0, "start_week"),
            new System.Data.OleDb.OleDbParameter("end_week", System.Data.OleDb.OleDbType.Integer, 0, "end_week"),
            new System.Data.OleDb.OleDbParameter("start_time", System.Data.OleDb.OleDbType.Integer, 0, "start_time"),
            new System.Data.OleDb.OleDbParameter("end_time", System.Data.OleDb.OleDbType.Integer, 0, "end_time"),
            new System.Data.OleDb.OleDbParameter("Original_cno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_cname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_tname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_time", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT  Cou.cno, Cou.cname, Cou.tname, Cou.credit, Cou.start_week, Cou.end_week, " +
    "Cou.start_time, Cou.end_time\r\nFROM      Cou";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("cno", System.Data.OleDb.OleDbType.VarChar, 0, "cno"),
            new System.Data.OleDb.OleDbParameter("cname", System.Data.OleDb.OleDbType.VarChar, 0, "cname"),
            new System.Data.OleDb.OleDbParameter("tname", System.Data.OleDb.OleDbType.VarChar, 0, "tname"),
            new System.Data.OleDb.OleDbParameter("credit", System.Data.OleDb.OleDbType.Integer, 0, "credit"),
            new System.Data.OleDb.OleDbParameter("start_week", System.Data.OleDb.OleDbType.Integer, 0, "start_week"),
            new System.Data.OleDb.OleDbParameter("end_week", System.Data.OleDb.OleDbType.Integer, 0, "end_week"),
            new System.Data.OleDb.OleDbParameter("start_time", System.Data.OleDb.OleDbType.Integer, 0, "start_time"),
            new System.Data.OleDb.OleDbParameter("end_time", System.Data.OleDb.OleDbType.Integer, 0, "end_time"),
            new System.Data.OleDb.OleDbParameter("Original_cno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_cname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_tname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_time", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM [Cou] WHERE (([cno] = ?) AND ([cname] = ?) AND ([tname] = ?) AND ([cr" +
    "edit] = ?) AND ([start_week] = ?) AND ([end_week] = ?) AND ([start_time] = ?) AN" +
    "D ([end_time] = ?))";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_cno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_cname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_tname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "tname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_credit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "credit", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_week", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_week", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_start_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "start_time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_end_time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "end_time", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter_kexuan
            // 
            this.oleDbDataAdapter_kexuan.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter_kexuan.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter_kexuan.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Cou", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cno", "cno"),
                        new System.Data.Common.DataColumnMapping("cname", "cname"),
                        new System.Data.Common.DataColumnMapping("tname", "tname"),
                        new System.Data.Common.DataColumnMapping("credit", "credit"),
                        new System.Data.Common.DataColumnMapping("start_week", "start_week"),
                        new System.Data.Common.DataColumnMapping("end_week", "end_week"),
                        new System.Data.Common.DataColumnMapping("start_time", "start_time"),
                        new System.Data.Common.DataColumnMapping("end_time", "end_time")})});
            this.oleDbDataAdapter_kexuan.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // label_sno
            // 
            this.label_sno.AutoSize = true;
            this.label_sno.BackColor = System.Drawing.Color.Transparent;
            this.label_sno.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sno.Location = new System.Drawing.Point(102, 112);
            this.label_sno.Name = "label_sno";
            this.label_sno.Size = new System.Drawing.Size(49, 20);
            this.label_sno.TabIndex = 6;
            this.label_sno.Text = "学号";
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.BackColor = System.Drawing.Color.Transparent;
            this.label_sname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sname.Location = new System.Drawing.Point(338, 112);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(49, 20);
            this.label_sname.TabIndex = 7;
            this.label_sname.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(473, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "已选课程数：";
            // 
            // label_Cnum
            // 
            this.label_Cnum.AutoSize = true;
            this.label_Cnum.BackColor = System.Drawing.Color.Transparent;
            this.label_Cnum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Cnum.Location = new System.Drawing.Point(602, 112);
            this.label_Cnum.Name = "label_Cnum";
            this.label_Cnum.Size = new System.Drawing.Size(0, 20);
            this.label_Cnum.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(703, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "已选课程总学分：";
            // 
            // label_Ccre
            // 
            this.label_Ccre.AutoSize = true;
            this.label_Ccre.BackColor = System.Drawing.Color.Transparent;
            this.label_Ccre.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Ccre.Location = new System.Drawing.Point(872, 112);
            this.label_Ccre.Name = "label_Ccre";
            this.label_Ccre.Size = new System.Drawing.Size(0, 20);
            this.label_Ccre.TabIndex = 11;
            // 
            // dataSet_kexuan1
            // 
            this.dataSet_kexuan1.DataSetName = "DataSet_kexuan";
            this.dataSet_kexuan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // but_sel
            // 
            this.but_sel.BackColor = System.Drawing.Color.White;
            this.but_sel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_sel.Location = new System.Drawing.Point(69, 647);
            this.but_sel.Name = "but_sel";
            this.but_sel.Size = new System.Drawing.Size(128, 56);
            this.but_sel.TabIndex = 12;
            this.but_sel.Text = "选课";
            this.but_sel.UseVisualStyleBackColor = false;
            this.but_sel.Click += new System.EventHandler(this.but_sel_Click);
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.White;
            this.but_del.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.but_del.Location = new System.Drawing.Point(227, 647);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(128, 56);
            this.but_del.TabIndex = 13;
            this.but_del.Text = "退选";
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // dataSet_yixuan1
            // 
            this.dataSet_yixuan1.DataSetName = "DataSet_yixuan";
            this.dataSet_yixuan1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT * FROM SC";
            this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO [SC] ([sno], [cno], [sta]) VALUES (?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("sno", System.Data.OleDb.OleDbType.VarChar, 0, "sno"),
            new System.Data.OleDb.OleDbParameter("cno", System.Data.OleDb.OleDbType.VarChar, 0, "cno"),
            new System.Data.OleDb.OleDbParameter("sta", System.Data.OleDb.OleDbType.Integer, 0, "sta")});
            // 
            // oleDbDataAdapter_SC
            // 
            this.oleDbDataAdapter_SC.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter_SC.SelectCommand = this.oleDbSelectCommand4;
            this.oleDbDataAdapter_SC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SC", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("sno", "sno"),
                        new System.Data.Common.DataColumnMapping("cno", "cno"),
                        new System.Data.Common.DataColumnMapping("sta", "sta")})});
            // 
            // dataSet_SC1
            // 
            this.dataSet_SC1.DataSetName = "DataSet_SC";
            this.dataSet_SC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_yixuan
            // 
            this.dataGridView_yixuan.AutoGenerateColumns = false;
            this.dataGridView_yixuan.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_yixuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_yixuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.startweekDataGridViewTextBoxColumn,
            this.endweekDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn});
            this.dataGridView_yixuan.DataMember = "Cou";
            this.dataGridView_yixuan.DataSource = this.dataSet_yixuan1;
            this.dataGridView_yixuan.Location = new System.Drawing.Point(12, 171);
            this.dataGridView_yixuan.Name = "dataGridView_yixuan";
            this.dataGridView_yixuan.RowHeadersWidth = 51;
            this.dataGridView_yixuan.RowTemplate.Height = 27;
            this.dataGridView_yixuan.Size = new System.Drawing.Size(1053, 176);
            this.dataGridView_yixuan.TabIndex = 14;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "cno";
            this.cnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            this.cnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "tname";
            this.tnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            this.tnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "credit";
            this.creditDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            this.creditDataGridViewTextBoxColumn.Width = 125;
            // 
            // startweekDataGridViewTextBoxColumn
            // 
            this.startweekDataGridViewTextBoxColumn.DataPropertyName = "start_week";
            this.startweekDataGridViewTextBoxColumn.HeaderText = "start_week";
            this.startweekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startweekDataGridViewTextBoxColumn.Name = "startweekDataGridViewTextBoxColumn";
            this.startweekDataGridViewTextBoxColumn.Width = 125;
            // 
            // endweekDataGridViewTextBoxColumn
            // 
            this.endweekDataGridViewTextBoxColumn.DataPropertyName = "end_week";
            this.endweekDataGridViewTextBoxColumn.HeaderText = "end_week";
            this.endweekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endweekDataGridViewTextBoxColumn.Name = "endweekDataGridViewTextBoxColumn";
            this.endweekDataGridViewTextBoxColumn.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView_kexuan
            // 
            this.dataGridView_kexuan.AutoGenerateColumns = false;
            this.dataGridView_kexuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kexuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn1,
            this.cnameDataGridViewTextBoxColumn1,
            this.tnameDataGridViewTextBoxColumn1,
            this.creditDataGridViewTextBoxColumn1,
            this.startweekDataGridViewTextBoxColumn1,
            this.endweekDataGridViewTextBoxColumn1,
            this.starttimeDataGridViewTextBoxColumn1,
            this.endtimeDataGridViewTextBoxColumn1});
            this.dataGridView_kexuan.DataMember = "Cou";
            this.dataGridView_kexuan.DataSource = this.dataSet_kexuan1;
            this.dataGridView_kexuan.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_kexuan.Location = new System.Drawing.Point(12, 421);
            this.dataGridView_kexuan.Name = "dataGridView_kexuan";
            this.dataGridView_kexuan.RowHeadersWidth = 51;
            this.dataGridView_kexuan.RowTemplate.Height = 27;
            this.dataGridView_kexuan.Size = new System.Drawing.Size(1053, 206);
            this.dataGridView_kexuan.TabIndex = 15;
            // 
            // cnoDataGridViewTextBoxColumn1
            // 
            this.cnoDataGridViewTextBoxColumn1.DataPropertyName = "cno";
            this.cnoDataGridViewTextBoxColumn1.HeaderText = "cno";
            this.cnoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cnoDataGridViewTextBoxColumn1.Name = "cnoDataGridViewTextBoxColumn1";
            this.cnoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn1
            // 
            this.cnameDataGridViewTextBoxColumn1.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn1.HeaderText = "cname";
            this.cnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn1.Name = "cnameDataGridViewTextBoxColumn1";
            this.cnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tnameDataGridViewTextBoxColumn1
            // 
            this.tnameDataGridViewTextBoxColumn1.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn1.HeaderText = "tname";
            this.tnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tnameDataGridViewTextBoxColumn1.Name = "tnameDataGridViewTextBoxColumn1";
            this.tnameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // creditDataGridViewTextBoxColumn1
            // 
            this.creditDataGridViewTextBoxColumn1.DataPropertyName = "credit";
            this.creditDataGridViewTextBoxColumn1.HeaderText = "credit";
            this.creditDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.creditDataGridViewTextBoxColumn1.Name = "creditDataGridViewTextBoxColumn1";
            this.creditDataGridViewTextBoxColumn1.Width = 125;
            // 
            // startweekDataGridViewTextBoxColumn1
            // 
            this.startweekDataGridViewTextBoxColumn1.DataPropertyName = "start_week";
            this.startweekDataGridViewTextBoxColumn1.HeaderText = "start_week";
            this.startweekDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.startweekDataGridViewTextBoxColumn1.Name = "startweekDataGridViewTextBoxColumn1";
            this.startweekDataGridViewTextBoxColumn1.Width = 125;
            // 
            // endweekDataGridViewTextBoxColumn1
            // 
            this.endweekDataGridViewTextBoxColumn1.DataPropertyName = "end_week";
            this.endweekDataGridViewTextBoxColumn1.HeaderText = "end_week";
            this.endweekDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endweekDataGridViewTextBoxColumn1.Name = "endweekDataGridViewTextBoxColumn1";
            this.endweekDataGridViewTextBoxColumn1.Width = 125;
            // 
            // starttimeDataGridViewTextBoxColumn1
            // 
            this.starttimeDataGridViewTextBoxColumn1.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn1.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn1.Name = "starttimeDataGridViewTextBoxColumn1";
            this.starttimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // endtimeDataGridViewTextBoxColumn1
            // 
            this.endtimeDataGridViewTextBoxColumn1.DataPropertyName = "end_time";
            this.endtimeDataGridViewTextBoxColumn1.HeaderText = "end_time";
            this.endtimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.endtimeDataGridViewTextBoxColumn1.Name = "endtimeDataGridViewTextBoxColumn1";
            this.endtimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.White;
            this.submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submit.Location = new System.Drawing.Point(916, 647);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(128, 56);
            this.submit.TabIndex = 16;
            this.submit.Text = "提交";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "学号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(247, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(223, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "最少选择3门课程，学分高于8学分，最多可以选择5门课程，学分不超过12学分";
            // 
            // Form_SCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 769);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.dataGridView_kexuan);
            this.Controls.Add(this.dataGridView_yixuan);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_sel);
            this.Controls.Add(this.label_Ccre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Cnum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.label_sno);
            this.Controls.Add(this.kexuan);
            this.Controls.Add(this.yixuan);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SCT";
            this.Text = "选课系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SCT_FormClosing);
            this.Load += new System.EventHandler(this.Form_SCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_kexuan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_yixuan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yixuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kexuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label rules;
        private System.Windows.Forms.Label yixuan;
        private System.Windows.Forms.Label kexuan;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter_yixuan;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter_kexuan;
        private System.Windows.Forms.Label label_sno;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Cnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Ccre;
        private System.Windows.Forms.Button but_sel;
        private System.Windows.Forms.Button but_del;
        private DataSet_kexuan dataSet_kexuan1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand;
        private DataSet_yixuan dataSet_yixuan1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter_SC;
        private DataSet_SC dataSet_SC1;
        private System.Windows.Forms.DataGridView dataGridView_yixuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_kexuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startweekDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endweekDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}