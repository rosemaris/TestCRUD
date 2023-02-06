namespace TestCRUD
{
    partial class Practise
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
            this.button1 = new System.Windows.Forms.Button();
            this.PNbox = new System.Windows.Forms.CheckedListBox();
            this.PractiseNames = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PNbox
            // 
            this.PNbox.FormattingEnabled = true;
            this.PNbox.Items.AddRange(new object[] {
            "Maris",
            "Nonon",
            "Richard",
            "Clark",
            "Quen"});
            this.PNbox.Location = new System.Drawing.Point(164, 74);
            this.PNbox.Name = "PNbox";
            this.PNbox.Size = new System.Drawing.Size(330, 136);
            this.PNbox.TabIndex = 1;
            // 
            // PractiseNames
            // 
            this.PractiseNames.AutoSize = true;
            this.PractiseNames.Location = new System.Drawing.Point(240, 28);
            this.PractiseNames.Name = "PractiseNames";
            this.PractiseNames.Size = new System.Drawing.Size(106, 20);
            this.PractiseNames.TabIndex = 3;
            this.PractiseNames.Text = "PractiseNames";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(171, 341);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 204);
            this.listBox1.TabIndex = 4;
            // 
            // Practise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 624);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PractiseNames);
            this.Controls.Add(this.PNbox);
            this.Controls.Add(this.button1);
            this.Name = "Practise";
            this.Text = "Practise";
            this.Load += new System.EventHandler(this.Practise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox PNbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PractiseNames;
        private System.Windows.Forms.ListBox listBox1;
    }
}