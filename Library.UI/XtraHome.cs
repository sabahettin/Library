using DevExpress.XtraEditors;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public partial class XtraHome : DevExpress.XtraEditors.XtraForm
    {
        ICategoryRepository _categoryRepository;

        public XtraHome(ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
        }

        private void btnDeposits_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraCategory category = new XtraCategory(_categoryRepository);
            //category.MdiParent = this;
            category.Show();
        }
    }
}