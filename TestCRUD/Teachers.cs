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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void Teachers_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Teachers  VALUES ( @FirstName, @LastName,@DateofBirth,@Age,@Gender,@Address)", con);
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Teachers SET FirstName=@FirstName, LastName=@LastName,DateofBirth=@DateofBirth,Age=@Age,Gender=@Gender,Address=@Address WHERE TeachersID=@TeachersID", con);
            cmd.Parameters.AddWithValue("@TeachersID", int.Parse(TBteachersID.Text));
            cmd.Parameters.AddWithValue("@FirstName", TBfirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", TBlastName.Text);
            cmd.Parameters.AddWithValue("@DateofBirth", TBDoB.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(TBage.Text));
            cmd.Parameters.AddWithValue("@Gender", TBgender.Text);
            cmd.Parameters.AddWithValue("@Address", TBaddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            TBteachersID.Text = " ";
            TBfirstName.Text = " ";
            TBlastName.Text = " ";
            TBDoB.Text = "";
            TBage.Text = " ";
            TBgender.Text = " ";
            TBaddress.Text = " ";

            MessageBox.Show("Successfully Updated! ");

            BindData();
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Teachers WHERE TeachersID=@TeachersID", con);
            cmd.Parameters.AddWithValue("@TeachersID", int.Parse(TBteachersID.Text));
            cmd.ExecuteNonQuery();

            con.Close();

            TBteachersID.Text = " ";
            TBfirstName.Text = " ";
            TBlastName.Text = " ";
            TBDoB.Text = "";
            TBage.Text = " ";
            TBgender.Text = " ";
            TBaddress.Text = " ";


            MessageBox.Show("Successfully Deleted! ");

            BindData();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7PT0A7S5\SQLEXPRESS;Initial Catalog=SchoolSystemNew;Integrated Security=True;Pooling=False ");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers WHERE TeachersID=@TeachersID", con);
            cmd.Parameters.AddWithValue("@TeachersID", int.Parse(TBteachersID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
