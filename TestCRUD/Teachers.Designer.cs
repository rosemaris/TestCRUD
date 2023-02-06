namespace TestCRUD
{
    partial class Teachers
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
            this.TBgender = new System.Windows.Forms.ComboBox();
            this.TBaddress = new System.Windows.Forms.TextBox();
            this.LAddress = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.LGender = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBDoB = new System.Windows.Forms.DateTimePicker();
            this.TBage = new System.Windows.Forms.TextBox();
            this.TBlastName = new System.Windows.Forms.TextBox();
            this.TBfirstName = new System.Windows.Forms.TextBox();
            this.TBteachersID = new System.Windows.Forms.TextBox();
            this.LAge = new System.Windows.Forms.Label();
            this.LBOD = new System.Windows.Forms.Label();
            this.LLastName = new System.Windows.Forms.Label();
            this.LFirstName = new System.Windows.Forms.Label();
            this.LteachersID = new System.Windows.Forms.Label();
            this.LTeachersProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBgender
            // 
            this.TBgender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBgender.FormattingEnabled = true;
            this.TBgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.TBgender.Location = new System.Drawing.Point(619, 136);
            this.TBgender.Name = "TBgender";
            this.TBgender.Size = new System.Drawing.Size(138, 31);
            this.TBgender.TabIndex = 54;
            // 
            // TBaddress
            // 
            this.TBaddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBaddress.Location = new System.Drawing.Point(149, 180);
            this.TBaddress.Name = "TBaddress";
            this.TBaddress.Size = new System.Drawing.Size(638, 30);
            this.TBaddress.TabIndex = 53;
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LAddress.Location = new System.Drawing.Point(36, 185);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(89, 20);
            this.LAddress.TabIndex = 52;
            this.LAddress.Text = "Address :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(757, 320);
            this.dataGridView1.TabIndex = 51;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(645, 298);
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
            this.DeleteBtn.Location = new System.Drawing.Point(460, 298);
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
            this.UpdateBtn.Location = new System.Drawing.Point(242, 298);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 48;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // LGender
            // 
            this.LGender.AutoSize = true;
            this.LGender.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LGender.Location = new System.Drawing.Point(531, 140);
            this.LGender.Name = "LGender";
            this.LGender.Size = new System.Drawing.Size(82, 20);
            this.LGender.TabIndex = 47;
            this.LGender.Text = "Gender :";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(49, 298);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 46;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBDoB
            // 
            this.TBDoB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TBDoB.Location = new System.Drawing.Point(149, 137);
            this.TBDoB.Name = "TBDoB";
            this.TBDoB.Size = new System.Drawing.Size(125, 30);
            this.TBDoB.TabIndex = 45;
            // 
            // TBage
            // 
            this.TBage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBage.Location = new System.Drawing.Point(376, 135);
            this.TBage.Name = "TBage";
            this.TBage.Size = new System.Drawing.Size(125, 30);
            this.TBage.TabIndex = 44;
            // 
            // TBlastName
            // 
            this.TBlastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlastName.Location = new System.Drawing.Point(531, 88);
            this.TBlastName.Name = "TBlastName";
            this.TBlastName.Size = new System.Drawing.Size(256, 30);
            this.TBlastName.TabIndex = 43;
            // 
            // TBfirstName
            // 
            this.TBfirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBfirstName.Location = new System.Drawing.Point(149, 88);
            this.TBfirstName.Name = "TBfirstName";
            this.TBfirstName.Size = new System.Drawing.Size(256, 30);
            this.TBfirstName.TabIndex = 42;
            // 
            // TBteachersID
            // 
            this.TBteachersID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBteachersID.Location = new System.Drawing.Point(149, 55);
            this.TBteachersID.Name = "TBteachersID";
            this.TBteachersID.Size = new System.Drawing.Size(125, 30);
            this.TBteachersID.TabIndex = 41;
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LAge.Location = new System.Drawing.Point(319, 140);
            this.LAge.Name = "LAge";
            this.LAge.Size = new System.Drawing.Size(51, 20);
            this.LAge.TabIndex = 40;
            this.LAge.Text = "Age :";
            // 
            // LBOD
            // 
            this.LBOD.AutoSize = true;
            this.LBOD.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBOD.Location = new System.Drawing.Point(30, 140);
            this.LBOD.Name = "LBOD";
            this.LBOD.Size = new System.Drawing.Size(130, 20);
            this.LBOD.TabIndex = 39;
            this.LBOD.Text = "Date of Birth :";
            // 
            // LLastName
            // 
            this.LLastName.AutoSize = true;
            this.LLastName.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLastName.Location = new System.Drawing.Point(411, 95);
            this.LLastName.Name = "LLastName";
            this.LLastName.Size = new System.Drawing.Size(109, 20);
            this.LLastName.TabIndex = 38;
            this.LLastName.Text = "Last Name :";
            // 
            // LFirstName
            // 
            this.LFirstName.AutoSize = true;
            this.LFirstName.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LFirstName.Location = new System.Drawing.Point(30, 95);
            this.LFirstName.Name = "LFirstName";
            this.LFirstName.Size = new System.Drawing.Size(113, 20);
            this.LFirstName.TabIndex = 37;
            this.LFirstName.Text = "First Name :";
            // 
            // LteachersID
            // 
            this.LteachersID.AutoSize = true;
            this.LteachersID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LteachersID.Location = new System.Drawing.Point(30, 58);
            this.LteachersID.Name = "LteachersID";
            this.LteachersID.Size = new System.Drawing.Size(122, 20);
            this.LteachersID.TabIndex = 36;
            this.LteachersID.Text = "Teachers ID :";
            // 
            // LTeachersProfile
            // 
            this.LTeachersProfile.AutoSize = true;
            this.LTeachersProfile.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LTeachersProfile.Location = new System.Drawing.Point(274, 9);
            this.LTeachersProfile.Name = "LTeachersProfile";
            this.LTeachersProfile.Size = new System.Drawing.Size(295, 24);
            this.LTeachersProfile.TabIndex = 35;
            this.LTeachersProfile.Text = "Teachers Profile";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.TBgender);
            this.Controls.Add(this.TBaddress);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LGender);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBDoB);
            this.Controls.Add(this.TBage);
            this.Controls.Add(this.TBlastName);
            this.Controls.Add(this.TBfirstName);
            this.Controls.Add(this.TBteachersID);
            this.Controls.Add(this.LAge);
            this.Controls.Add(this.LBOD);
            this.Controls.Add(this.LLastName);
            this.Controls.Add(this.LFirstName);
            this.Controls.Add(this.LteachersID);
            this.Controls.Add(this.LTeachersProfile);
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TBgender;
        private System.Windows.Forms.TextBox TBaddress;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label LGender;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker TBDoB;
        private System.Windows.Forms.TextBox TBage;
        private System.Windows.Forms.TextBox TBlastName;
        private System.Windows.Forms.TextBox TBfirstName;
        private System.Windows.Forms.TextBox TBteachersID;
        private System.Windows.Forms.Label LAge;
        private System.Windows.Forms.Label LBOD;
        private System.Windows.Forms.Label LLastName;
        private System.Windows.Forms.Label LFirstName;
        private System.Windows.Forms.Label LteachersID;
        private System.Windows.Forms.Label LTeachersProfile;
    }
}