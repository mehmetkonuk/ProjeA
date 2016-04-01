using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeA
{
    class Comments:Database
    {
        public Comments()
        {
            Time = DateTime.Now;
        }
        public int ID { get; set; }
        public int ByID { get; set; }
        public int MovieID { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public bool Spoiler { get; set; }
    }
}
