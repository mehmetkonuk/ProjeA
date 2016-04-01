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
    public partial class MovieAdd : Form
    {
        public MovieAdd()
        {
            InitializeComponent();
        }
        Movie M = new Movie();
        Kitaplik K = new Kitaplik();
        private void btnMovieimg_Click(object sender, EventArgs e)
        {
            Ac();
        }

        private void MovieAdd_Load(object sender, EventArgs e)
        {
            btnMovieimg.Visible = false;
            label5.Visible = false;
            listBoxActors.Visible = false;
            btnListEdit.Visible = false;
        }
        OpenFileDialog file = new OpenFileDialog();
        string imgLoc = null;
        public int ByID = 0;
        private void Tasi(string path)
        {
            try
            {
                string eski = path;
                string uzanti = Path.GetExtension(path);
                string imgName = txtMovieName.Text;
                string yeni = Application.StartupPath + @"/Database/Movies/Images/"+imgName+uzanti;
                M.Image = yeni.Substring(61);
                File.Copy(eski,yeni);

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
                file.Title = "Filmin Posterini Seçiniz";
                if(file.ShowDialog()==DialogResult.OK)
                {
                    imgLoc = picMovie.ImageLocation = file.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMimgdelete_Click(object sender, EventArgs e)
        {
            imgLoc = picMovie.ImageLocation = null;
        }

        private void btnMovieOpen_Click(object sender, EventArgs e)
        {
            file.Filter = "Video files |*.wmv; *.3gp; *.avi; *.mkv; *.mp4; ";
            file.Title = "Filmi Seçiniz";
            if(file.ShowDialog()==DialogResult.OK)
            {
                M.Path = file.FileName.ToString();
                txtMoviePath.Text = file.FileName.ToString();
            }
        }
        StringBuilder sb = new StringBuilder();
        private string Türler()
        {
            try
            {
                foreach(Control C in groupBox1.Controls)
                {
                    CheckBox chc = C as CheckBox;
                    if(chc!=null)
                    {
                        if(chc.Checked)
                        {
                            
                            sb.Append(chc.Text+",");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Türler();
            MessageBox.Show(sb.ToString());
        }

        private void txtMovieName_TextChanged(object sender, EventArgs e)
        {
            btnMovieimg.Visible = true;
        }
        private void FormErase()
        {
            try
            {
                //Tür Silme
                foreach (Control c in groupBox1.Controls)
                {
                    CheckBox chc = c as CheckBox;
                    if (chc != null)
                    {
                        if (chc.Checked)
                        {
                            chc.Checked = false;
                        }
                    }
                }
                //textbox temixleme
                foreach (Control C in this.Controls)
                {
                    TextBox txt = C as TextBox;
                    if (txt != null)
                    {
                        txt.Clear();
                    }
                }
                //resim temizleme
                imgLoc = picMovie.ImageLocation = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnMovieErase_Click(object sender, EventArgs e)
        {
            FormErase();
        }
        private void btnMovieCancel_Click(object sender, EventArgs e)
        {
            FormErase();
            this.Close();
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            M.ByID = ByID;
            M.Name = txtMovieName.Text;
            M.Year = txtMovieYear.Text;
            M.Rank = cmbRank.Text;
            M.Prize = int.Parse(txtMoviePrize.Text);
            M.Categories = Türler();
            M.Country = cmbCountry.Text;
            M.Path = txtMoviePath.Text;
            Tasi(imgLoc);
            M.Ekle(M);
            
            DialogResult sor=MessageBox.Show("Film Ekleme Başarılı");
            if (sor == DialogResult.OK)
            {
                K.listMovies.Refresh();
                this.Close();
            }
            
        }
    }
}
