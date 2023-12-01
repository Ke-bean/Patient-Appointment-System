using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Patient_Appointment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1083VVU\SQLEXPRESS;Initial Catalog=PatientMs;Integrated Security=True");
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginstuffBtn.Checked)
            {
                if (emailTextBox.Text == "" || passwTextBox.Text == "")
                {
                    MessageBox.Show("email or password field can't be empty", "Fields can't be empty");
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doctors WHERE email=@email and password=@pass", Con);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwTextBox.Text);
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int x = ds.Tables[0].Rows.Count;
                if (x > 0)
                {
                    LoginInfo.LoginId = (int)ds.Tables[0].Rows[0]["id"];
                    emailTextBox.Text = "";
                    passwTextBox.Text = "";
                    MessageBox.Show("Login Successfully completed", "Login Success");
                    Doctors form = new Doctors();
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password, please try again", "Login Failed");
                    emailTextBox.Text = "";
                    passwTextBox.Text = "";
                    emailTextBox.Focus();
                }
            }
            else
            {
                if (emailTextBox.Text == "" || passwTextBox.Text == "") 
                {
                    MessageBox.Show("email or password field can't be empty", "Fields can't be empty");
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM Patients WHERE email=@email", Con);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                int x = ds.Tables[0].Rows.Count;
                if (x > 0)
                {
                    LoginInfo.LoginId = (int)ds.Tables[0].Rows[0]["id"];
                    emailTextBox.Text = "";
                    passwTextBox.Text = "";
                    MessageBox.Show("Login Successfully completed", "Login Success");
                    Request_appointment form = new Request_appointment();
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password, please try again", "Login Failed");
                    emailTextBox.Text = "";
                    passwTextBox.Text = "";
                    emailTextBox.Focus();
                }
                Con.Close();
            }
        }

        private void loginstuffBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void togglepassBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (togglepassBtn.Checked)
            {
                passwTextBox.PasswordChar = '\0';
            }
            else
            {
                passwTextBox.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
