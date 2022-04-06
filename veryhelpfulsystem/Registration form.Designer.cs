
namespace veryhelpfulsystem
{
    partial class Registration_form
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Passwordfield = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(326, 312);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(165, 33);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Создать аккаунт";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Регистрация";
            // 
            // Passwordfield
            // 
            this.Passwordfield.Location = new System.Drawing.Point(462, 243);
            this.Passwordfield.Name = "Passwordfield";
            this.Passwordfield.Size = new System.Drawing.Size(100, 26);
            this.Passwordfield.TabIndex = 9;
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(462, 185);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(100, 26);
            this.LoginField.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // Registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passwordfield);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration_form";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passwordfield;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}