namespace TestCRUD
{
    partial class Subject
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
            this.TBsubjectDesc = new System.Windows.Forms.TextBox();
            this.LsubjectDesc = new System.Windows.Forms.Label();
            this.LsubjectCode = new System.Windows.Forms.Label();
            this.TBsubjectCode = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBsubjectID = new System.Windows.Forms.TextBox();
            this.LsubjectID = new System.Windows.Forms.Label();
            this.LSubject = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TBsubjectDesc
            // 
            this.TBsubjectDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsubjectDesc.Location = new System.Drawing.Point(238, 169);
            this.TBsubjectDesc.Name = "TBsubjectDesc";
            this.TBsubjectDesc.Size = new System.Drawing.Size(125, 30);
            this.TBsubjectDesc.TabIndex = 89;
            // 
            // LsubjectDesc
            // 
            this.LsubjectDesc.AutoSize = true;
            this.LsubjectDesc.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsubjectDesc.Location = new System.Drawing.Point(48, 174);
            this.LsubjectDesc.Name = "LsubjectDesc";
            this.LsubjectDesc.Size = new System.Drawing.Size(188, 20);
            this.LsubjectDesc.TabIndex = 88;
            this.LsubjectDesc.Text = "Subject Description :";
            // 
            // LsubjectCode
            // 
            this.LsubjectCode.AutoSize = true;
            this.LsubjectCode.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsubjectCode.Location = new System.Drawing.Point(48, 132);
            this.LsubjectCode.Name = "LsubjectCode";
            this.LsubjectCode.Size = new System.Drawing.Size(131, 20);
            this.LsubjectCode.TabIndex = 87;
            this.LsubjectCode.Text = "Subject Code :";
            // 
            // TBsubjectCode
            // 
            this.TBsubjectCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsubjectCode.Location = new System.Drawing.Point(238, 122);
            this.TBsubjectCode.Name = "TBsubjectCode";
            this.TBsubjectCode.Size = new System.Drawing.Size(125, 30);
            this.TBsubjectCode.TabIndex = 86;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(633, 227);
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
            this.DeleteBtn.Location = new System.Drawing.Point(452, 227);
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
            this.UpdateBtn.Location = new System.Drawing.Point(252, 227);
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
            this.AddBtn.Location = new System.Drawing.Point(73, 227);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 82;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBsubjectID
            // 
            this.TBsubjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBsubjectID.Location = new System.Drawing.Point(238, 75);
            this.TBsubjectID.Name = "TBsubjectID";
            this.TBsubjectID.Size = new System.Drawing.Size(125, 30);
            this.TBsubjectID.TabIndex = 81;
            // 
            // LsubjectID
            // 
            this.LsubjectID.AutoSize = true;
            this.LsubjectID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsubjectID.Location = new System.Drawing.Point(50, 85);
            this.LsubjectID.Name = "LsubjectID";
            this.LsubjectID.Size = new System.Drawing.Size(106, 20);
            this.LsubjectID.TabIndex = 80;
            this.LsubjectID.Text = "Subject ID :";
            // 
            // LSubject
            // 
            this.LSubject.AutoSize = true;
            this.LSubject.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LSubject.Location = new System.Drawing.Point(361, 22);
            this.LSubject.Name = "LSubject";
            this.LSubject.Size = new System.Drawing.Size(137, 24);
            this.LSubject.TabIndex = 79;
            this.LSubject.Text = "Subject";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 231);
            this.dataGridView1.TabIndex = 78;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.TBsubjectDesc);
            this.Controls.Add(this.LsubjectDesc);
            this.Controls.Add(this.LsubjectCode);
            this.Controls.Add(this.TBsubjectCode);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBsubjectID);
            this.Controls.Add(this.LsubjectID);
            this.Controls.Add(this.LSubject);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBsubjectDesc;
        private System.Windows.Forms.Label LsubjectDesc;
        private System.Windows.Forms.Label LsubjectCode;
        private System.Windows.Forms.TextBox TBsubjectCode;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TBsubjectID;
        private System.Windows.Forms.Label LsubjectID;
        private System.Windows.Forms.Label LSubject;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}