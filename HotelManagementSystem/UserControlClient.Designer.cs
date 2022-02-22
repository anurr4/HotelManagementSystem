namespace HotelManagementSystem
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxLName1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPhone1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFName1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearch);
            this.tabControlClient.Controls.Add(this.tabPageEdit);
            this.tabControlClient.Location = new System.Drawing.Point(25, 21);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(835, 480);
            this.tabControlClient.TabIndex = 0;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.textBoxAddress);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.textBoxLName);
            this.tabPageAddClient.Controls.Add(this.label8);
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxPhone);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.textBoxFName);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 32);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(827, 444);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(74, 225);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(643, 91);
            this.textBoxAddress.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label3.Location = new System.Drawing.Point(70, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(451, 82);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(266, 30);
            this.textBoxLName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Last Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(340, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 47);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Client";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(74, 153);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(266, 30);
            this.textBoxPhone.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone No.";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(74, 82);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(266, 30);
            this.textBoxFName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dataGridViewClient);
            this.tabPageSearch.Controls.Add(this.textBoxSearchPhone);
            this.tabPageSearch.Controls.Add(this.label4);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 32);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(827, 444);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search Client";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.Enter += new System.EventHandler(this.tabPageSearch_Enter);
            this.tabPageSearch.Leave += new System.EventHandler(this.tabPageSearch_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClient.Location = new System.Drawing.Point(38, 146);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(750, 272);
            this.dataGridViewClient.TabIndex = 7;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // column1
            // 
            this.column1.DataPropertyName = "ClientID";
            this.column1.FillWeight = 63.45178F;
            this.column1.HeaderText = "ClientID";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ClientN";
            this.Column2.FillWeight = 109.137F;
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ClientLN";
            this.Column3.FillWeight = 109.137F;
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ClientPhone";
            this.Column4.FillWeight = 109.137F;
            this.Column4.HeaderText = "Phone No.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ClientAddress";
            this.Column5.FillWeight = 109.137F;
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // textBoxSearchPhone
            // 
            this.textBoxSearchPhone.Location = new System.Drawing.Point(166, 62);
            this.textBoxSearchPhone.Name = "textBoxSearchPhone";
            this.textBoxSearchPhone.Size = new System.Drawing.Size(266, 30);
            this.textBoxSearchPhone.TabIndex = 6;
            this.textBoxSearchPhone.TextChanged += new System.EventHandler(this.textBoxSearchPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No.";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.textBoxAddress1);
            this.tabPageEdit.Controls.Add(this.textBoxLName1);
            this.tabPageEdit.Controls.Add(this.label7);
            this.tabPageEdit.Controls.Add(this.buttonDelete);
            this.tabPageEdit.Controls.Add(this.label6);
            this.tabPageEdit.Controls.Add(this.buttonApply);
            this.tabPageEdit.Controls.Add(this.textBoxPhone1);
            this.tabPageEdit.Controls.Add(this.label5);
            this.tabPageEdit.Controls.Add(this.textBoxFName1);
            this.tabPageEdit.Controls.Add(this.label9);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 32);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(827, 444);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Edit Client";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            this.tabPageEdit.Leave += new System.EventHandler(this.tabPageEdit_Leave);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(107, 216);
            this.textBoxAddress1.Multiline = true;
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(643, 91);
            this.textBoxAddress1.TabIndex = 25;
            // 
            // textBoxLName1
            // 
            this.textBoxLName1.Location = new System.Drawing.Point(428, 67);
            this.textBoxLName1.Name = "textBoxLName1";
            this.textBoxLName1.Size = new System.Drawing.Size(266, 30);
            this.textBoxLName1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Last Name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(428, 345);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 47);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label6.Location = new System.Drawing.Point(103, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(250, 345);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(147, 47);
            this.buttonApply.TabIndex = 19;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPhone1
            // 
            this.textBoxPhone1.Location = new System.Drawing.Point(107, 148);
            this.textBoxPhone1.Name = "textBoxPhone1";
            this.textBoxPhone1.Size = new System.Drawing.Size(266, 30);
            this.textBoxPhone1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label5.Location = new System.Drawing.Point(103, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phone No.";
            // 
            // textBoxFName1
            // 
            this.textBoxFName1.Location = new System.Drawing.Point(107, 67);
            this.textBoxFName1.Name = "textBoxFName1";
            this.textBoxFName1.Size = new System.Drawing.Size(266, 30);
            this.textBoxFName1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "First Name";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(910, 558);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxSearchPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxLName1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPhone1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFName1;
        private System.Windows.Forms.Label label9;
    }
}
