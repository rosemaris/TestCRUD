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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void Section_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Section ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Section  VALUES (@SectionCode, @SectionDescription)", con);
            cmd.Parameters.AddWithValue("@SectionCode", TBsectionCode.Text);
            cmd.Parameters.AddWithValue("@SectionDescription", TBsectionDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBsectionCode.Text = " ";
            TBsectionDesc.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Section SET SectionCode=@SectionCode, SectionDescription=@SectionDescription WHERE SectionID=@SectionID", con);
            cmd.Parameters.AddWithValue("@SectionID", TBsectionID.Text);
            cmd.Parameters.AddWithValue("@SectionCode", TBsectionCode.Text);
            cmd.Parameters.AddWithValue("@SectionDescription", TBsectionDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBsectionID.Text = " ";
            TBsectionCode.Text = " ";
            TBsectionDesc.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Section WHERE SectionID=@SectionID", con);
            cmd.Parameters.AddWithValue("@SectionID", int.Parse(TBsectionID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBsectionID.Text = " ";
            TBsectionCode.Text = " ";
            TBsectionDesc.Text = " ";

            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Section WHERE SectionID=@SectionID", con);
            cmd.Parameters.AddWithValue("@SectionID", int.Parse(TBsectionID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
