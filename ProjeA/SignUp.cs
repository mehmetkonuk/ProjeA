using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjeA
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            
        }
        Users U = new Users();
        OpenFileDialog file = new OpenFileDialog();
        string imgLoc = null;
        private void SignUp_Load(object sender, EventArgs e)
        {
            /*
            picProfil.Load(Application.StartupPath + @"\Database\İmages\Profil\user.png");
            S.Image = picProfil.ImageLocation;
            */
        }

        private void btnimgOpen_Click(object sender, EventArgs e)
        {
            Ac();
        }
        private void tasi(string path)
        {
            try
            {
                string eski = path;
                string uzantı = Path.GetExtension(path);
                string id = txtNickname.Text;
                string yeni = Application.StartupPath + @"/Database/Images/Member/" + id + uzantı;
                U.Image = yeni.Substring(61);
                File.Copy(eski,yeni);
                //U.Image = yeni;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Ac()
        {
            try
            {
                file.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
                file.Title = "Profil Resmi Seçiniz";
                if(file.ShowDialog()==DialogResult.OK)
                {
                    imgLoc = picProfil.ImageLocation = file.FileName.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnNCheck_Click(object sender, EventArgs e)
        {
            U.Nickname = txtNickname.Text;
            if (U.NicknameCheck())
            {
                txtNickname.BackColor = Color.Red;
                U.Nickname = null;
            }
            
            else
            {
                txtNickname.BackColor = Color.Green;
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "" || txtName.Text == "" || txtNickname.Text == "" || txtPassAgain.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtPassword.Text != txtPassAgain.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return;
            }
            if (imgLoc == null)
            {
                DialogResult cevap = MessageBox.Show("Profil Resmi Olmadan Kayıt Olunamaz", "Resim Seçilmedi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Retry)
                    return;
            }
            
            else
            {
                
                U.Password = txtPassword.Text;
                KayıtOl();
                DialogResult sor = MessageBox.Show("Tebrikler Kayıt Başarılı! Aramıza Hoşgeldin :)", "Kayıt Tamalandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (sor == DialogResult.OK)
                    this.Close();
            }
            
        }
        private void KayıtOl()
        {
            try
            {
                //foreach (Control item in this.Controls)
                //{
                //    TextBox txt = item as TextBox;
                //    if (txt == null)
                //    {
                //        MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        return;
                //    }
                //}
                if (checkBox1.Checked == true)
                    U.Grade = "Admin";
                else
                    U.Grade = "Member";
                U.Name = txtName.Text;
                U.Surname = txtLastname.Text;
                U.Nickname = txtNickname.Text;
                U.BirthofDate = dateBirth.Value;
                U.DateofReg = DateTime.Now;
                tasi(file.FileName.ToString());
                U.Signup(U);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Close();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }
        private void txtPassAgain_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPassword.TextLength == txtPassAgain.TextLength)
            {
                if (Validate(txtPassword.Text, txtPassAgain.Text) == false)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor!");
                }
            }
        }
        private bool Validate(String pass, String passagain)
        {
            return String.IsNullOrEmpty(pass) == false && pass == passagain;
        }
    }
}
