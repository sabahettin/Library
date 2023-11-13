using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class Member
    {
        public int memberId { get; set; }
        public Guid memberCode { get; set; }
        public string memberIdentity { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public bool gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime membershipDate { get; set; }
        public bool blocked { get; set; }
        public bool status { get; set; }
    }
}
