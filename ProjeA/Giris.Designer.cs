namespace ProjeA
{
    partial class Giris
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.btnALogin = new System.Windows.Forms.Button();
            this.txtAPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtANick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbMember = new System.Windows.Forms.GroupBox();
            this.txtMPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMNick = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMLogin = new System.Windows.Forms.Button();
            this.lblWAdmin = new System.Windows.Forms.Label();
            this.lblWMember = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbAdmin.SuspendLayout();
            this.grbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(113, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici";
            // 
            // btnAdmin
            // 
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Location = new System.Drawing.Point(25, 40);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 30);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Yönetici";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblSignUp);
            this.groupBox2.Controls.Add(this.btnMember);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(113, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSignUp.Location = new System.Drawing.Point(25, 66);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(57, 17);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Kayıt Ol";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // btnMember
            // 
            this.btnMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMember.Location = new System.Drawing.Point(25, 29);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(100, 30);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "Üye";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // grbAdmin
            // 
            this.grbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.grbAdmin.Controls.Add(this.btnALogin);
            this.grbAdmin.Controls.Add(this.txtAPass);
            this.grbAdmin.Controls.Add(this.label2);
            this.grbAdmin.Controls.Add(this.txtANick);
            this.grbAdmin.Controls.Add(this.label1);
            this.grbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAdmin.ForeColor = System.Drawing.Color.Black;
            this.grbAdmin.Location = new System.Drawing.Point(329, 177);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Size = new System.Drawing.Size(200, 120);
            this.grbAdmin.TabIndex = 2;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Giriş Yap";
            // 
            // btnALogin
            // 
            this.btnALogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnALogin.Location = new System.Drawing.Point(66, 79);
            this.btnALogin.Name = "btnALogin";
            this.btnALogin.Size = new System.Drawing.Size(75, 23);
            this.btnALogin.TabIndex = 2;
            this.btnALogin.Text = "Giriş Yap";
            this.btnALogin.UseVisualStyleBackColor = true;
            this.btnALogin.Click += new System.EventHandler(this.btnALogin_Click);
            // 
            // txtAPass
            // 
            this.txtAPass.Location = new System.Drawing.Point(66, 52);
            this.txtAPass.Name = "txtAPass";
            this.txtAPass.PasswordChar = '*';
            this.txtAPass.Size = new System.Drawing.Size(100, 20);
            this.txtAPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtANick
            // 
            this.txtANick.Location = new System.Drawing.Point(66, 26);
            this.txtANick.Name = "txtANick";
            this.txtANick.Size = new System.Drawing.Size(100, 20);
            this.txtANick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nick Name";
            // 
            // grbMember
            // 
            this.grbMember.BackColor = System.Drawing.Color.Transparent;
            this.grbMember.Controls.Add(this.txtMPass);
            this.grbMember.Controls.Add(this.label3);
            this.grbMember.Controls.Add(this.txtMNick);
            this.grbMember.Controls.Add(this.label4);
            this.grbMember.Controls.Add(this.btnMLogin);
            this.grbMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbMember.Location = new System.Drawing.Point(329, 303);
            this.grbMember.Name = "grbMember";
            this.grbMember.Size = new System.Drawing.Size(200, 120);
            this.grbMember.TabIndex = 1;
            this.grbMember.TabStop = false;
            this.grbMember.Text = "Giriş Yap";
            // 
            // txtMPass
            // 
            this.txtMPass.Location = new System.Drawing.Point(66, 52);
            this.txtMPass.Name = "txtMPass";
            this.txtMPass.PasswordChar = '*';
            this.txtMPass.Size = new System.Drawing.Size(100, 20);
            this.txtMPass.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtMNick
            // 
            this.txtMNick.Location = new System.Drawing.Point(66, 26);
            this.txtMNick.Name = "txtMNick";
            this.txtMNick.Size = new System.Drawing.Size(100, 20);
            this.txtMNick.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nick Name";
            // 
            // btnMLogin
            // 
            this.btnMLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMLogin.Location = new System.Drawing.Point(66, 79);
            this.btnMLogin.Name = "btnMLogin";
            this.btnMLogin.Size = new System.Drawing.Size(75, 23);
            this.btnMLogin.TabIndex = 2;
            this.btnMLogin.Text = "Giriş Yap";
            this.btnMLogin.UseVisualStyleBackColor = true;
            this.btnMLogin.Click += new System.EventHandler(this.btnMLogin_Click);
            // 
            // lblWAdmin
            // 
            this.lblWAdmin.AutoSize = true;
            this.lblWAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblWAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWAdmin.Location = new System.Drawing.Point(536, 205);
            this.lblWAdmin.Name = "lblWAdmin";
            this.lblWAdmin.Size = new System.Drawing.Size(35, 13);
            this.lblWAdmin.TabIndex = 3;
            this.lblWAdmin.Text = "label5";
            // 
            // lblWMember
            // 
            this.lblWMember.AutoSize = true;
            this.lblWMember.BackColor = System.Drawing.Color.Transparent;
            this.lblWMember.ForeColor = System.Drawing.Color.Transparent;
            this.lblWMember.Location = new System.Drawing.Point(536, 331);
            this.lblWMember.Name = "lblWMember";
            this.lblWMember.Size = new System.Drawing.Size(35, 13);
            this.lblWMember.TabIndex = 4;
            this.lblWMember.Text = "label6";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(628, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(74, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWMember);
            this.Controls.Add(this.lblWAdmin);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.grbMember);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sign_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grbMember.ResumeLayout(false);
            this.grbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Button btnALogin;
        private System.Windows.Forms.TextBox txtAPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtANick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbMember;
        private System.Windows.Forms.TextBox txtMPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMNick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMLogin;
        private System.Windows.Forms.Label lblWAdmin;
        private System.Windows.Forms.Label lblWMember;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}