namespace Library.UI
{
    partial class XtraBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraBook));
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            cmbCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            btnDelete = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            txtBookCount = new DevExpress.XtraEditors.TextEdit();
            txtDescription = new RichTextBox();
            pEBookPicture = new DevExpress.XtraEditors.PictureEdit();
            txtPageCount = new DevExpress.XtraEditors.TextEdit();
            dEReleaseDate = new DevExpress.XtraEditors.DateEdit();
            txtBookName = new DevExpress.XtraEditors.TextEdit();
            txtISBN = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            cmbAuthor = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            cmbPublishingHouse = new DevExpress.XtraEditors.ComboBoxEdit();
            layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbCategory.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBookCount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pEBookPicture.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPageCount.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dEReleaseDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dEReleaseDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBookName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtISBN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbAuthor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPublishingHouse.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem13).BeginInit();
            SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(cmbPublishingHouse);
            layoutControl1.Controls.Add(cmbAuthor);
            layoutControl1.Controls.Add(cmbCategory);
            layoutControl1.Controls.Add(btnDelete);
            layoutControl1.Controls.Add(btnSave);
            layoutControl1.Controls.Add(txtBookCount);
            layoutControl1.Controls.Add(txtDescription);
            layoutControl1.Controls.Add(pEBookPicture);
            layoutControl1.Controls.Add(txtPageCount);
            layoutControl1.Controls.Add(dEReleaseDate);
            layoutControl1.Controls.Add(txtBookName);
            layoutControl1.Controls.Add(txtISBN);
            layoutControl1.Dock = DockStyle.Left;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(565, 223, 650, 400);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(323, 484);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // cmbCategory
            // 
            cmbCategory.Location = new Point(142, 12);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbCategory.Size = new Size(169, 20);
            cmbCategory.StyleController = layoutControl1;
            cmbCategory.TabIndex = 13;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnDelete.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Appearance.Options.UseBackColor = true;
            btnDelete.Appearance.Options.UseFont = true;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.Location = new Point(12, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(299, 22);
            btnDelete.StyleController = layoutControl1;
            btnDelete.TabIndex = 12;
            btnDelete.Text = "SİL";
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            btnSave.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Appearance.Options.UseFont = true;
            btnSave.ImageOptions.Image = (Image)resources.GetObject("btnSave.ImageOptions.Image");
            btnSave.Location = new Point(12, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(299, 22);
            btnSave.StyleController = layoutControl1;
            btnSave.TabIndex = 11;
            btnSave.Text = "KAYDET";
            btnSave.Click += btnSave_Click;
            // 
            // txtBookCount
            // 
            txtBookCount.Location = new Point(142, 355);
            txtBookCount.Name = "txtBookCount";
            txtBookCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            txtBookCount.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            txtBookCount.Properties.MaskSettings.Set("mask", "99999");
            txtBookCount.Size = new Size(169, 20);
            txtBookCount.StyleController = layoutControl1;
            txtBookCount.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(142, 248);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(169, 103);
            txtDescription.TabIndex = 9;
            txtDescription.Text = "";
            // 
            // pEBookPicture
            // 
            pEBookPicture.Location = new Point(142, 180);
            pEBookPicture.Name = "pEBookPicture";
            pEBookPicture.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pEBookPicture.Size = new Size(169, 64);
            pEBookPicture.StyleController = layoutControl1;
            pEBookPicture.TabIndex = 8;
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(142, 156);
            txtPageCount.Name = "txtPageCount";
            txtPageCount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            txtPageCount.Properties.MaskSettings.Set("mask", "\\d{0,5}");
            txtPageCount.Size = new Size(169, 20);
            txtPageCount.StyleController = layoutControl1;
            txtPageCount.TabIndex = 7;
            // 
            // dEReleaseDate
            // 
            dEReleaseDate.EditValue = null;
            dEReleaseDate.Location = new Point(142, 132);
            dEReleaseDate.Name = "dEReleaseDate";
            dEReleaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dEReleaseDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dEReleaseDate.Size = new Size(169, 20);
            dEReleaseDate.StyleController = layoutControl1;
            dEReleaseDate.TabIndex = 6;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(142, 108);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(169, 20);
            txtBookName.StyleController = layoutControl1;
            txtBookName.TabIndex = 5;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(142, 84);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(169, 20);
            txtISBN.StyleController = layoutControl1;
            txtISBN.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem2, emptySpaceItem1, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8, layoutControlItem9, layoutControlItem10, layoutControlItem11, layoutControlItem12, layoutControlItem13 });
            Root.Name = "Root";
            Root.Size = new Size(323, 484);
            Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem2.Control = txtISBN;
            layoutControlItem2.Location = new Point(0, 72);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(303, 24);
            layoutControlItem2.Text = "ISBN";
            layoutControlItem2.TextSize = new Size(118, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 419);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(303, 45);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem3.Control = txtBookName;
            layoutControlItem3.Location = new Point(0, 96);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(303, 24);
            layoutControlItem3.Text = "KİTAP ADI";
            layoutControlItem3.TextSize = new Size(118, 16);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem4.Control = dEReleaseDate;
            layoutControlItem4.Location = new Point(0, 120);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(303, 24);
            layoutControlItem4.Text = "YAYIN TARİHİ";
            layoutControlItem4.TextSize = new Size(118, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem5.Control = txtPageCount;
            layoutControlItem5.Location = new Point(0, 144);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(303, 24);
            layoutControlItem5.Text = "SAYFA SAYISI";
            layoutControlItem5.TextSize = new Size(118, 16);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem6.Control = pEBookPicture;
            layoutControlItem6.Location = new Point(0, 168);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(303, 68);
            layoutControlItem6.Text = "KAPAK FOTOĞRAFI";
            layoutControlItem6.TextSize = new Size(118, 16);
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem7.Control = txtDescription;
            layoutControlItem7.Location = new Point(0, 236);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new Size(303, 107);
            layoutControlItem7.Text = "ÖZET";
            layoutControlItem7.TextSize = new Size(118, 16);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem8.Control = txtBookCount;
            layoutControlItem8.Location = new Point(0, 343);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new Size(303, 24);
            layoutControlItem8.Text = "KİTAP SAYISI";
            layoutControlItem8.TextSize = new Size(118, 16);
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = btnSave;
            layoutControlItem9.Location = new Point(0, 367);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new Size(303, 26);
            layoutControlItem9.TextSize = new Size(0, 0);
            layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = btnDelete;
            layoutControlItem10.Location = new Point(0, 393);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new Size(303, 26);
            layoutControlItem10.TextSize = new Size(0, 0);
            layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            layoutControlItem11.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem11.Control = cmbCategory;
            layoutControlItem11.Location = new Point(0, 0);
            layoutControlItem11.Name = "layoutControlItem11";
            layoutControlItem11.Size = new Size(303, 24);
            layoutControlItem11.Text = "KATEGORİ";
            layoutControlItem11.TextSize = new Size(118, 16);
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(gridControl1);
            layoutControl2.Dock = DockStyle.Fill;
            layoutControl2.Location = new Point(323, 0);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new Size(654, 484);
            layoutControl2.TabIndex = 1;
            layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(630, 460);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(654, 484);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControl1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(634, 464);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // cmbAuthor
            // 
            cmbAuthor.Location = new Point(142, 36);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbAuthor.Size = new Size(169, 20);
            cmbAuthor.StyleController = layoutControl1;
            cmbAuthor.TabIndex = 14;
            // 
            // layoutControlItem12
            // 
            layoutControlItem12.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem12.Control = cmbAuthor;
            layoutControlItem12.Location = new Point(0, 24);
            layoutControlItem12.Name = "layoutControlItem12";
            layoutControlItem12.Size = new Size(303, 24);
            layoutControlItem12.Text = "YAZAR";
            layoutControlItem12.TextSize = new Size(118, 16);
            // 
            // cmbPublishingHouse
            // 
            cmbPublishingHouse.Location = new Point(142, 60);
            cmbPublishingHouse.Name = "cmbPublishingHouse";
            cmbPublishingHouse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbPublishingHouse.Size = new Size(169, 20);
            cmbPublishingHouse.StyleController = layoutControl1;
            cmbPublishingHouse.TabIndex = 15;
            // 
            // layoutControlItem13
            // 
            layoutControlItem13.AppearanceItemCaption.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem13.Control = cmbPublishingHouse;
            layoutControlItem13.Location = new Point(0, 48);
            layoutControlItem13.Name = "layoutControlItem13";
            layoutControlItem13.Size = new Size(303, 24);
            layoutControlItem13.Text = "YAYIN EVİ";
            layoutControlItem13.TextSize = new Size(118, 16);
            // 
            // XtraBook
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 484);
            Controls.Add(layoutControl2);
            Controls.Add(layoutControl1);
            Name = "XtraBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitaplar";
            Load += XtraBook_Load;
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbCategory.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBookCount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pEBookPicture.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPageCount.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dEReleaseDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dEReleaseDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBookName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtISBN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbAuthor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPublishingHouse.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PictureEdit pEBookPicture;
        private DevExpress.XtraEditors.TextEdit txtPageCount;
        private DevExpress.XtraEditors.DateEdit dEReleaseDate;
        private DevExpress.XtraEditors.TextEdit txtBookName;
        private DevExpress.XtraEditors.TextEdit txtISBN;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtBookCount;
        private RichTextBox txtDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPublishingHouse;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAuthor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
    }
}