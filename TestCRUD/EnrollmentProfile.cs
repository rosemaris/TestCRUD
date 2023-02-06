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
    public partial class EnrollmentProfile : Form
    {
        public EnrollmentProfile()
        {
            InitializeComponent();
        }

        private void EnrollmentProfile_Load_1(object sender, EventArgs e)
        {
            PupilsID();
            LevelSectionTeachersID();
            LevelSubjectTeachersID();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM EnrollmentProfile ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {

            //foreach (string secList in CBLSTid.CheckedItems)
            //{
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO EnrollmentProfile  VALUES (@EnrollmentDate, @SchoolYear,@PupilsID,@LevelSectionTeacherID,@LevelSubjectTeacherID )", con);

                cmd.Parameters.AddWithValue("@EnrollmentDate", TBenrolDate.Text);
                cmd.Parameters.AddWithValue("@SchoolYear", TBschoolYear.Text);
                cmd.Parameters.AddWithValue("@PupilsID", CBpupilsID.Text);
                cmd.Parameters.AddWithValue("@LevelSectionTeacherID", int.Parse(CBlevelSecTeachID.Text));
                cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", CBLSTid.Text);
               // cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", CBLSTid.Items.Add(secList));
                cmd.ExecuteNonQuery();
                con.Close();

                TBenrolID.Text = "";
                TBenrolDate.Text = "";
                TBschoolYear.Text = "";
                CBpupilsID.Text = "";
                CBlevelSecTeachID.Text = "";
                CBLSTid.Text = " ";

                MessageBox.Show("Successfully Added! ");
            //}
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();


            SqlCommand cmd = new SqlCommand("UPDATE EnrollmentProfile  SET EnrollmentDate=@EnrollmentDate, SchoolYear=@SchoolYear,PupilsID=@PupilsID,LevelSectionTeacherID=@LevelSectionTeacherID,LevelSubjectTeacherID=@LevelSubjectTeacherID WHERE PupilsEnrollmentID=@PupilsEnrollmentID", con);
            cmd.Parameters.AddWithValue("@PupilsEnrollmentID", int.Parse(TBenrolID.Text));
            cmd.Parameters.AddWithValue("@EnrollmentDate", TBenrolDate.Text);
            cmd.Parameters.AddWithValue("@SchoolYear", TBschoolYear.Text);
            cmd.Parameters.AddWithValue("@PupilsID", CBpupilsID.Text);
            cmd.Parameters.AddWithValue("@LevelSectionTeacherID", int.Parse(CBlevelSecTeachID.Text));
            cmd.Parameters.AddWithValue("@LevelSubjectTeacherID", CBLSTid.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBenrolID.Text = "";
            TBenrolDate.Text = "";
            TBschoolYear.Text = "";
            CBpupilsID.Text = "";
            CBlevelSecTeachID.Text = "";
            CBLSTid.Text = "";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE EnrollmentProfile WHERE PupilsEnrollmentID=@PupilsEnrollmentID", con);
            cmd.Parameters.AddWithValue("@PupilsEnrollmentID", int.Parse(TBenrolID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBenrolID.Text = "";
            TBenrolDate.Text = "";
            TBschoolYear.Text = "";
            CBpupilsID.Text = "";
            CBlevelSecTeachID.Text = "";
            CBLSTid.Text = "";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EnrollmentProfile WHERE LRN=@PupilsID", con);
            cmd.Parameters.AddWithValue("@PupilsEnrollmentID", int.Parse(TBenrolID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void PupilsID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PupilsProfile ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBpupilsID.Items.Add(dr["PupilsID"].ToString());
            }
        }
            private void LevelSectionTeachersID()
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSectionTeacher ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    CBlevelSecTeachID.Items.Add(dr["LevelSectionTeacherID"].ToString());
                }
            
            }
        private void LevelSubjectTeachersID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LevelSubjectTeacher ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                CBLSTid.Items.Add(dr["LevelSubjectTeacherID"].ToString());
            }

        }

    }
}
        
