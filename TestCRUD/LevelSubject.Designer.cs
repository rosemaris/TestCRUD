namespace TestCRUD
{
    partial class LevelSubject
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
            this.LsubjectID = new System.Windows.Forms.Label();
            this.LlevelID = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBlevelsubjectID = new System.Windows.Forms.TextBox();
            this.LLevelsubjectID = new System.Windows.Forms.Label();
            this.LLevelSubject = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CBlevelID = new System.Windows.Forms.ComboBox();
            this.CBsubjectID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LsubjectID
            // 
            this.LsubjectID.AutoSize = true;
            this.LsubjectID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsubjectID.Location = new System.Drawing.Point(42, 161);
            this.LsubjectID.Name = "LsubjectID";
            this.LsubjectID.Size = new System.Drawing.Size(101, 20);
            this.LsubjectID.TabIndex = 100;
            this.LsubjectID.Text = "Subject ID:";
            // 
            // LlevelID
            // 
            this.LlevelID.AutoSize = true;
            this.LlevelID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelID.Location = new System.Drawing.Point(42, 119);
            this.LlevelID.Name = "LlevelID";
            this.LlevelID.Size = new System.Drawing.Size(84, 20);
            this.LlevelID.TabIndex = 99;
            this.LlevelID.Text = "Level ID:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(627, 214);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 97;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(446, 214);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 96;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(246, 214);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 95;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(67, 214);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 94;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // TBlevelsubjectID
            // 
            this.TBlevelsubjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlevelsubjectID.Location = new System.Drawing.Point(232, 62);
            this.TBlevelsubjectID.Name = "TBlevelsubjectID";
            this.TBlevelsubjectID.Size = new System.Drawing.Size(138, 30);
            this.TBlevelsubjectID.TabIndex = 93;
            // 
            // LLevelsubjectID
            // 
            this.LLevelsubjectID.AutoSize = true;
            this.LLevelsubjectID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLevelsubjectID.Location = new System.Drawing.Point(44, 72);
            this.LLevelsubjectID.Name = "LLevelsubjectID";
            this.LLevelsubjectID.Size = new System.Drawing.Size(157, 20);
            this.LLevelsubjectID.TabIndex = 92;
            this.LLevelsubjectID.Text = "Level Subject ID :";
            // 
            // LLevelSubject
            // 
            this.LLevelSubject.AutoSize = true;
            this.LLevelSubject.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLevelSubject.Location = new System.Drawing.Point(355, 9);
            this.LLevelSubject.Name = "LLevelSubject";
            this.LLevelSubject.Size = new System.Drawing.Size(233, 24);
            this.LLevelSubject.TabIndex = 91;
            this.LLevelSubject.Text = "LevelSubject";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 231);
            this.dataGridView1.TabIndex = 90;
            // 
            // CBlevelID
            // 
            this.CBlevelID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBlevelID.FormattingEnabled = true;
            this.CBlevelID.Location = new System.Drawing.Point(232, 114);
            this.CBlevelID.Name = "CBlevelID";
            this.CBlevelID.Size = new System.Drawing.Size(138, 31);
            this.CBlevelID.TabIndex = 102;
            // 
            // CBsubjectID
            // 
            this.CBsubjectID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBsubjectID.FormattingEnabled = true;
            this.CBsubjectID.Location = new System.Drawing.Point(232, 161);
            this.CBsubjectID.Name = "CBsubjectID";
            this.CBsubjectID.Size = new System.Drawing.Size(138, 31);
            this.CBsubjectID.TabIndex = 103;
            // 
            // LevelSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.CBsubjectID);
            this.Controls.Add(this.CBlevelID);
            this.Controls.Add(this.LsubjectID);
            this.Controls.Add(this.LlevelID);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBlevelsubjectID);
            this.Controls.Add(this.LLevelsubjectID);
            this.Controls.Add(this.LLevelSubject);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LevelSubject";
            this.Text = "LevelSubject";
            this.Load += new System.EventHandler(this.LevelSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LsubjectID;
        private System.Windows.Forms.Label LlevelID;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TBlevelsubjectID;
        private System.Windows.Forms.Label LLevelsubjectID;
        private System.Windows.Forms.Label LLevelSubject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CBlevelID;
        private System.Windows.Forms.ComboBox CBsubjectID;
    }
}