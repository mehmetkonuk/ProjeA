using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ProjeA
{
    class Users:Database
    {
        public Users()
        {
            
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public DateTime BirthofDate { get; set; }
        public int Age{
            get
            {
                return (int)((DateTime.Now - BirthofDate).TotalDays / 365);
            }
        }
        public string Image { get; set; }
        public string Grade { get; set; }
        public DateTime DateofReg { get; set; }
        public bool durum { get; set; }
        public Kitaplik k= new Kitaplik();
        public MovieAdd MA = new MovieAdd();
        //public Giris S = new Giris();
        public void Login(Users u)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                //string sorgu = "Select ID,Nickname,Password,Grade,Image from Users";
                string sorgu = "Select ID,Name,Surname,Nickname,Password,BirthofDate,Image,Grade,DateofReg from Users where NickName like @nick";
                komut.CommandText = sorgu;
                komut.Connection = conn;
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@nick",Nickname);
                dr = komut.ExecuteReader();
                //ada = new SqlDataAdapter(sorgu,conn);
                
                while (dr.Read())
                {
                    
                    if (durum==true)
                    {
                        if (Nickname == dr[3].ToString() && Password == dr[4].ToString())
                        {
                            ID = int.Parse(dr[0].ToString());
                            Name = dr[1].ToString();
                            Surname = dr[2].ToString();
                            BirthofDate = Convert.ToDateTime(dr[5]);
                            Image = dr[6].ToString();
                            Grade = dr[7].ToString();
                            DateofReg = Convert.ToDateTime(dr[8]);
                            k.lblUserName.Text = Name;
                            k.lblUserSurname.Text = Surname;
                            k.lblUserDateReg.Text = DateofReg.ToShortDateString();
                            k.pictureBox1.Load(Application.StartupPath+Image);
                            k.label1.Text = "Yöneticiler";
                            k.label4.Text = k.GirisYapan = Grade;
                            k.Show();
                            MA.ByID = ID;
                            //S.Hide();
                         }
                        else
                        {
                            MessageBox.Show("Giriş Bilgilerini Kontrol Edin ve Tekrar Deneyin","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    if (durum==false)
                    {

                        if (Nickname == dr["Nickname"].ToString() && Password == dr["Password"].ToString())
                        {

                            ID = int.Parse(dr[0].ToString());
                            Name = dr[1].ToString();
                            Surname = dr[2].ToString();
                            BirthofDate = Convert.ToDateTime(dr[5]);
                            Image = dr["Image"].ToString();
                            Grade = dr[7].ToString();
                            DateofReg = Convert.ToDateTime(dr[8]);
                            k.lblUserName.Text = Name;
                            k.lblUserSurname.Text = Surname;
                            k.lblUserDateReg.Text = DateofReg.ToShortDateString();
                            k.pictureBox1.Load(Application.StartupPath+Image);
                            k.label1.Text = "Kullanıcılar";
                            k.label4.Text=k.GirisYapan = Grade;
                            k.Show();
                            //S.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Giriş Bilgilerini Kontrol Edin ve Tekrar Deneyin", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    
                }
            }
            catch (Exception hata)
            {

                throw hata;
            }
            finally
            {
                conn.Close();
            }
        }
       
        public void id()
        {
            
            MA.ByID = ID;
        }
        public void UserListele(string grade)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sorgu = "select Name,Surname from Users where Grade like @grade";
                komut.CommandText = sorgu;
                komut.Connection = conn;
                komut.Parameters.AddWithValue("@grade",grade);
                dr = komut.ExecuteReader();
                while(dr.Read())
                {
                    k.listBoxUsers.Items.Add(string.Format("{0} {1}",dr[0],dr[1]));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool NicknameCheck()
        {
            
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sorgu = "select Nickname from Users where Nickname like @nickname";
                komut.CommandText = sorgu;
                komut.Connection = conn;
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@nickname",Nickname);
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public void Signup(Users U)
        {
            try
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                string sorgu = "insert into Users(Name,Surname,Nickname,Password,BirthofDate,Image,Grade,DateofReg) values(@name,@surname,@nick,@pass,@birth,@image,@grade,@regdate)";
                komut.CommandText = sorgu;
                komut.Connection = conn;
                komut.Parameters.AddWithValue("@name", U.Name);
                komut.Parameters.AddWithValue("@surname", U.Surname);
                komut.Parameters.AddWithValue("@nick", U.Nickname);
                komut.Parameters.AddWithValue("@pass", U.Password);
                komut.Parameters.AddWithValue("@birth", U.BirthofDate);
                komut.Parameters.AddWithValue("@image", U.Image);
                komut.Parameters.AddWithValue("@grade", U.Grade);
                komut.Parameters.AddWithValue("@regdate", U.DateofReg);
                komut.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
