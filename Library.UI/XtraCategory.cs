using DevExpress.XtraEditors;
using Library.DataLayer.Repositories.Interfaces.EntityTypeRepository;
using Library.EntityLayer.Concrete;
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
    public partial class XtraCategory : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICategoryRepository _categoryRepository;
        int _id;
        public XtraCategory(ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
        }
        private void XtraCategory_Load(object sender, EventArgs e)
        {
            List();
        }
        void Clear()
        {
            txtCategoryName.Text = string.Empty;
            btnSave.Text = "KAYDET";
            btnClose.Text = "KAPAT";
        }
        void List()
        {
            var list = _categoryRepository.GetAll();
            gridControl1.DataSource = list.ToList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "VAZGEÇ")
            {
                Clear();
            }
            else
            {
                this.Close();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "KAYDET")
            {
                Category category = new Category();
                category.categoryName = txtCategoryName.Text;
                category.categoryCode = Guid.NewGuid();
                _categoryRepository.Create(category);
                Clear();
                List();
                XtraMessageBox.Show("Kategori Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var category = _categoryRepository.GetById(_id);
                category.categoryName = txtCategoryName.Text.ToUpper();
                _categoryRepository.Update(category);
                Clear();
                List();
                XtraMessageBox.Show("Kategori Başarıyla Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                _id = int.Parse((gridView1.GetRowCellValue(e.RowHandle, "categoryId")).ToString());
                var deger = _categoryRepository.GetById(_id);
                txtCategoryName.Text = deger.categoryName;
                btnSave.Text = "GÜNCELLE";
                btnClose.Text = "VAZGEÇ";
            }
        }
        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as Category).categoryName} Departmanını Silmek İstiyor Musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var category = (gridView1.GetFocusedRow() as Category);
                _categoryRepository.Delete(category);
                List();
            }
        }
    }
}