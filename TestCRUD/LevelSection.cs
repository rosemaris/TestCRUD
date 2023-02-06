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
    public partial class LevelSection : Form
    {
        public LevelSection()
        {
            InitializeComponent();
        }

        private void LevelSection_Load(object sender, EventArgs e)
        {
            BindData();
            SectionID();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSection ", con);
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
        private void SectionID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Section ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBsectionID.Items.Add(dr["SectionID"].ToString());
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO LevelSection  VALUES (@LevelID, @SectionID)", con);
            cmd.Parameters.AddWithValue("@LevelID", CBlevelID.Text);
            cmd.Parameters.AddWithValue("@SectionID", CBsectionID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            CBlevelID.Text = " ";
            CBsectionID.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE LevelSection  SET LevelID=@LevelID, SectionID=@SectionID WHERE LevelSectionID=@LevelSectionID", con);
            cmd.Parameters.AddWithValue("@LevelSectionID", int.Parse(TBlevelsectionID.Text));
            cmd.Parameters.AddWithValue("@LevelID", CBlevelID.Text);
            cmd.Parameters.AddWithValue("@SectionID", CBsectionID.Text); ;
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelsectionID.Text = " ";
            CBlevelID.Text = " ";
            CBsectionID.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE LevelSection WHERE LevelSectionID=@LevelSectionID", con);
            cmd.Parameters.AddWithValue("@LevelSectionID", int.Parse(TBlevelsectionID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBlevelsectionID.Text = " ";
            CBlevelID.Text = " ";
            CBsectionID.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSection WHERE LevelSectonID=@LevelSectonID", con);
            cmd.Parameters.AddWithValue("@LevelSectionID", int.Parse(TBlevelsectionID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
