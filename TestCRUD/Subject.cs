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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void Subject_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Subject  VALUES (@SubjectCode, @SubjectDescription)", con);
            cmd.Parameters.AddWithValue("@SubjectCode", TBsubjectCode.Text);
            cmd.Parameters.AddWithValue("@SubjectDescription", TBsubjectDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBsubjectCode.Text = " ";
            TBsubjectDesc.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Subject  SET SubjectCode=@SubjectCode, SubjectDescription=@SubjectDescription WHERE SubjectID=@SubjectID", con);
            cmd.Parameters.AddWithValue("@SubjectID", int.Parse(TBsubjectID.Text));
            cmd.Parameters.AddWithValue("@SubjectCode", TBsubjectCode.Text);
            cmd.Parameters.AddWithValue("@SubjectDescription", TBsubjectDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBsubjectID.Text = " ";
            TBsubjectCode.Text = " ";
            TBsubjectDesc.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Subject WHERE SubjectID=@SubjectID", con);
            cmd.Parameters.AddWithValue("@SubjectID", int.Parse(TBsubjectID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBsubjectID.Text = " ";
            TBsubjectCode.Text = " ";
            TBsubjectDesc.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject WHERE SubjectID=@SubjectID", con);
            cmd.Parameters.AddWithValue("@SubjectID", int.Parse(TBsubjectID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
