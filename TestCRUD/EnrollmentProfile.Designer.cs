namespace TestCRUD
{
    partial class EnrollmentProfile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBenrolDate = new System.Windows.Forms.DateTimePicker();
            this.TBenrolID = new System.Windows.Forms.TextBox();
            this.LschoolYear = new System.Windows.Forms.Label();
            this.LEnrolDate = new System.Windows.Forms.Label();
            this.LEnrolID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LpupilsID = new System.Windows.Forms.Label();
            this.LlevelSecTeachID = new System.Windows.Forms.Label();
            this.LlevelSubTeachID = new System.Windows.Forms.Label();
            this.CBlevelSecTeachID = new System.Windows.Forms.ComboBox();
            this.CBpupilsID = new System.Windows.Forms.ComboBox();
            this.TBschoolYear = new System.Windows.Forms.ComboBox();
            this.CBLSTid = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(757, 289);
            this.dataGridView1.TabIndex = 51;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(662, 407);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 50;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(477, 407);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 49;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(255, 407);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 48;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(76, 407);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 46;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBenrolDate
            // 
            this.TBenrolDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBenrolDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TBenrolDate.Location = new System.Drawing.Point(189, 101);
            this.TBenrolDate.Name = "TBenrolDate";
            this.TBenrolDate.Size = new System.Drawing.Size(125, 30);
            this.TBenrolDate.TabIndex = 45;
            // 
            // TBenrolID
            // 
            this.TBenrolID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBenrolID.Location = new System.Drawing.Point(189, 62);
            this.TBenrolID.Name = "TBenrolID";
            this.TBenrolID.Size = new System.Drawing.Size(125, 30);
            this.TBenrolID.TabIndex = 41;
            // 
            // LschoolYear
            // 
            this.LschoolYear.AutoSize = true;
            this.LschoolYear.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LschoolYear.Location = new System.Drawing.Point(409, 112);
            this.LschoolYear.Name = "LschoolYear";
            this.LschoolYear.Size = new System.Drawing.Size(121, 20);
            this.LschoolYear.TabIndex = 40;
            this.LschoolYear.Text = "School Year :";
            // 
            // LEnrolDate
            // 
            this.LEnrolDate.AutoSize = true;
            this.LEnrolDate.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LEnrolDate.Location = new System.Drawing.Point(29, 104);
            this.LEnrolDate.Name = "LEnrolDate";
            this.LEnrolDate.Size = new System.Drawing.Size(154, 20);
            this.LEnrolDate.TabIndex = 37;
            this.LEnrolDate.Text = "Enrolment Date :";
            // 
            // LEnrolID
            // 
            this.LEnrolID.AutoSize = true;
            this.LEnrolID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LEnrolID.Location = new System.Drawing.Point(29, 67);
            this.LEnrolID.Name = "LEnrolID";
            this.LEnrolID.Size = new System.Drawing.Size(133, 20);
            this.LEnrolID.TabIndex = 36;
            this.LEnrolID.Text = "Enrolment ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enrolment Profile";
            // 
            // LpupilsID
            // 
            this.LpupilsID.AutoSize = true;
            this.LpupilsID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LpupilsID.Location = new System.Drawing.Point(29, 156);
            this.LpupilsID.Name = "LpupilsID";
            this.LpupilsID.Size = new System.Drawing.Size(96, 20);
            this.LpupilsID.TabIndex = 55;
            this.LpupilsID.Text = "Pupils ID :";
            // 
            // LlevelSecTeachID
            // 
            this.LlevelSecTeachID.AutoSize = true;
            this.LlevelSecTeachID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelSecTeachID.Location = new System.Drawing.Point(29, 206);
            this.LlevelSecTeachID.Name = "LlevelSecTeachID";
            this.LlevelSecTeachID.Size = new System.Drawing.Size(222, 20);
            this.LlevelSecTeachID.TabIndex = 58;
            this.LlevelSecTeachID.Text = "LevelSectionTeacher ID :";
            // 
            // LlevelSubTeachID
            // 
            this.LlevelSubTeachID.AutoSize = true;
            this.LlevelSubTeachID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelSubTeachID.Location = new System.Drawing.Point(29, 248);
            this.LlevelSubTeachID.Name = "LlevelSubTeachID";
            this.LlevelSubTeachID.Size = new System.Drawing.Size(222, 20);
            this.LlevelSubTeachID.TabIndex = 59;
            this.LlevelSubTeachID.Text = "LevelSubjectTeacher ID :";
            // 
            // CBlevelSecTeachID
            // 
            this.CBlevelSecTeachID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBlevelSecTeachID.FormattingEnabled = true;
            this.CBlevelSecTeachID.Location = new System.Drawing.Point(273, 201);
            this.CBlevelSecTeachID.Name = "CBlevelSecTeachID";
            this.CBlevelSecTeachID.Size = new System.Drawing.Size(138, 31);
            this.CBlevelSecTeachID.TabIndex = 61;
            // 
            // CBpupilsID
            // 
            this.CBpupilsID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBpupilsID.FormattingEnabled = true;
            this.CBpupilsID.Location = new System.Drawing.Point(189, 156);
            this.CBpupilsID.Name = "CBpupilsID";
            this.CBpupilsID.Size = new System.Drawing.Size(138, 31);
            this.CBpupilsID.TabIndex = 63;
            // 
            // TBschoolYear
            // 
            this.TBschoolYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBschoolYear.FormattingEnabled = true;
            this.TBschoolYear.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.TBschoolYear.Location = new System.Drawing.Point(554, 104);
            this.TBschoolYear.Name = "TBschoolYear";
            this.TBschoolYear.Size = new System.Drawing.Size(138, 31);
            this.TBschoolYear.TabIndex = 64;
            // 
            // CBLSTid
            // 
            this.CBLSTid.FormattingEnabled = true;
            this.CBLSTid.Location = new System.Drawing.Point(273, 248);
            this.CBLSTid.Name = "CBLSTid";
            this.CBLSTid.Size = new System.Drawing.Size(150, 48);
            this.CBLSTid.TabIndex = 65;
            // 
            // EnrollmentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 743);
            this.Controls.Add(this.CBLSTid);
            this.Controls.Add(this.TBschoolYear);
            this.Controls.Add(this.CBpupilsID);
            this.Controls.Add(this.CBlevelSecTeachID);
            this.Controls.Add(this.LlevelSubTeachID);
            this.Controls.Add(this.LlevelSecTeachID);
            this.Controls.Add(this.LpupilsID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBenrolDate);
            this.Controls.Add(this.TBenrolID);
            this.Controls.Add(this.LschoolYear);
            this.Controls.Add(this.LEnrolDate);
            this.Controls.Add(this.LEnrolID);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentProfile";
            this.Text = "EnrollmentProfile";
            this.Load += new System.EventHandler(this.EnrollmentProfile_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker TBenrolDate;
        private System.Windows.Forms.TextBox TBenrolID;
        private System.Windows.Forms.Label LschoolYear;
        private System.Windows.Forms.Label LEnrolDate;
        private System.Windows.Forms.Label LEnrolID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LpupilsID;
        private System.Windows.Forms.Label LlevelSecTeachID;
        private System.Windows.Forms.Label LlevelSubTeachID;
        private System.Windows.Forms.ComboBox CBlevelSecTeachID;
        private System.Windows.Forms.ComboBox CBpupilsID;
        private System.Windows.Forms.ComboBox TBschoolYear;
        private System.Windows.Forms.CheckedListBox CBLSTid;
    }
}