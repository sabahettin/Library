using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class PublishingHouse
    {
        public int publishinghouseId { get; set; }
        public Guid publishingHouseCode { get; set; }
        public string publishingHouseName { get; set; }
        public bool status { get; set; }
    }
}
