namespace HotelManagementSystem
{
    partial class UserControlReservation
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
            this.tabControlReservations = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchReservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.dateTimePickerOUT1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIN1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxClientID1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabControlReservations.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservations
            // 
            this.tabControlReservations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservations.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservations.Controls.Add(this.tabPageSearch);
            this.tabControlReservations.Controls.Add(this.tabPageEdit);
            this.tabControlReservations.Location = new System.Drawing.Point(38, 39);
            this.tabControlReservations.Name = "tabControlReservations";
            this.tabControlReservations.SelectedIndex = 0;
            this.tabControlReservations.Size = new System.Drawing.Size(835, 480);
            this.tabControlReservations.TabIndex = 2;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOUT);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIN);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.label8);
            this.tabPageAddReservation.Controls.Add(this.label9);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomNumber);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomType);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 32);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(827, 444);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CalendarFont = new System.Drawing.Font("Bahnschrift SemiLight", 10.25F);
            this.dateTimePickerOUT.Location = new System.Drawing.Point(450, 259);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(266, 30);
            this.dateTimePickerOUT.TabIndex = 28;
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CalendarFont = new System.Drawing.Font("Bahnschrift SemiLight", 10.25F);
            this.dateTimePickerIN.Location = new System.Drawing.Point(73, 259);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(266, 30);
            this.dateTimePickerIN.TabIndex = 27;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(73, 179);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(266, 30);
            this.textBoxClientID.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Client ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label8.Location = new System.Drawing.Point(446, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Check-Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Check-In";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(450, 102);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(266, 31);
            this.comboBoxRoomNumber.TabIndex = 19;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(73, 102);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(266, 31);
            this.comboBoxRoomType.TabIndex = 16;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(313, 326);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 47);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add Reservation";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label2.Location = new System.Drawing.Point(446, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Room No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Type";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearch.Controls.Add(this.textBoxSearchReservation);
            this.tabPageSearch.Controls.Add(this.label4);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 32);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(827, 444);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search Reservation";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            this.tabPageSearch.Enter += new System.EventHandler(this.tabPageSearch_Enter);
            this.tabPageSearch.Leave += new System.EventHandler(this.tabPageSearch_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewReservation.Location = new System.Drawing.Point(38, 146);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.Size = new System.Drawing.Size(750, 272);
            this.dataGridViewReservation.TabIndex = 7;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            // 
            // column1
            // 
            this.column1.DataPropertyName = "ReservationID";
            this.column1.FillWeight = 74.62628F;
            this.column1.HeaderText = "ID";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ReservationRoomType";
            this.Column2.FillWeight = 128.3571F;
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReservationRoomNumber";
            this.Column3.FillWeight = 128.3571F;
            this.Column3.HeaderText = "Room No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ReservationClientID";
            this.Column4.FillWeight = 59.52225F;
            this.Column4.HeaderText = "Client ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ReservationIN";
            this.Column5.HeaderText = "In";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ReservationOUT";
            this.Column6.HeaderText = "Out";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // textBoxSearchReservation
            // 
            this.textBoxSearchReservation.Location = new System.Drawing.Point(166, 62);
            this.textBoxSearchReservation.Name = "textBoxSearchReservation";
            this.textBoxSearchReservation.Size = new System.Drawing.Size(266, 30);
            this.textBoxSearchReservation.TabIndex = 6;
            this.textBoxSearchReservation.TextChanged += new System.EventHandler(this.textBoxSearchReservation_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "ClientID";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.dateTimePickerOUT1);
            this.tabPageEdit.Controls.Add(this.dateTimePickerIN1);
            this.tabPageEdit.Controls.Add(this.textBoxClientID1);
            this.tabPageEdit.Controls.Add(this.label5);
            this.tabPageEdit.Controls.Add(this.label6);
            this.tabPageEdit.Controls.Add(this.label7);
            this.tabPageEdit.Controls.Add(this.comboBoxRoomNumber1);
            this.tabPageEdit.Controls.Add(this.comboBoxRoomType1);
            this.tabPageEdit.Controls.Add(this.label10);
            this.tabPageEdit.Controls.Add(this.label11);
            this.tabPageEdit.Controls.Add(this.buttonDelete);
            this.tabPageEdit.Controls.Add(this.buttonApply);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 32);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(827, 444);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Edit Reservation";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            this.tabPageEdit.Enter += new System.EventHandler(this.tabPageEdit_Enter);
            this.tabPageEdit.Leave += new System.EventHandler(this.tabPageEdit_Leave);
            // 
            // dateTimePickerOUT1
            // 
            this.dateTimePickerOUT1.CalendarFont = new System.Drawing.Font("Bahnschrift SemiLight", 10.25F);
            this.dateTimePickerOUT1.Location = new System.Drawing.Point(458, 256);
            this.dateTimePickerOUT1.Name = "dateTimePickerOUT1";
            this.dateTimePickerOUT1.Size = new System.Drawing.Size(266, 30);
            this.dateTimePickerOUT1.TabIndex = 39;
            // 
            // dateTimePickerIN1
            // 
            this.dateTimePickerIN1.CalendarFont = new System.Drawing.Font("Bahnschrift SemiLight", 10.25F);
            this.dateTimePickerIN1.Location = new System.Drawing.Point(81, 256);
            this.dateTimePickerIN1.Name = "dateTimePickerIN1";
            this.dateTimePickerIN1.Size = new System.Drawing.Size(266, 30);
            this.dateTimePickerIN1.TabIndex = 38;
            // 
            // textBoxClientID1
            // 
            this.textBoxClientID1.Location = new System.Drawing.Point(81, 176);
            this.textBoxClientID1.Name = "textBoxClientID1";
            this.textBoxClientID1.Size = new System.Drawing.Size(266, 30);
            this.textBoxClientID1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Client ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label6.Location = new System.Drawing.Point(454, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Check-Out";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 34;
            this.label7.Text = "Check-In";
            // 
            // comboBoxRoomNumber1
            // 
            this.comboBoxRoomNumber1.FormattingEnabled = true;
            this.comboBoxRoomNumber1.Location = new System.Drawing.Point(458, 99);
            this.comboBoxRoomNumber1.Name = "comboBoxRoomNumber1";
            this.comboBoxRoomNumber1.Size = new System.Drawing.Size(266, 31);
            this.comboBoxRoomNumber1.TabIndex = 33;
            // 
            // comboBoxRoomType1
            // 
            this.comboBoxRoomType1.FormattingEnabled = true;
            this.comboBoxRoomType1.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxRoomType1.Location = new System.Drawing.Point(81, 99);
            this.comboBoxRoomType1.Name = "comboBoxRoomType1";
            this.comboBoxRoomType1.Size = new System.Drawing.Size(266, 31);
            this.comboBoxRoomType1.TabIndex = 32;
            this.comboBoxRoomType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.label10.Location = new System.Drawing.Point(454, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Room No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(77, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Room Type";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(417, 333);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(186, 47);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Cancel Reservation";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(214)))), ((int)(((byte)(95)))));
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F);
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(244, 333);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(147, 47);
            this.buttonApply.TabIndex = 19;
            this.buttonApply.Text = "Apply Changes";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservations);
            this.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(910, 558);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabControlReservations.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservations;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox textBoxSearchReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN1;
        private System.Windows.Forms.TextBox textBoxClientID1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber1;
        private System.Windows.Forms.ComboBox comboBoxRoomType1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
