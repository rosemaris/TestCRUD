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
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void Level_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Level ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Level  VALUES ( @LevelCode, @LevelDescription)", con);
            cmd.Parameters.AddWithValue("@LevelCode", TBlevelCode.Text);
            cmd.Parameters.AddWithValue("@LevelDescription", TBlevelDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelCode.Text = " ";
            TBlevelDesc.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Level  SET LevelCode=@LevelCode, LevelDescription=@LevelDescription WHERE LevelID=@LevelID", con);
            cmd.Parameters.AddWithValue("@LevelID", int.Parse(TBlevelID.Text));
            cmd.Parameters.AddWithValue("@LevelCode", TBlevelCode.Text);
            cmd.Parameters.AddWithValue("@LevelDescription", TBlevelDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelID.Text = " ";
            TBlevelCode.Text = " ";
            TBlevelDesc.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Level WHERE LevelID=@LevelID", con);
            cmd.Parameters.AddWithValue("@LevelID", int.Parse(TBlevelID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBlevelID.Text = " ";
            TBlevelCode.Text = " ";
            TBlevelDesc.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Level WHERE LevelID=@LevelID", con);
            cmd.Parameters.AddWithValue("@LevelID", int.Parse(TBlevelID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
