using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using Library.BusinessLayer.Abstract;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
using System.Data;

namespace Library.UI
{
    public partial class XtraBook : DevExpress.XtraEditors.XtraForm
    {
        ICategoryService _categoryService;
        IBookService _bookService;
        IAuthorService _authorService;
        IPublishingHouseService _publishingHouseService;

        public XtraBook(ICategoryService categoryService, IBookService bookService, IAuthorService authorService, IPublishingHouseService publishingHouseService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _bookService = bookService;
            _authorService = authorService;
            _publishingHouseService = publishingHouseService;
        }
        int categoryId = 0;
        private void XtraBook_Load(object sender, EventArgs e)
        {
            List();
            var categories = _categoryService.TGetAll();
            var authors = _authorService.TGetAll();
            var publishingHouses = _publishingHouseService.TGetAll();
            foreach (var category in categories) { cmbCategory.Properties.Items.Add(category.categoryName); }
            foreach (var author in authors) { cmbAuthor.Properties.Items.Add(author.authorName + " " + author.authorLastname); }
            foreach (var publishingHouse in publishingHouses) { cmbPublishingHouse.Properties.Items.Add(publishingHouse.publishingHouseName); }
        }
        void List()
        {
            var list = _bookService.TGetAll();
            gridControl1.DataSource = list.ToList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            Book book = new Book();
            book.bookCode = Guid.NewGuid();
            book.bookBarcode = txtISBN.Text;
            book.isbn = txtISBN.Text;
            book.bookName = txtBookName.Text;
            book.releaseDate = Convert.ToDateTime(dEReleaseDate.Text);
            book.pageCount = Convert.ToInt32(txtPageCount.Text);
            book.bookPicture = pEBookPicture.Text;
            book.description = txtDescription.Text;
            book.bookCount = Convert.ToInt32(txtBookCount.Text);
            book.categoryId = categoryId;

            _bookService.TCreate(book);
            //Clear();
            List();
            XtraMessageBox.Show("Kitap Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryId = _categoryService.TGetAll(x => x.categoryName == cmbCategory.Text).Select(x => x.categoryId).FirstOrDefault();
        }
    }
}