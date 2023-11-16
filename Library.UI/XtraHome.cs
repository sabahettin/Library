using Library.BusinessLayer.Abstract;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;

namespace Library.UI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        IAuthorService _authorService;
        IBookService _bookService;
        ICategoryService _categoryService;
        IEmailService _emailService;
        IMemberService _memberService;
        IPublishingHouseService _publishingHouseService;

        public XtraHome(IAuthorService authorService, IBookService bookService, ICategoryService categoryService, IEmailService emailService, IMemberService memberService, IPublishingHouseService publishingHouseService)
        {
            InitializeComponent();
            _authorService = authorService;
            _bookService = bookService;
            _categoryService = categoryService;
            _emailService = emailService;
            _memberService = memberService;
            _publishingHouseService = publishingHouseService;
        }

        private void btnDeposits_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategory category = new XtraCategory(_categoryService);
            //category.MdiParent = this;
            category.Show();
        }

        private void btnBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraBook book = new XtraBook(_categoryService,_bookService, _authorService, _publishingHouseService);
            book.MdiParent = this;
            book.Show();
        }

        private void XtraHome_Load(object sender, EventArgs e)
        {

        }
    }
}