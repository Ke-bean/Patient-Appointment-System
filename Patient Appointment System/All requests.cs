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
    public partial class All_requests : Form
    {
        public All_requests()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-1083VVU\SQLEXPRESS;Initial Catalog=PatientMs;Integrated Security=True");
        private void All_requests_Load(object sender, EventArgs e)
        {
            DisplayPatientRequests();
        }
        private void DisplayPatientRequests()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Appointments", Con);
            Con.Open();
            DataSet ds = new DataSet();
            sda.Fill(ds, "claims");
            dataGridView1.DataSource = ds.Tables["claims"];
        }
    }
}
