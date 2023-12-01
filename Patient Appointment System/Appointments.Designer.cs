
namespace Patient_Appointment_System
{
    partial class Appointments
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
            this.submitclaimBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.claimTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitclaimBtn
            // 
            this.submitclaimBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitclaimBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitclaimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitclaimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitclaimBtn.ForeColor = System.Drawing.Color.White;
            this.submitclaimBtn.Location = new System.Drawing.Point(252, 300);
            this.submitclaimBtn.Name = "submitclaimBtn";
            this.submitclaimBtn.Size = new System.Drawing.Size(279, 45);
            this.submitclaimBtn.TabIndex = 24;
            this.submitclaimBtn.Text = "Submit Appointment";
            this.submitclaimBtn.UseVisualStyleBackColor = false;
            this.submitclaimBtn.Click += new System.EventHandler(this.submitclaimBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(582, 135);
            this.textBox1.TabIndex = 23;
            // 
            // claimTxt
            // 
            this.claimTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.claimTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimTxt.ForeColor = System.Drawing.Color.White;
            this.claimTxt.Location = new System.Drawing.Point(272, 51);
            this.claimTxt.Name = "claimTxt";
            this.claimTxt.Size = new System.Drawing.Size(230, 56);
            this.claimTxt.TabIndex = 22;
            this.claimTxt.Text = "Write your Appointment body ";
            this.claimTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitclaimBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.claimTxt);
            this.Name = "Appointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.Appointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitclaimBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label claimTxt;
    }
}