namespace TestCRUD
{
    partial class LevelSection
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
            this.CBsectionID = new System.Windows.Forms.ComboBox();
            this.CBlevelID = new System.Windows.Forms.ComboBox();
            this.LsectionID = new System.Windows.Forms.Label();
            this.LlevelID = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TBlevelsectionID = new System.Windows.Forms.TextBox();
            this.LLevelsectionID = new System.Windows.Forms.Label();
            this.LLevelSection = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBsectionID
            // 
            this.CBsectionID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBsectionID.FormattingEnabled = true;
            this.CBsectionID.Location = new System.Drawing.Point(220, 166);
            this.CBsectionID.Name = "CBsectionID";
            this.CBsectionID.Size = new System.Drawing.Size(138, 31);
            this.CBsectionID.TabIndex = 115;
            // 
            // CBlevelID
            // 
            this.CBlevelID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBlevelID.FormattingEnabled = true;
            this.CBlevelID.Location = new System.Drawing.Point(220, 119);
            this.CBlevelID.Name = "CBlevelID";
            this.CBlevelID.Size = new System.Drawing.Size(138, 31);
            this.CBlevelID.TabIndex = 114;
            // 
            // LsectionID
            // 
            this.LsectionID.AutoSize = true;
            this.LsectionID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LsectionID.Location = new System.Drawing.Point(30, 166);
            this.LsectionID.Name = "LsectionID";
            this.LsectionID.Size = new System.Drawing.Size(101, 20);
            this.LsectionID.TabIndex = 113;
            this.LsectionID.Text = "Section ID:";
            // 
            // LlevelID
            // 
            this.LlevelID.AutoSize = true;
            this.LlevelID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LlevelID.Location = new System.Drawing.Point(30, 124);
            this.LlevelID.Name = "LlevelID";
            this.LlevelID.Size = new System.Drawing.Size(84, 20);
            this.LlevelID.TabIndex = 112;
            this.LlevelID.Text = "Level ID:";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Blue;
            this.SearchBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBtn.Location = new System.Drawing.Point(615, 219);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(94, 29);
            this.SearchBtn.TabIndex = 111;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(434, 219);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 110;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Yellow;
            this.UpdateBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(234, 219);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateBtn.TabIndex = 109;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.Location = new System.Drawing.Point(55, 219);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 29);
            this.AddBtn.TabIndex = 108;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TBlevelsectionID
            // 
            this.TBlevelsectionID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBlevelsectionID.Location = new System.Drawing.Point(220, 67);
            this.TBlevelsectionID.Name = "TBlevelsectionID";
            this.TBlevelsectionID.Size = new System.Drawing.Size(138, 30);
            this.TBlevelsectionID.TabIndex = 107;
            // 
            // LLevelsectionID
            // 
            this.LLevelsectionID.AutoSize = true;
            this.LLevelsectionID.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLevelsectionID.Location = new System.Drawing.Point(32, 77);
            this.LLevelsectionID.Name = "LLevelsectionID";
            this.LLevelsectionID.Size = new System.Drawing.Size(157, 20);
            this.LLevelsectionID.TabIndex = 106;
            this.LLevelsectionID.Text = "Level Section ID :";
            // 
            // LLevelSection
            // 
            this.LLevelSection.AutoSize = true;
            this.LLevelSection.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLevelSection.Location = new System.Drawing.Point(343, 14);
            this.LLevelSection.Name = "LLevelSection";
            this.LLevelSection.Size = new System.Drawing.Size(234, 24);
            this.LLevelSection.TabIndex = 105;
            this.LLevelSection.Text = "LevelSection";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(706, 231);
            this.dataGridView1.TabIndex = 104;
            // 
            // LevelSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.CBsectionID);
            this.Controls.Add(this.CBlevelID);
            this.Controls.Add(this.LsectionID);
            this.Controls.Add(this.LlevelID);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TBlevelsectionID);
            this.Controls.Add(this.LLevelsectionID);
            this.Controls.Add(this.LLevelSection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LevelSection";
            this.Text = "LevelSection";
            this.Load += new System.EventHandler(this.LevelSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBsectionID;
        private System.Windows.Forms.ComboBox CBlevelID;
        private System.Windows.Forms.Label LsectionID;
        private System.Windows.Forms.Label LlevelID;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TBlevelsectionID;
        private System.Windows.Forms.Label LLevelsectionID;
        private System.Windows.Forms.Label LLevelSection;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}