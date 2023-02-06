using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCRUD
{
    public partial class Practise : Form
    {
        public Practise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string s in PNbox.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }

        private void Practise_Load(object sender, EventArgs e)
        {

        }
    }
}
