namespace SCSystem
{
    partial class Form_login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.Title = new System.Windows.Forms.Label();
            this.sno1 = new System.Windows.Forms.Label();
            this.input_sno = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.out_sname = new System.Windows.Forms.Label();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection_Stu = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.login = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.Location = new System.Drawing.Point(251, 41);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(345, 43);
            this.Title.TabIndex = 0;
            this.Title.Text = "XIABEE 选课系统";
            // 
            // sno1
            // 
            this.sno1.AutoSize = true;
            this.sno1.BackColor = System.Drawing.Color.Transparent;
            this.sno1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sno1.Location = new System.Drawing.Point(224, 172);
            this.sno1.Name = "sno1";
            this.sno1.Size = new System.Drawing.Size(68, 28);
            this.sno1.TabIndex = 1;
            this.sno1.Text = "学号";
            // 
            // input_sno
            // 
            this.input_sno.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_sno.Location = new System.Drawing.Point(361, 172);
            this.input_sno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_sno.Name = "input_sno";
            this.input_sno.Size = new System.Drawing.Size(189, 36);
            this.input_sno.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(224, 251);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 28);
            this.name.TabIndex = 3;
            this.name.Text = "姓名";
            // 
            // out_sname
            // 
            this.out_sname.AutoSize = true;
            this.out_sname.BackColor = System.Drawing.Color.Transparent;
            this.out_sname.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_sname.Location = new System.Drawing.Point(361, 251);
            this.out_sname.Name = "out_sname";
            this.out_sname.Size = new System.Drawing.Size(0, 28);
            this.out_sname.TabIndex = 4;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM Stu";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection_Stu;
            // 
            // oleDbConnection_Stu
            // 
            this.oleDbConnection_Stu.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=CS";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO [Stu] ([sno], [sname], [sex], [birth], [sdept]) VALUES (?, ?, ?, ?, ?" +
    ")";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection_Stu;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("sno", System.Data.OleDb.OleDbType.VarChar, 0, "sno"),
            new System.Data.OleDb.OleDbParameter("sname", System.Data.OleDb.OleDbType.VarChar, 0, "sname"),
            new System.Data.OleDb.OleDbParameter("sex", System.Data.OleDb.OleDbType.VarChar, 0, "sex"),
            new System.Data.OleDb.OleDbParameter("birth", System.Data.OleDb.OleDbType.DBDate, 0, "birth"),
            new System.Data.OleDb.OleDbParameter("sdept", System.Data.OleDb.OleDbType.VarChar, 0, "sdept")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE [Stu] SET [sno] = ?, [sname] = ?, [sex] = ?, [birth] = ?, [sdept] = ? WHER" +
    "E (([sno] = ?) AND ([sname] = ?) AND ([sex] = ?) AND ((? = 1 AND [birth] IS NULL" +
    ") OR ([birth] = ?)) AND ([sdept] = ?))";
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection_Stu;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("sno", System.Data.OleDb.OleDbType.VarChar, 0, "sno"),
            new System.Data.OleDb.OleDbParameter("sname", System.Data.OleDb.OleDbType.VarChar, 0, "sname"),
            new System.Data.OleDb.OleDbParameter("sex", System.Data.OleDb.OleDbType.VarChar, 0, "sex"),
            new System.Data.OleDb.OleDbParameter("birth", System.Data.OleDb.OleDbType.DBDate, 0, "birth"),
            new System.Data.OleDb.OleDbParameter("sdept", System.Data.OleDb.OleDbType.VarChar, 0, "sdept"),
            new System.Data.OleDb.OleDbParameter("Original_sno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sex", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_birth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "birth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sdept", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sdept", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM [Stu] WHERE (([sno] = ?) AND ([sname] = ?) AND ([sex] = ?) AND ((? = " +
    "1 AND [birth] IS NULL) OR ([birth] = ?)) AND ([sdept] = ?))";
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection_Stu;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_sno", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sno", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sname", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sex", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sex", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_birth", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "birth", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_birth", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "birth", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_sdept", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sdept", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Stu", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("sno", "sno"),
                        new System.Data.Common.DataColumnMapping("sname", "sname"),
                        new System.Data.Common.DataColumnMapping("sex", "sex"),
                        new System.Data.Common.DataColumnMapping("birth", "birth"),
                        new System.Data.Common.DataColumnMapping("sdept", "sdept")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("华文宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(308, 309);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(200, 50);
            this.login.TabIndex = 5;
            this.login.Text = "登陆";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.enter.Font = new System.Drawing.Font("华文仿宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(308, 309);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(200, 50);
            this.enter.TabIndex = 6;
            this.enter.Text = "进入选课";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.login);
            this.Controls.Add(this.out_sname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.input_sno);
            this.Controls.Add(this.sno1);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label sno1;
        private System.Windows.Forms.TextBox input_sno;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label out_sname;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection_Stu;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button enter;
    }
}

