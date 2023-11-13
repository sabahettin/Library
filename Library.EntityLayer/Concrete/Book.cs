using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class Book
    {
        public int bookId { get; set; }
        public Guid bookCode { get; set; }
        public string bookBarcode { get; set; }
        public string isbn { get; set; }
        public string bookName { get; set; }
        public DateTime releaseDate { get; set; }
        public int pageCount { get; set; }
        public string bookPicture { get; set; }
        public string description { get; set; }
        public int bookCount { get; set; }
        public bool status { get; set; }
    }
}
