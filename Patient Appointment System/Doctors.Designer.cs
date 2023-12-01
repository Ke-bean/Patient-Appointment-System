
namespace Patient_Appointment_System
{
    partial class Doctors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewallappointBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewallappointBtn
            // 
            this.viewallappointBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewallappointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallappointBtn.ForeColor = System.Drawing.Color.White;
            this.viewallappointBtn.Location = new System.Drawing.Point(190, 186);
            this.viewallappointBtn.Name = "viewallappointBtn";
            this.viewallappointBtn.Size = new System.Drawing.Size(430, 73);
            this.viewallappointBtn.TabIndex = 20;
            this.viewallappointBtn.Text = "View All Appointment Requests";
            this.viewallappointBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewallappointBtn.Click += new System.EventHandler(this.viewallappointBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(130, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 91);
            this.label1.TabIndex = 18;
            this.label1.Text = "Doctor\'s  Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewallappointBtn);
            this.Controls.Add(this.label1);
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label viewallappointBtn;
        private System.Windows.Forms.Label label1;
    }
}