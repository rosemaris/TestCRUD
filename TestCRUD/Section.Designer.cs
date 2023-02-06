namespace TestCRUD
{
    partial class Section
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
            this.TBsectionDesc = new System.Windows.Forms.TextBox();
            this.LsectionDesc = new System.Windows.Forms.Label();
            this.LsectionCode = new System.Windows.Forms.Label();
            this.TBsectionCode = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBsectionID = new System.Windows.Forms.TextBox();
            this.LsectionID = new System.Windows.Forms.Label();
            this.LSection = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBsectionDesc
            // 
            this.TBsectionDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsectionDesc.Location = new System.Drawing.Point(238, 166);
            this.TBsectionDesc.Name = "TBsectionDesc";
            this.TBsectionDesc.Size = new System.Drawing.Size(125, 30);
            this.TBsectionDesc.TabIndex = 89;
            // 
            // LsectionDesc
            // 
            this.LsectionDesc.AutoSize = true;
            this.LsectionDesc.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsectionDesc.Location = new System.Drawing.Point(48, 171);
            this.LsectionDesc.Name = "LsectionDesc";
            this.LsectionDesc.Size = new System.Drawing.Size(188, 20);
            this.LsectionDesc.TabIndex = 88;
            this.LsectionDesc.Text = "Section Description :";
            // 
            // LsectionCode
            // 
            this.LsectionCode.AutoSize = true;
            this.LsectionCode.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsectionCode.Location = new System.Drawing.Point(48, 129);
            this.LsectionCode.Name = "LsectionCode";
            this.LsectionCode.Size = new System.Drawing.Size(131, 20);
            this.LsectionCode.TabIndex = 87;
            this.LsectionCode.Text = "Section Code :";
            // 
            // TBsectionCode
            // 
            this.TBsectionCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsectionCode.Location = new System.Drawing.Point(238, 119);
            this.TBsectionCode.Name = "TBsectionCode";
            this.TBsectionCode.Size = new System.Drawing.Size(125, 30);
            this.TBsectionCode.TabIndex = 86;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(633, 224);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 85;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(452, 224);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 84;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(252, 224);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 83;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(73, 224);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 82;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBsectionID
            // 
            this.TBsectionID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsectionID.Location = new System.Drawing.Point(238, 72);
            this.TBsectionID.Name = "TBsectionID";
            this.TBsectionID.Size = new System.Drawing.Size(125, 30);
            this.TBsectionID.TabIndex = 81;
            // 
            // LsectionID
            // 
            this.LsectionID.AutoSize = true;
            this.LsectionID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsectionID.Location = new System.Drawing.Point(50, 82);
            this.LsectionID.Name = "LsectionID";
            this.LsectionID.Size = new System.Drawing.Size(106, 20);
            this.LsectionID.TabIndex = 80;
            this.LsectionID.Text = "Section ID :";
            // 
            // LSection
            // 
            this.LSection.AutoSize = true;
            this.LSection.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LSection.Location = new System.Drawing.Point(361, 19);
            this.LSection.Name = "LSection";
            this.LSection.Size = new System.Drawing.Size(138, 24);
            this.LSection.TabIndex = 79;
            this.LSection.Text = "Section";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 231);
            this.dataGridView1.TabIndex = 78;
            // 
            // Section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.TBsectionDesc);
            this.Controls.Add(this.LsectionDesc);
            this.Controls.Add(this.LsectionCode);
            this.Controls.Add(this.TBsectionCode);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBsectionID);
            this.Controls.Add(this.LsectionID);
            this.Controls.Add(this.LSection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Section";
            this.Text = "Section";
            this.Load += new System.EventHandler(this.Section_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBsectionDesc;
        private System.Windows.Forms.Label LsectionDesc;
        private System.Windows.Forms.Label LsectionCode;
        private System.Windows.Forms.TextBox TBsectionCode;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TBsectionID;
        private System.Windows.Forms.Label LsectionID;
        private System.Windows.Forms.Label LSection;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}