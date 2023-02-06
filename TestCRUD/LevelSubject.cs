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
    public partial class LevelSubject : Form
    {
        public LevelSubject()
        {
            InitializeComponent();
        }

        private void LevelSubject_Load(object sender, EventArgs e)
        {
            BindData();
            SubjectID();
            LevelID();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void LevelID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Level ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBlevelID.Items.Add(dr["LevelID"].ToString());
            }
        }
        private void SubjectID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Subject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBsubjectID.Items.Add(dr["SubjectID"].ToString());
            }
        }


        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO LevelSubject  VALUES (@LevelID, @SubjectID)", con);
            cmd.Parameters.AddWithValue("@LevelID", CBlevelID.Text);
            cmd.Parameters.AddWithValue("@SubjectID", CBsubjectID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            CBlevelID.Text = " ";
            CBsubjectID.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE LevelSubject  SET LevelID=@LevelID, SubjectID=@SubjectID WHERE LevelSubjectID=@LevelSubjectID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectID", int.Parse(TBlevelsubjectID.Text));
            cmd.Parameters.AddWithValue("@LevelID", CBlevelID.Text);
            cmd.Parameters.AddWithValue("@SubjectID", CBsubjectID.Text); ;
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelsubjectID.Text = " ";
            CBlevelID.Text = " ";
            CBsubjectID.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE LevelSubject WHERE LevelSubjectID=@LevelSubjectID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectID", int.Parse(TBlevelsubjectID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBlevelsubjectID.Text = " ";
            CBlevelID.Text = " ";
            CBsubjectID.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubject WHERE LevelSubjectID=@LevelSubjectID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectID", int.Parse(TBlevelsubjectID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

 
    }
}
