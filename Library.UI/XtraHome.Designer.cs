namespace Library.UI
{
    partial class XtraHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraHome));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnDashboard = new DevExpress.XtraBars.BarButtonItem();
            btnCategories = new DevExpress.XtraBars.BarButtonItem();
            btnBooks = new DevExpress.XtraBars.BarButtonItem();
            btnAuthors = new DevExpress.XtraBars.BarButtonItem();
            btnPublishingHouses = new DevExpress.XtraBars.BarButtonItem();
            btnMembers = new DevExpress.XtraBars.BarButtonItem();
            btnDeposits = new DevExpress.XtraBars.BarButtonItem();
            btnEmailSettings = new DevExpress.XtraBars.BarButtonItem();
            btnSmsSettings = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, btnDashboard, btnCategories, btnBooks, btnAuthors, btnPublishingHouses, btnMembers, btnDeposits, btnEmailSettings, btnSmsSettings });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 10;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1198, 150);
            // 
            // btnDashboard
            // 
            btnDashboard.Caption = "Dashboard";
            btnDashboard.Id = 1;
            btnDashboard.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDashboard.ImageOptions.SvgImage");
            btnDashboard.Name = "btnDashboard";
            // 
            // btnCategories
            // 
            btnCategories.Caption = "Categories";
            btnCategories.Id = 2;
            btnCategories.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            btnCategories.Name = "btnCategories";
            btnCategories.ItemClick += btnCategories_ItemClick;
            // 
            // btnBooks
            // 
            btnBooks.Caption = "Books";
            btnBooks.Id = 3;
            btnBooks.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            btnBooks.Name = "btnBooks";
            // 
            // btnAuthors
            // 
            btnAuthors.Caption = "Authors";
            btnAuthors.Id = 4;
            btnAuthors.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("A.ImageOptions.SvgImage");
            btnAuthors.Name = "btnAuthors";
            // 
            // btnPublishingHouses
            // 
            btnPublishingHouses.Caption = "Publishing Houses";
            btnPublishingHouses.Id = 5;
            btnPublishingHouses.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem3.ImageOptions.SvgImage");
            btnPublishingHouses.Name = "btnPublishingHouses";
            // 
            // btnMembers
            // 
            btnMembers.Caption = "Members";
            btnMembers.Id = 6;
            btnMembers.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("D.ImageOptions.SvgImage");
            btnMembers.Name = "btnMembers";
            // 
            // btnDeposits
            // 
            btnDeposits.Caption = "Deposits";
            btnDeposits.Id = 7;
            btnDeposits.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem4.ImageOptions.SvgImage");
            btnDeposits.Name = "btnDeposits";
            btnDeposits.ItemClick += btnDeposits_ItemClick;
            // 
            // btnEmailSettings
            // 
            btnEmailSettings.Caption = "E-mail Settings";
            btnEmailSettings.Id = 8;
            btnEmailSettings.ImageOptions.Image = (Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            btnEmailSettings.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            btnEmailSettings.Name = "btnEmailSettings";
            // 
            // btnSmsSettings
            // 
            btnSmsSettings.Caption = "Sms Settings";
            btnSmsSettings.Id = 9;
            btnSmsSettings.ImageOptions.Image = (Image)resources.GetObject("barButtonItem6.ImageOptions.Image");
            btnSmsSettings.ImageOptions.LargeImage = (Image)resources.GetObject("barButtonItem6.ImageOptions.LargeImage");
            btnSmsSettings.Name = "btnSmsSettings";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup4, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup5 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnDashboard);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnDeposits, true);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnCategories);
            ribbonPageGroup2.ItemLinks.Add(btnBooks);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnMembers);
            ribbonPageGroup3.ItemLinks.Add(btnAuthors);
            ribbonPageGroup3.ItemLinks.Add(btnPublishingHouses);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(btnEmailSettings);
            ribbonPageGroup5.ItemLinks.Add(btnSmsSettings);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // XtraHome
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 868);
            Controls.Add(ribbonControl1);
            IsMdiContainer = true;
            Name = "XtraHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library System";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDashboard;
        private DevExpress.XtraBars.BarButtonItem btnCategories;
        private DevExpress.XtraBars.BarButtonItem btnBooks;
        private DevExpress.XtraBars.BarButtonItem btnAuthors;
        private DevExpress.XtraBars.BarButtonItem btnPublishingHouses;
        private DevExpress.XtraBars.BarButtonItem btnMembers;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDeposits;
        private DevExpress.XtraBars.BarButtonItem btnEmailSettings;
        private DevExpress.XtraBars.BarButtonItem btnSmsSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}