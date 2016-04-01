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
    public class Database
    {
        public SqlConnection conn = new SqlConnection(@"Data Source = (LOCALDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\MovieDatabase.mdf;Integrated Security = True");
        public SqlCommand komut = new SqlCommand();
        public SqlDataAdapter ada;
        public SqlDataReader dr=null;
        //string yol = System.Reflection.Assembly.GetExecutingAssembly().Location;

    }
}
