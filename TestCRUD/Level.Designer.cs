namespace TestCRUD
{
    partial class Level
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
            this.TBlevelDesc = new System.Windows.Forms.TextBox();
            this.LlevelDesc = new System.Windows.Forms.Label();
            this.LlevelCode = new System.Windows.Forms.Label();
            this.TBlevelCode = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBlevelID = new System.Windows.Forms.TextBox();
            this.LlevelID = new System.Windows.Forms.Label();
            this.Llevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 231);
            this.dataGridView1.TabIndex = 23;
            // 
            // TBlevelDesc
            // 
            this.TBlevelDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlevelDesc.Location = new System.Drawing.Point(233, 156);
            this.TBlevelDesc.Name = "TBlevelDesc";
            this.TBlevelDesc.Size = new System.Drawing.Size(125, 30);
            this.TBlevelDesc.TabIndex = 77;
            // 
            // LlevelDesc
            // 
            this.LlevelDesc.AutoSize = true;
            this.LlevelDesc.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelDesc.Location = new System.Drawing.Point(43, 161);
            this.LlevelDesc.Name = "LlevelDesc";
            this.LlevelDesc.Size = new System.Drawing.Size(171, 20);
            this.LlevelDesc.TabIndex = 76;
            this.LlevelDesc.Text = "Level Description :";
            // 
            // LlevelCode
            // 
            this.LlevelCode.AutoSize = true;
            this.LlevelCode.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelCode.Location = new System.Drawing.Point(43, 119);
            this.LlevelCode.Name = "LlevelCode";
            this.LlevelCode.Size = new System.Drawing.Size(114, 20);
            this.LlevelCode.TabIndex = 75;
            this.LlevelCode.Text = "Level Code :";
            // 
            // TBlevelCode
            // 
            this.TBlevelCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlevelCode.Location = new System.Drawing.Point(233, 109);
            this.TBlevelCode.Name = "TBlevelCode";
            this.TBlevelCode.Size = new System.Drawing.Size(125, 30);
            this.TBlevelCode.TabIndex = 74;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(628, 214);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 71;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(447, 214);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 70;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(247, 214);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 69;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(68, 214);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 68;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBlevelID
            // 
            this.TBlevelID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlevelID.Location = new System.Drawing.Point(233, 62);
            this.TBlevelID.Name = "TBlevelID";
            this.TBlevelID.Size = new System.Drawing.Size(125, 30);
            this.TBlevelID.TabIndex = 65;
            // 
            // LlevelID
            // 
            this.LlevelID.AutoSize = true;
            this.LlevelID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelID.Location = new System.Drawing.Point(45, 72);
            this.LlevelID.Name = "LlevelID";
            this.LlevelID.Size = new System.Drawing.Size(89, 20);
            this.LlevelID.TabIndex = 62;
            this.LlevelID.Text = "Level ID :";
            // 
            // Llevel
            // 
            this.Llevel.AutoSize = true;
            this.Llevel.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Llevel.Location = new System.Drawing.Point(356, 9);
            this.Llevel.Name = "Llevel";
            this.Llevel.Size = new System.Drawing.Size(106, 24);
            this.Llevel.TabIndex = 61;
            this.Llevel.Text = "Level";
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.TBlevelDesc);
            this.Controls.Add(this.LlevelDesc);
            this.Controls.Add(this.LlevelCode);
            this.Controls.Add(this.TBlevelCode);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBlevelID);
            this.Controls.Add(this.LlevelID);
            this.Controls.Add(this.Llevel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Level";
            this.Text = "Level";
            this.Load += new System.EventHandler(this.Level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBlevelDesc;
        private System.Windows.Forms.Label LlevelDesc;
        private System.Windows.Forms.Label LlevelCode;
        private System.Windows.Forms.TextBox TBlevelCode;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TBlevelID;
        private System.Windows.Forms.Label LlevelID;
        private System.Windows.Forms.Label Llevel;
    }
}