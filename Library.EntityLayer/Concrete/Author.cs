using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class Author
    {
        public int authorId { get; set; }
        public Guid authorCode { get; set; }
        public string authorName { get; set; }
        public string authorLastname { get; set; }
        public string authorBiography { get; set; }
        public string authorPicture { get; set; }
        public bool status { get; set; }
        public virtual List<Book> Books { get; set; }

    }
}
