using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Appointment_System
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void viewallappointBtn_Click(object sender, EventArgs e)
        {
            All_requests form = new All_requests();
            form.Show();
            this.Hide();
        }
    }
}
