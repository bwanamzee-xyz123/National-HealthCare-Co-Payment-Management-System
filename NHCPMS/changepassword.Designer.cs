namespace NHCPMS
{
    partial class changepassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Controls.Add(this.OldPassword);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.NewPassword);
            this.groupBox1.Controls.Add(this.ConfirmPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(80, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 367);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fill these fields";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Yellow;
            this.Label4.Location = new System.Drawing.Point(73, 75);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(112, 26);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "User Name";
            // 
            // UserName
            // 
            this.UserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(279, 75);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(273, 26);
            this.UserName.TabIndex = 19;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Yellow;
            this.Label1.Location = new System.Drawing.Point(73, 132);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(135, 26);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Old Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Yellow;
            this.Label2.Location = new System.Drawing.Point(73, 180);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(143, 26);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "New Password";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(185, 296);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(238, 38);
            this.Button1.TabIndex = 24;
            this.Button1.Text = "&Change Password";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // OldPassword
            // 
            this.OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassword.Location = new System.Drawing.Point(279, 132);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.PasswordChar = '*';
            this.OldPassword.Size = new System.Drawing.Size(273, 26);
            this.OldPassword.TabIndex = 20;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Yellow;
            this.Label3.Location = new System.Drawing.Point(73, 234);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(176, 26);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Confirm Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(279, 180);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(273, 26);
            this.NewPassword.TabIndex = 22;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(279, 234);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(273, 26);
            this.ConfirmPassword.TabIndex = 23;
            // 
            // changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(774, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox UserName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox OldPassword;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox NewPassword;
        internal System.Windows.Forms.TextBox ConfirmPassword;

    }
}