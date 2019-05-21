namespace FormsLib
{
    partial class FormSignUp
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxAdminCode = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.labelAdminCode = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxLogin.Location = new System.Drawing.Point(210, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(249, 32);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(210, 88);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(249, 32);
            this.textBoxConfirmPassword.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxPassword.Location = new System.Drawing.Point(210, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(249, 32);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxAdminCode
            // 
            this.textBoxAdminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxAdminCode.Location = new System.Drawing.Point(210, 126);
            this.textBoxAdminCode.Name = "textBoxAdminCode";
            this.textBoxAdminCode.Size = new System.Drawing.Size(249, 32);
            this.textBoxAdminCode.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelLogin.Location = new System.Drawing.Point(81, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(125, 26);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "User name:";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPassword.Location = new System.Drawing.Point(92, 53);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(114, 26);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelConfirmPassword.Location = new System.Drawing.Point(12, 91);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(194, 26);
            this.labelConfirmPassword.TabIndex = 6;
            this.labelConfirmPassword.Text = "Confirm password:";
            // 
            // labelAdminCode
            // 
            this.labelAdminCode.AutoSize = true;
            this.labelAdminCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAdminCode.Location = new System.Drawing.Point(30, 129);
            this.labelAdminCode.Name = "labelAdminCode";
            this.labelAdminCode.Size = new System.Drawing.Size(176, 26);
            this.labelAdminCode.TabIndex = 7;
            this.labelAdminCode.Text = "Code for admin*:";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSignUp.Location = new System.Drawing.Point(178, 192);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(120, 40);
            this.buttonSignUp.TabIndex = 8;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "*This field is used for registering admin account. Leave it unfilled.";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelAdminCode);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxAdminCode);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxLogin);
            this.MaximumSize = new System.Drawing.Size(490, 280);
            this.MinimumSize = new System.Drawing.Size(490, 280);
            this.Name = "FormSignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxAdminCode;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Label labelAdminCode;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label1;
    }
}