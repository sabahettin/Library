using DevExpress.Mvvm.Native;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.X509;
using DevExpress.XtraEditors;
using DevExpress.XtraMap.Drawing;
using Library.BusinessLayer.Abstract;
using Library.DataLayer.Context;
using Library.DataLayer.Repositories.Concrete.EntityTypeRepository;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.IO;

namespace Library.UI
{
    public partial class XtraBook : DevExpress.XtraEditors.XtraForm
    {
        ICategoryService _categoryService;
        IBookService _bookService;
        IAuthorService _authorService;
        IPublishingHouseService _publishingHouseService;
        ApplicationDbContext _context;

        public XtraBook(ICategoryService categoryService, IBookService bookService, IAuthorService authorService, IPublishingHouseService publishingHouseService, ApplicationDbContext context)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _bookService = bookService;
            _authorService = authorService;
            _publishingHouseService = publishingHouseService;
            _context = context;
        }
        int categoryId = 0;
        int authorId = 0;
        int punlishingHouseId = 0;
        int _id;
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
        private void Clear(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextEdit)
                {
                    ((TextEdit)c).EditValue = string.Empty;
                }
                else if (c is ComboBoxEdit)
                {
                    ((ComboBoxEdit)c).SelectedIndex = -1; // veya .EditValue = null;
                }
                else if (c is PictureEdit)
                {
                    ((PictureEdit)c).Image = null;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = null;
                }
                // Eğer kontrol başka kontroller içeriyorsa, bu metodu rekürsif olarak çağır
                if (c.HasChildren)
                {
                    Clear(c);
                }
            }
        }
        void List()
        {
            var list = _bookService.TGetAll()
                .Include(b => b.Category)
                .Include(b => b.Author)
                .Include(b => b.PublishingHouse)
                .Select(b => new
                {
                    b.bookId,
                    b.bookName,
                    b.isbn,
                    b.releaseDate,
                    b.pageCount,
                    b.bookCode,
                    b.Category.categoryName,
                    b.Author.authorName,
                    b.PublishingHouse.publishingHouseName,
                    b.status
                })
                .Where(x => x.status != false).ToList();

            gridControl1.DataSource = list;
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryId = _categoryService.TGetAll(x => x.categoryName == cmbCategory.Text).Select(x => x.categoryId).FirstOrDefault();
        }
        string pictureLocation;
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            pictureLocation = pictureEdit1.GetLoadedImageLocation();
        }
        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            authorId = _authorService.TGetAll(x => x.authorName + " " + x.authorLastname == cmbAuthor.Text).Select(x => x.authorId).FirstOrDefault();
        }
        private void cmbPublishingHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            punlishingHouseId = _publishingHouseService.TGetAll(x => x.publishingHouseName == cmbPublishingHouse.Text).Select(x => x.publishinghouseId).FirstOrDefault();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            dynamic focusedRow = gridView1.GetFocusedRow();
            _id = focusedRow.bookId;
            var deger = _bookService.TGetAll(x => x.bookId == _id).FirstOrDefault();
            var author = _authorService.TGetAll(x => x.authorId == deger.authorId).FirstOrDefault();
            var category = _categoryService.TGetAll(x => x.categoryId == deger.categoryId).FirstOrDefault();
            var publishinghouse = _publishingHouseService.TGetAll(x => x.publishinghouseId == deger.publishingHouseId).FirstOrDefault();

            txtISBN.Text = deger.isbn;
            txtBookName.Text = deger.bookName;
            dEReleaseDate.Text = deger.releaseDate.ToShortDateString();
            txtPageCount.Text = deger.pageCount.ToString();
            txtDescription.Text = deger.description;
            txtBookCount.Text = deger.bookCount.ToString();
            cmbCategory.Text = category.categoryName;
            cmbAuthor.Text = author.authorName + " " + author.authorLastname;
            cmbPublishingHouse.Text = publishinghouse.publishingHouseName;

            btnSave.Text = "GÜNCELLE";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(this);
            btnSave.Text = "KAYDET";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = _bookService.TGetById(_id);
            if (XtraMessageBox.Show($"{book.bookName} adlı kitabı silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (book != null)
                {
                    book.status = false;
                    _bookService.TDelete(book);
                    List();
                    Clear(this);
                    XtraMessageBox.Show($"{book.bookName} adlı kitap silinmiştir?", "Başarılı?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { XtraMessageBox.Show($"Bir hata oluştu, Lütfen verilerinizi kontrol ediniz?", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "KAYDET")
            {
                Book book = new Book();
                book.bookCode = Guid.NewGuid();
                book.bookBarcode = txtISBN.Text;
                book.isbn = txtISBN.Text;
                book.bookName = txtBookName.Text;
                book.releaseDate = Convert.ToDateTime(dEReleaseDate.Text);
                book.pageCount = Convert.ToInt32(txtPageCount.Text);
                book.description = txtDescription.Text;
                book.bookCount = Convert.ToInt32(txtBookCount.Text);
                book.categoryId = categoryId;
                book.authorId = authorId;
                book.publishingHouseId = punlishingHouseId;
                string imageName = "yüklenmiş dosya yok";
                if (pictureLocation != null)
                {
                    string uploadDir = Path.Combine("D:\\images\\");
                    imageName = book.bookCode.ToString();
                    string filePath = Path.Combine(uploadDir, imageName + Path.GetExtension(pictureLocation));
                    File.Copy(pictureLocation, filePath, true);
                }
                book.bookPicture = imageName;
                book.status = true;

                _bookService.TCreate(book);
                Clear(this);
                List();
                XtraMessageBox.Show("Kitap Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnSave.Text == "GÜNCELLE")
            {
                Book book = _bookService.TGetById(_id);
                //book.bookCode = Guid.NewGuid();
                book.bookBarcode = txtISBN.Text;
                book.isbn = txtISBN.Text;
                book.bookName = txtBookName.Text;
                book.releaseDate = Convert.ToDateTime(dEReleaseDate.Text);
                book.pageCount = Convert.ToInt32(txtPageCount.Text);
                book.description = txtDescription.Text;
                book.bookCount = Convert.ToInt32(txtBookCount.Text);
                book.categoryId = categoryId;
                book.authorId = authorId;
                book.publishingHouseId = punlishingHouseId;
                string imageName = "yüklenmiş dosya yok";
                if (pictureLocation != null)
                {
                    string uploadDir = Path.Combine("D:\\images\\");
                    imageName = book.bookCode.ToString();
                    string filePath = Path.Combine(uploadDir, imageName + Path.GetExtension(pictureLocation));
                    File.Copy(pictureLocation, filePath, true);
                }
                book.bookPicture = imageName;
                book.status = true;

                _bookService.TUpdate(book);
                Clear(this);
                List();
                XtraMessageBox.Show("Kitap Başarıyla Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}