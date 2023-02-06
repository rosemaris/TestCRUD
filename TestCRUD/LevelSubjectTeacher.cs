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
    public partial class LevelSubjectTeacher : Form
    {
        public LevelSubjectTeacher()
        {
            InitializeComponent();
        }
        private void LevelSubjectTeacher_Load(object sender, EventArgs e)
        {
            BindData();
            LevelSubjectID();
            TeachersID();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubjectTeacher ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void LevelSubjectID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubject ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBlevelsubID.Items.Add(dr["LevelSubjectID"].ToString());
            }
        }
        private void TeachersID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBteachersID.Items.Add(dr["TeachersID"].ToString());
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO LevelSubjectTeacher  VALUES (@LevelSubjectID, @TeachersID)", con);
            cmd.Parameters.AddWithValue("@LevelSubjectID", CBlevelsubID.Text);
            cmd.Parameters.AddWithValue("@TeachersID", CBteachersID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            CBlevelsubID.Text = " ";
            CBteachersID.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE LevelSubjectTeacher  SET LevelSubjectID=@LevelSubjectID, TeachersID=@TeachersID WHERE LevelSubjectTeacherID=@LevelSubjectTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", int.Parse(TBlevelsubteachID.Text));
            cmd.Parameters.AddWithValue("@LevelSubjectID", CBlevelsubID.Text);
            cmd.Parameters.AddWithValue("@TeachersID", CBteachersID.Text); ;
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelsubteachID.Text = " ";
            CBlevelsubID.Text = " ";
            CBteachersID.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE LevelSubjectTeacher WHERE LevelSubjectTeacherID=@LevelSubjectTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", int.Parse(TBlevelsubteachID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBlevelsubteachID.Text = " ";
            CBlevelsubID.Text = " ";
            CBteachersID.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubjectTeacher WHERE LevelSubjectTeacherID=@LevelSubjectTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", int.Parse(TBlevelsubteachID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
