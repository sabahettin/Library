using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class Email
    {
        public int Id { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public string smtp { get; set; }
        public int port { get; set; }
        public bool ssl { get; set; }
    }
}
