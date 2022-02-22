namespace HotelManagementSystem
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRoles = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Location = new System.Drawing.Point(37, 33);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(835, 480);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.textBoxEmail);
            this.tabPageAddUser.Controls.Add(this.label8);
            this.tabPageAddUser.Controls.Add(this.buttonAdd);
            this.tabPageAddUser.Controls.Add(this.textBoxPassword);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.textBoxUsername);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 32);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(827, 444);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(275, 164);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(266, 30);
            this.textBoxEmail.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(348, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 47);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add User";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(275, 241);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(266, 30);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label2.Location = new System.Drawing.Point(271, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(275, 86);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(266, 30);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridView1);
            this.tabPageSearchUser.Controls.Add(this.textBox3);
            this.tabPageSearchUser.Controls.Add(this.label3);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 32);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(827, 444);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search User";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            this.tabPageSearchUser.Enter += new System.EventHandler(this.tabPageSearchUser_Enter);
            this.tabPageSearchUser.Leave += new System.EventHandler(this.tabPageSearchUser_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(41, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 272);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // column1
            // 
            this.column1.DataPropertyName = "UserID";
            this.column1.HeaderText = "UserID";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "pass";
            this.Column4.HeaderText = "Password";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "UserRole";
            this.Column5.HeaderText = "User Role";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxEmail1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBoxRoles);
            this.tabPage1.Controls.Add(this.buttonApply);
            this.tabPage1.Controls.Add(this.textBoxPassword1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxUsername1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 444);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Edit User";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Location = new System.Drawing.Point(104, 147);
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(266, 30);
            this.textBoxEmail1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(493, 251);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 47);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete User";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label6.Location = new System.Drawing.Point(102, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Role";
            // 
            // comboBoxRoles
            // 
            this.comboBoxRoles.FormattingEnabled = true;
            this.comboBoxRoles.Items.AddRange(new object[] {
            "User",
            "Administrator"});
            this.comboBoxRoles.Location = new System.Drawing.Point(104, 336);
            this.comboBoxRoles.Name = "comboBoxRoles";
            this.comboBoxRoles.Size = new System.Drawing.Size(266, 31);
            this.comboBoxRoles.TabIndex = 10;
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(493, 168);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(147, 47);
            this.buttonApply.TabIndex = 9;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(104, 241);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(266, 30);
            this.textBoxPassword1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label4.Location = new System.Drawing.Point(100, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // textBoxUsername1
            // 
            this.textBoxUsername1.Location = new System.Drawing.Point(104, 63);
            this.textBoxUsername1.Name = "textBoxUsername1";
            this.textBoxUsername1.Size = new System.Drawing.Size(266, 30);
            this.textBoxUsername1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(910, 558);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
    }
}
