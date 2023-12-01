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
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1083VVU\SQLEXPRESS;Initial Catalog=PatientMs;Integrated Security=True");
        private void submitclaimBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (patientId, request) VALUES(@LoginId, @Claim)", Con);
            cmd.Parameters.AddWithValue("@LoginId", LoginInfo.LoginId);
            cmd.Parameters.AddWithValue("@Claim", textBox1.Text);


            try
            {
                Con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Request inserted successfully", "Success");
                }
                else
                {

                    MessageBox.Show("Request insertion failed", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
            finally
            {
                Con.Close();
            }
        }

        private void Appointments_Load(object sender, EventArgs e)
        {

        }
    }
}
