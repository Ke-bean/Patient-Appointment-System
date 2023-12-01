
namespace Patient_Appointment_System
{
    partial class Login
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
            this.loginstuffBtn = new System.Windows.Forms.CheckBox();
            this.gobackBtn = new System.Windows.Forms.Button();
            this.togglepassBtn = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginstuffBtn
            // 
            this.loginstuffBtn.AutoSize = true;
            this.loginstuffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginstuffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginstuffBtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginstuffBtn.Location = new System.Drawing.Point(517, 346);
            this.loginstuffBtn.Name = "loginstuffBtn";
            this.loginstuffBtn.Size = new System.Drawing.Size(141, 36);
            this.loginstuffBtn.TabIndex = 30;
            this.loginstuffBtn.Text = "Log in as Doctor";
            this.loginstuffBtn.UseVisualStyleBackColor = true;
            this.loginstuffBtn.CheckedChanged += new System.EventHandler(this.loginstuffBtn_CheckedChanged);
            // 
            // gobackBtn
            // 
            this.gobackBtn.BackColor = System.Drawing.Color.Silver;
            this.gobackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobackBtn.ForeColor = System.Drawing.Color.DimGray;
            this.gobackBtn.Location = new System.Drawing.Point(648, 390);
            this.gobackBtn.Name = "gobackBtn";
            this.gobackBtn.Size = new System.Drawing.Size(101, 38);
            this.gobackBtn.TabIndex = 29;
            this.gobackBtn.Text = "Go Back";
            this.gobackBtn.UseVisualStyleBackColor = false;
            // 
            // togglepassBtn
            // 
            this.togglepassBtn.AutoSize = true;
            this.togglepassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglepassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.togglepassBtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglepassBtn.Location = new System.Drawing.Point(483, 273);
            this.togglepassBtn.Name = "togglepassBtn";
            this.togglepassBtn.Size = new System.Drawing.Size(133, 36);
            this.togglepassBtn.TabIndex = 28;
            this.togglepassBtn.Text = "Show Password";
            this.togglepassBtn.UseVisualStyleBackColor = true;
            this.togglepassBtn.CheckedChanged += new System.EventHandler(this.togglepassBtn_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(51, 390);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(698, 38);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have an account? Sign Up";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Silver;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.DimGray;
            this.loginBtn.Location = new System.Drawing.Point(172, 336);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(308, 51);
            this.loginBtn.TabIndex = 26;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwTextBox
            // 
            this.passwTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwTextBox.Location = new System.Drawing.Point(172, 276);
            this.passwTextBox.Name = "passwTextBox";
            this.passwTextBox.PasswordChar = '*';
            this.passwTextBox.Size = new System.Drawing.Size(292, 26);
            this.passwTextBox.TabIndex = 25;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(178, 241);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 23);
            this.password.TabIndex = 24;
            this.password.Text = "Type your PassWord: ";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(172, 199);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(292, 26);
            this.emailTextBox.TabIndex = 23;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(178, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(164, 23);
            this.email.TabIndex = 22;
            this.email.Text = "Enter your Email: ";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 90);
            this.label1.TabIndex = 21;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginstuffBtn);
            this.Controls.Add(this.gobackBtn);
            this.Controls.Add(this.togglepassBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox loginstuffBtn;
        private System.Windows.Forms.Button gobackBtn;
        private System.Windows.Forms.CheckBox togglepassBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox passwTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label1;
    }
}