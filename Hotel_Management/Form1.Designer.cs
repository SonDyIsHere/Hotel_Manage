namespace Hotel_Management
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radiobtnUser = new System.Windows.Forms.RadioButton();
            this.radiobtnAdmin = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(416, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW HOTEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(188, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUsername.Location = new System.Drawing.Point(390, 182);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(431, 44);
            this.txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(188, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPwd.Location = new System.Drawing.Point(390, 284);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(431, 44);
            this.txtPwd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(938, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Who you are?";
            // 
            // radiobtnUser
            // 
            this.radiobtnUser.AutoSize = true;
            this.radiobtnUser.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radiobtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radiobtnUser.Location = new System.Drawing.Point(901, 267);
            this.radiobtnUser.Name = "radiobtnUser";
            this.radiobtnUser.Size = new System.Drawing.Size(88, 61);
            this.radiobtnUser.TabIndex = 4;
            this.radiobtnUser.TabStop = true;
            this.radiobtnUser.Text = "User";
            this.radiobtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnUser.UseVisualStyleBackColor = true;
            // 
            // radiobtnAdmin
            // 
            this.radiobtnAdmin.AutoSize = true;
            this.radiobtnAdmin.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radiobtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radiobtnAdmin.Location = new System.Drawing.Point(1023, 267);
            this.radiobtnAdmin.Name = "radiobtnAdmin";
            this.radiobtnAdmin.Size = new System.Drawing.Size(113, 61);
            this.radiobtnAdmin.TabIndex = 4;
            this.radiobtnAdmin.TabStop = true;
            this.radiobtnAdmin.Text = "Admin";
            this.radiobtnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogin.Location = new System.Drawing.Point(536, 416);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1148, 607);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.radiobtnAdmin);
            this.Controls.Add(this.radiobtnUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiobtnUser;
        private System.Windows.Forms.RadioButton radiobtnAdmin;
        private System.Windows.Forms.Button btnLogin;
    }
}

