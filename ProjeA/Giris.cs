using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjeA
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            File_Check();
        }
        private void File_Check()
        {
            if(!Directory.Exists(Application.StartupPath+@"/Database"))
            {
                Directory.CreateDirectory(Application.StartupPath+@"/Database");
            }
            else
            {
                if(!Directory.Exists(Application.StartupPath + @"/Database/Movies"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"/Database/Movies");
                    if (!Directory.Exists(Application.StartupPath + @"/Database/Movies/Images"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"/Database/Movies/Images");
                    }
                }
                if (!Directory.Exists(Application.StartupPath + @"/Database/Images"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"/Database/Images");
                    if (!Directory.Exists(Application.StartupPath + @"/Database/Images/Admin"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"/Database/Images/Admin");
                    }
                    if (!Directory.Exists(Application.StartupPath + @"/Database/Images/Member"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"/Database/Images/Member");
                    }
                    if (!Directory.Exists(Application.StartupPath + @"/Database/Images/Profil"))
                    {
                        Directory.CreateDirectory(Application.StartupPath + @"/Database/Images/Profil");
                    }
                }
            }
        }
        Users U = new Users();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
      
        private void Sign_Load(object sender, EventArgs e)
        {
            U.conn.Open();
            da = new SqlDataAdapter("select * from Users",U.conn);
            ds = new DataSet();
            da.Fill(ds, "Users");
            dataGridView1.DataSource = ds.Tables[0];
            U.conn.Close();
            grbAdmin.Visible = false;
            lblWAdmin.Visible = false;
            grbMember.Visible = false;
            lblWMember.Visible = false;
        }
        public bool admin = false;
        public bool member = false;
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin = true;
            member = false;
            login();
            txtANick.Text = txtAPass.Text = null;
        }
        private void login()
        {
            if(admin)
            {
                grbAdmin.Visible = true;
                grbMember.Visible = false;
            }
            else if(member)
            {
                grbMember.Visible = true;
                grbAdmin.Visible = false;
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            admin = false;
            member = true;
            login();
            txtMNick.Text = txtMPass.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnALogin_Click(object sender, EventArgs e)
        {

            U.Nickname = txtANick.Text;
            U.Password = txtAPass.Text;
            U.durum = true;
            U.Login(U);
            U.Nickname = null;
            U.Password = null;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp Su = new SignUp();
            Su.ShowDialog();
        }

        private void btnMLogin_Click(object sender, EventArgs e)
        {
            U.Nickname = txtMNick.Text;
            U.Password = txtMPass.Text;
            U.durum = false;
            U.Login(U);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmdb = new SqlCommandBuilder(da);
            da.Update(ds,"Users");
            MessageBox.Show("Tamadır");
        }
    }
}
