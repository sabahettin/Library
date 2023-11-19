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
        public int categoryId { get; set; }
        public int authorId { get; set; }
        public int publishingHouseId { get; set; }
        public bool status { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual PublishingHouse PublishingHouse { get; set; }
    }
}
