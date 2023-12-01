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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1083VVU\SQLEXPRESS;Initial Catalog=PatientMs;Integrated Security=True");

        private void createaccBtn_Click(object sender, EventArgs e)
        {
            if (patientidTextBox.Text == "" || fnameTextBox.Text == "" || emailTextBox.Text == "" || passwTextBox.Text == "")
            {
                MessageBox.Show("All fields must be filled", "Sign up failed");
            }
            else
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Patients values(@id,@fname,@email,@pass)", Con);
                cmd.Parameters.AddWithValue("@id", patientidTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", fnameTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwTextBox.Text);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("" + fnameTextBox.Text + " Successfully Registerd", "Success");
                patientidTextBox.Text = "";
                fnameTextBox.Text = "";
                emailTextBox.Text = "";
                passwTextBox.Text = "";
                
            }
        }

        private void showpassBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassBtn.Checked)
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
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
