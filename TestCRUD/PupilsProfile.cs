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
    public partial class PupilsProfile : Form
    {
        public PupilsProfile()
        {
            InitializeComponent();
        }
        private void PupilsProfile_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO PupilsProfile  VALUES (@FirstName, @LastName,@DateofBirth,@Age,@Gender,@Address)", con);
            cmd.Parameters.AddWithValue("@FirstName", TBfirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", TBlastName.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", TBDoB.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(TBage.Text));
            cmd.Parameters.AddWithValue("@Gender", TBgender.Text);
            cmd.Parameters.AddWithValue("@Address", TBaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBfirstName.Text = " ";
            TBlastName.Text = " ";
            TBDoB.Text = "";
            TBage.Text = " ";
            TBgender.Text = " ";
            TBaddress.Text = " ";
 
            MessageBox.Show("Successfully Added! ");
            BindData();
        }
  
        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE PupilsProfile SET FirstName=@FirstName, LastName=@LastName,DateofBirth=@DateofBirth,Age=@Age,Gender=@Gender,Address=@Address WHERE PupilsID=@PupilsID", con);
            cmd.Parameters.AddWithValue("@PupilsID", int.Parse(TBpupilsID.Text));
            cmd.Parameters.AddWithValue("@FirstName", TBfirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", TBlastName.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", TBDoB.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(TBage.Text));
            cmd.Parameters.AddWithValue("@Gender", TBgender.Text);
            cmd.Parameters.AddWithValue("@Address", TBaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBpupilsID.Text = " ";
            TBfirstName.Text = " ";
            TBlastName.Text = " ";
            TBDoB.Text = "";
            TBage.Text = " ";
            TBgender.Text = " ";
            TBaddress.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE PupilsProfile WHERE PupilsID=@PupilsID", con);
            cmd.Parameters.AddWithValue("@PupilsID", int.Parse(TBpupilsID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBpupilsID.Text = " ";
            TBfirstName.Text = " ";
            TBlastName.Text = " ";
            TBDoB.Text = "";
            TBage.Text = " ";
            TBgender.Text = " ";
            TBaddress.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PupilsProfile WHERE PupilsID=@PupilsID", con);
            cmd.Parameters.AddWithValue("@PupilsID", int.Parse(TBpupilsID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PupilsProfile ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
