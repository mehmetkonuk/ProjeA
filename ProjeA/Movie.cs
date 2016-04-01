using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjeA
{
    class Movie:Database
    {
        public Movie()
        {
            
        }
        public int ID { get; set; }
        public int ByID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Rank { get; set; }
        public string Categories { get; set; }//update
        public string Actors { get; set; }//update
        public string Image { get; set; }
        public string Path { get; set; }
        public int Seen { get; set; }
        public int Rent { get; set; }
        public int Prize { get; set; }
        //public Kitaplik k = new Kitaplik();

        public void Ekle(Movie M)
        {
            try
            {
                
                if (conn.State != ConnectionState.Open) conn.Open();
                string sorgu = "insert into Movies(ByAdd,Name,Country,Year,Rank,Categories,Image,Path,Prize) values(@byid,@name,@ülke,@yil,@puan,@tür,@resim,@yol,@fiyat)";
                komut.Connection = conn;
                komut.CommandText = sorgu;
                komut.Parameters.AddWithValue("@byid", ByID);
                komut.Parameters.AddWithValue("@name", Name);
                komut.Parameters.AddWithValue("@ülke", Country);
                komut.Parameters.AddWithValue("@yil", Year);
                komut.Parameters.AddWithValue("@puan", Rank);
                komut.Parameters.AddWithValue("@tür", Categories);
                komut.Parameters.AddWithValue("@resim", Image);
                komut.Parameters.AddWithValue("@yol", Path);
                komut.Parameters.AddWithValue("@fiyat", Prize);
                komut.ExecuteNonQuery();
                
            }
            catch (Exception hata)
            {

                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //düzenle metotu yazılacak...
    }
}
