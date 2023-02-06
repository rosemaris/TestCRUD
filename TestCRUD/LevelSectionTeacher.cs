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
    public partial class LevelSectionTeacher : Form
    {
        public LevelSectionTeacher()
        {
            InitializeComponent();
        }

        private void LevelSectionTeacher_Load(object sender, EventArgs e)
        {
            BindData();
            LevelSectionID();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSectionTeacher ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void LevelSectionID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSection ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBlevelsecID.Items.Add(dr["LevelSectionID"].ToString());
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

            SqlCommand cmd = new SqlCommand("INSERT INTO LevelSectionTeacher  VALUES (@LevelSectionID, @TeachersID)", con);
            cmd.Parameters.AddWithValue("@LevelSectionID", CBlevelsecID.Text);
            cmd.Parameters.AddWithValue("@TeachersID", CBteachersID.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            CBlevelsecID.Text = " ";
            CBteachersID.Text = " ";

            MessageBox.Show("Successfully Added! ");
            BindData();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE LevelSectionTeacher  SET LevelSectionID=@LevelSectionID, TeachersID=@TeachersID WHERE LevelSectionTeacherID=@LevelSectionTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSectionTeacherID", int.Parse(TBlevelsecteachID.Text));
            cmd.Parameters.AddWithValue("@LevelSectionID", CBlevelsecID.Text);
            cmd.Parameters.AddWithValue("@TeachersID", CBteachersID.Text); ;
            cmd.ExecuteNonQuery();
            con.Close();

            TBlevelsecteachID.Text = " ";
            CBlevelsecID.Text = " ";
            CBteachersID.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE LevelSectionTeacher WHERE LevelSectionTeacherID=@LevelSectionTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSectionTeacherID", int.Parse(TBlevelsecteachID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBlevelsecteachID.Text = " ";
            CBlevelsecID.Text = " ";
            CBteachersID.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSectionTeacher WHERE LevelSectionTeacherID=@LevelSectionTeacherID", con);
            cmd.Parameters.AddWithValue("@LevelSectionTeacherID", int.Parse(TBlevelsecteachID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
