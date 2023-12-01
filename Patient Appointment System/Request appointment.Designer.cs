
namespace Patient_Appointment_System
{
    partial class Request_appointment
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.stId = new System.Windows.Forms.Label();
            this.requestclaimBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Silver;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.DimGray;
            this.logoutBtn.Location = new System.Drawing.Point(650, 26);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(135, 33);
            this.logoutBtn.TabIndex = 37;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // stId
            // 
            this.stId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stId.ForeColor = System.Drawing.Color.White;
            this.stId.Location = new System.Drawing.Point(167, 215);
            this.stId.Name = "stId";
            this.stId.Size = new System.Drawing.Size(486, 27);
            this.stId.TabIndex = 36;
            this.stId.Text = "Welcome Dear: ";
            this.stId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // requestclaimBtn
            // 
            this.requestclaimBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.requestclaimBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestclaimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestclaimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestclaimBtn.ForeColor = System.Drawing.Color.White;
            this.requestclaimBtn.Location = new System.Drawing.Point(280, 312);
            this.requestclaimBtn.Name = "requestclaimBtn";
            this.requestclaimBtn.Size = new System.Drawing.Size(279, 45);
            this.requestclaimBtn.TabIndex = 33;
            this.requestclaimBtn.Text = "Request Appointment";
            this.requestclaimBtn.UseVisualStyleBackColor = false;
            this.requestclaimBtn.Click += new System.EventHandler(this.requestclaimBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(155, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 87);
            this.label1.TabIndex = 26;
            this.label1.Text = "Patient\'s Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Request_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 491);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.stId);
            this.Controls.Add(this.requestclaimBtn);
            this.Controls.Add(this.label1);
            this.Name = "Request_appointment";
            this.Text = "Request_appointment";
            this.Load += new System.EventHandler(this.Request_appointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label stId;
        private System.Windows.Forms.Button requestclaimBtn;
        private System.Windows.Forms.Label label1;
    }
}