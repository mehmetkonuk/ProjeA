namespace ProjeA
{
    partial class Search
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllUserlist = new System.Windows.Forms.Button();
            this.btnDetailSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProfilView = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.cmbGrade);
            this.panel1.Controls.Add(this.txtNickname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDetailSearch);
            this.panel1.Controls.Add(this.btnAllUserlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnAllUserlist
            // 
            this.btnAllUserlist.Location = new System.Drawing.Point(43, 22);
            this.btnAllUserlist.Name = "btnAllUserlist";
            this.btnAllUserlist.Size = new System.Drawing.Size(125, 23);
            this.btnAllUserlist.TabIndex = 0;
            this.btnAllUserlist.Text = "Tüm Kullanıcıları listele";
            this.btnAllUserlist.UseVisualStyleBackColor = true;
            // 
            // btnDetailSearch
            // 
            this.btnDetailSearch.Location = new System.Drawing.Point(174, 22);
            this.btnDetailSearch.Name = "btnDetailSearch";
            this.btnDetailSearch.Size = new System.Drawing.Size(103, 23);
            this.btnDetailSearch.TabIndex = 0;
            this.btnDetailSearch.Text = "Gelişmiş Arama";
            this.btnDetailSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(212, 52);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(84, 20);
            this.txtNickname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rütbe";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(343, 49);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(76, 21);
            this.cmbGrade.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 219);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnProfilView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 45);
            this.panel3.TabIndex = 2;
            // 
            // btnProfilView
            // 
            this.btnProfilView.Location = new System.Drawing.Point(13, 10);
            this.btnProfilView.Name = "btnProfilView";
            this.btnProfilView.Size = new System.Drawing.Size(75, 23);
            this.btnProfilView.TabIndex = 0;
            this.btnProfilView.Text = "Görüntüle";
            this.btnProfilView.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(343, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listID,
            this.listName,
            this.listSurname,
            this.listNickname,
            this.listAge,
            this.listGrade});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 219);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listID
            // 
            this.listID.Text = "ID";
            this.listID.Width = 30;
            // 
            // listName
            // 
            this.listName.Text = "İsim";
            this.listName.Width = 100;
            // 
            // listSurname
            // 
            this.listSurname.Text = "Soyadı";
            // 
            // listNickname
            // 
            this.listNickname.Text = "Nickname";
            // 
            // listAge
            // 
            this.listAge.Text = "Yaş";
            // 
            // listGrade
            // 
            this.listGrade.Text = "Rütbe";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 319);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Search";
            this.Text = "Search";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllUserlist;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetailSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listID;
        private System.Windows.Forms.ColumnHeader listName;
        private System.Windows.Forms.ColumnHeader listSurname;
        private System.Windows.Forms.ColumnHeader listNickname;
        private System.Windows.Forms.ColumnHeader listAge;
        private System.Windows.Forms.ColumnHeader listGrade;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProfilView;
    }
}