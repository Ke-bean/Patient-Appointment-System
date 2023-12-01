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
    public partial class Request_appointment : Form
    {
        public Request_appointment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1083VVU\SQLEXPRESS;Initial Catalog=PatientMs;Integrated Security=True");
        private void Request_appointment_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter($"SELECT * FROM Patients WHERE id={LoginInfo.LoginId}", Con);
            DataTable ds = new DataTable();
            cmd.Fill(ds);
            stId.Text = stId.Text + ds.Rows[0]["fullName"];

        }

        private void requestclaimBtn_Click(object sender, EventArgs e)
        {
            Appointments form = new Appointments(); 
            form.Show();
            this.Hide();
        }
    }
}
