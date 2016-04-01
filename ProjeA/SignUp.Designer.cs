namespace ProjeA
{
    partial class SignUp
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassAgain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.picProfil = new System.Windows.Forms.PictureBox();
            this.btnimgOpen = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnNCheck = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(85, 46);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nick Name";
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.SystemColors.Window;
            this.txtNickname.Location = new System.Drawing.Point(85, 70);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(100, 20);
            this.txtNickname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şifre";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(85, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre tekrar";
            // 
            // txtPassAgain
            // 
            this.txtPassAgain.Location = new System.Drawing.Point(85, 118);
            this.txtPassAgain.Name = "txtPassAgain";
            this.txtPassAgain.PasswordChar = '*';
            this.txtPassAgain.Size = new System.Drawing.Size(100, 20);
            this.txtPassAgain.TabIndex = 4;
            this.txtPassAgain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassAgain_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Doğum Tarihi";
            // 
            // dateBirth
            // 
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(85, 142);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(100, 20);
            this.dateBirth.TabIndex = 5;
            // 
            // picProfil
            // 
            this.picProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfil.InitialImage = null;
            this.picProfil.Location = new System.Drawing.Point(236, 25);
            this.picProfil.Name = "picProfil";
            this.picProfil.Size = new System.Drawing.Size(128, 137);
            this.picProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfil.TabIndex = 3;
            this.picProfil.TabStop = false;
            // 
            // btnimgOpen
            // 
            this.btnimgOpen.Location = new System.Drawing.Point(236, 168);
            this.btnimgOpen.Name = "btnimgOpen";
            this.btnimgOpen.Size = new System.Drawing.Size(75, 23);
            this.btnimgOpen.TabIndex = 8;
            this.btnimgOpen.Text = "Profil Foto";
            this.btnimgOpen.UseVisualStyleBackColor = true;
            this.btnimgOpen.Click += new System.EventHandler(this.btnimgOpen_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(56, 168);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Kayıt Ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnNCheck
            // 
            this.btnNCheck.Location = new System.Drawing.Point(191, 70);
            this.btnNCheck.Name = "btnNCheck";
            this.btnNCheck.Size = new System.Drawing.Size(20, 20);
            this.btnNCheck.TabIndex = 6;
            this.btnNCheck.Text = "+";
            this.btnNCheck.UseVisualStyleBackColor = true;
            this.btnNCheck.Click += new System.EventHandler(this.btnNCheck_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 227);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNCheck);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnimgOpen);
            this.Controls.Add(this.picProfil);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassAgain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassAgain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.PictureBox picProfil;
        private System.Windows.Forms.Button btnimgOpen;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnNCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}