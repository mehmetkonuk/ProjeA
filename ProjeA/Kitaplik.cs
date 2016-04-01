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
using System.Diagnostics;

namespace ProjeA
{
    public partial class Kitaplik : Form
    {
        public Kitaplik()
        {
            InitializeComponent();
        }
        Movie M = new Movie();
        public string GirisYapan = null;
        private void Kitaplik_Load(object sender, EventArgs e)
        {
            btnMoviePlay.Enabled = false;
            if(GirisYapan=="Member")
            {
                btnMovieAdd.Visible = btnMovieDelete.Visible = btnMovieEdit.Visible = btnMoviePath.Visible = false;
                btnMoviePlay.Location = new Point(77,30);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            UserListele();
            FilmListele();
        }
        
        private void FilmListele()
        {
            Database db = new Database();
            SqlConnection conn = db.conn;
            SqlCommand komut = db.komut;
            SqlDataReader dr = db.dr;
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                string sorgu = "select * from Movies";
                komut.Connection = conn;
                komut.CommandText = sorgu;
                dr = komut.ExecuteReader();
                    while (dr.Read())
                    {
                        M.ID = int.Parse(dr[0].ToString());
                        M.Name = dr[2].ToString();
                        M.Country = dr[3].ToString();
                        M.Year = dr[4].ToString();
                        M.Rank = dr[5].ToString();
                        M.Categories = dr[6].ToString();
                        M.Image = dr[8].ToString();
                        M.Path = dr[9].ToString();
                        //M.Seen = int.Parse(dr[10].ToString());
                        //M.Rent = int.Parse(dr[11].ToString());
                        M.Prize = int.Parse(dr[12].ToString());
                      
                        ListViewItem item = new ListViewItem();
                        item.Text = M.ID.ToString();
                        item.SubItems.Add(M.Name);
                        item.SubItems.Add(M.Country);
                        item.SubItems.Add(M.Year);
                        item.SubItems.Add(M.Rank);
                        item.SubItems.Add(M.Categories);
                        item.SubItems.Add("0");
                        item.SubItems.Add("0");
                        item.SubItems.Add(M.Prize.ToString());
                    item.SubItems.Add(M.Image.ToString());
                    item.SubItems.Add(M.Path.ToString());
                        listMovies.Items.Add(item);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }//database filmlerini listview show
        private void UserListele()
        {
            Users U = new Users();
            try
            {
                
                if (U.conn.State == ConnectionState.Closed) U.conn.Open();
                string sorgu = "select Name,Surname,Grade from Users where Grade like @grade";
                U.komut.CommandText = sorgu;
                U.komut.Connection = U.conn;
                U.komut.Parameters.AddWithValue("@grade", GirisYapan);
                U.dr = U.komut.ExecuteReader();
                while (U.dr.Read())
                {
                    listBoxUsers.Items.Add(string.Format("{0} {1}",U.dr[0],U.dr[1]) );
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                U.conn.Close();
            }
        }//database grade ayni ise göster 
        private void MovieDetay()
        {
            ListView.SelectedListViewItemCollection secim = this.listMovies.SelectedItems;

            foreach (ListViewItem item in secim)
            {
                lblMovieName.Text = item.SubItems[1].Text;
                lblMovieCountry.Text = item.SubItems[2].Text;
                lblMovieYear.Text = item.SubItems[3].Text;
                lblMovieRank.Text = item.SubItems[4].Text;
                picMovie.ImageLocation = Application.StartupPath + item.SubItems[9].Text;
                M.Path = item.SubItems[10].Text;
            }
            PathCheck();
        }//secilenin detaylarını getirir.
        private void PathCheck()
        {
            if(File.Exists(M.Path)==false)
            {
                btnMoviePlay.Enabled = false;
            }
            else
            {
                btnMoviePlay.Enabled = true;
            }
        }//secilen film varmı?
        private void MoviePlay()
        {
            Process.Start(M.Path);
        }//secilen filmi oynat
        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            MovieAdd madd = new MovieAdd();
            madd.ShowDialog();
        }
        private void UserChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieDetay();
        }

        private void btnMoviePlay_Click(object sender, EventArgs e)
        {
            MoviePlay();
        }
    }
}
