namespace Kutuphane_Yonetim
{
    partial class UserPage
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
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.labelType = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRezervation = new MetroFramework.Controls.MetroButton();
            this.labelCategory = new System.Windows.Forms.Label();
            this.categoroiesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.listViewProducts = new MetroFramework.Controls.MetroListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toplamAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anlık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezerve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonCancelRez = new MetroFramework.Controls.MetroButton();
            this.listViewMyBooks = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSurname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.buttonUpdateInfos = new MetroFramework.Controls.MetroButton();
            this.labelKisiName = new MetroFramework.Controls.MetroLabel();
            this.labelBakiye = new MaterialSkin.Controls.MaterialLabel();
            this.labelWelcome = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::Kutuphane_Yonetim.Properties.Resources.logout_512x512;
            this.pictureBoxExit.Location = new System.Drawing.Point(972, 25);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(46, 51);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 22;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Controls.Add(this.metroTabPage3);
            this.metroTabControl.Location = new System.Drawing.Point(9, 63);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1009, 628);
            this.metroTabControl.TabIndex = 23;
            this.metroTabControl.TabStop = false;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.labelType);
            this.metroTabPage1.Controls.Add(this.labelName);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.buttonRezervation);
            this.metroTabPage1.Controls.Add(this.labelCategory);
            this.metroTabPage1.Controls.Add(this.categoroiesLabel);
            this.metroTabPage1.Controls.Add(this.listBox1);
            this.metroTabPage1.Controls.Add(this.textboxSearch);
            this.metroTabPage1.Controls.Add(this.listViewProducts);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1001, 586);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Kitap Rezervasyon";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(859, 129);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(16, 22);
            this.labelType.TabIndex = 38;
            this.labelType.Text = "-";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(857, 81);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(16, 22);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ürün Tipi:";
            // 
            // buttonRezervation
            // 
            this.buttonRezervation.Location = new System.Drawing.Point(814, 183);
            this.buttonRezervation.Name = "buttonRezervation";
            this.buttonRezervation.Size = new System.Drawing.Size(113, 23);
            this.buttonRezervation.TabIndex = 36;
            this.buttonRezervation.Text = "Rezervasyon Yap";
            this.buttonRezervation.UseSelectable = true;
            this.buttonRezervation.Click += new System.EventHandler(this.buttonRezervation_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(770, 81);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 22);
            this.labelCategory.TabIndex = 26;
            this.labelCategory.Text = "Ürün İsmi:";
            // 
            // categoroiesLabel
            // 
            this.categoroiesLabel.AutoSize = true;
            this.categoroiesLabel.Depth = 0;
            this.categoroiesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.categoroiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoroiesLabel.Location = new System.Drawing.Point(8, 81);
            this.categoroiesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoroiesLabel.Name = "categoroiesLabel";
            this.categoroiesLabel.Size = new System.Drawing.Size(82, 19);
            this.categoroiesLabel.TabIndex = 25;
            this.categoroiesLabel.Text = "Kategoriler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tüm",
            "Kitap",
            "Ders Kitabı",
            "Dergi",
            "DVD"});
            this.listBox1.Location = new System.Drawing.Point(8, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 173);
            this.listBox1.TabIndex = 24;
            // 
            // textboxSearch
            // 
            // 
            // 
            // 
            this.textboxSearch.CustomButton.Image = null;
            this.textboxSearch.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.textboxSearch.CustomButton.Name = "";
            this.textboxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxSearch.CustomButton.TabIndex = 1;
            this.textboxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxSearch.CustomButton.UseSelectable = true;
            this.textboxSearch.CustomButton.Visible = false;
            this.textboxSearch.Lines = new string[0];
            this.textboxSearch.Location = new System.Drawing.Point(8, 39);
            this.textboxSearch.MaxLength = 32767;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.PasswordChar = '\0';
            this.textboxSearch.PromptText = "Search...";
            this.textboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSearch.SelectedText = "";
            this.textboxSearch.SelectionLength = 0;
            this.textboxSearch.SelectionStart = 0;
            this.textboxSearch.ShortcutsEnabled = true;
            this.textboxSearch.Size = new System.Drawing.Size(434, 23);
            this.textboxSearch.TabIndex = 23;
            this.textboxSearch.UseSelectable = true;
            this.textboxSearch.WaterMark = "Search...";
            this.textboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.isim,
            this.toplamAdet,
            this.anlık,
            this.rezerve,
            this.tip});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(151, 81);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.OwnerDraw = true;
            this.listViewProducts.Size = new System.Drawing.Size(604, 488);
            this.listViewProducts.Style = MetroFramework.MetroColorStyle.Green;
            this.listViewProducts.TabIndex = 22;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.UseSelectable = true;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // isim
            // 
            this.isim.Text = "İsim";
            this.isim.Width = 140;
            // 
            // toplamAdet
            // 
            this.toplamAdet.Text = "Toplam Adet";
            this.toplamAdet.Width = 99;
            // 
            // anlık
            // 
            this.anlık.Text = "Anlık Adet";
            this.anlık.Width = 89;
            // 
            // rezerve
            // 
            this.rezerve.Text = "Rezerve adet";
            this.rezerve.Width = 102;
            // 
            // tip
            // 
            this.tip.Text = "Tip";
            this.tip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tip.Width = 122;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonCancelRez);
            this.metroTabPage2.Controls.Add(this.listViewMyBooks);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1001, 586);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Aldığım Kitaplar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // buttonCancelRez
            // 
            this.buttonCancelRez.Location = new System.Drawing.Point(674, 244);
            this.buttonCancelRez.Name = "buttonCancelRez";
            this.buttonCancelRez.Size = new System.Drawing.Size(140, 32);
            this.buttonCancelRez.TabIndex = 4;
            this.buttonCancelRez.Text = "Rezervasyonu iptal Et";
            this.buttonCancelRez.UseSelectable = true;
            this.buttonCancelRez.Click += new System.EventHandler(this.buttonCancelRez_Click);
            // 
            // listViewMyBooks
            // 
            this.listViewMyBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMyBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewMyBooks.FullRowSelect = true;
            this.listViewMyBooks.GridLines = true;
            this.listViewMyBooks.Location = new System.Drawing.Point(31, 32);
            this.listViewMyBooks.Name = "listViewMyBooks";
            this.listViewMyBooks.OwnerDraw = true;
            this.listViewMyBooks.Size = new System.Drawing.Size(589, 513);
            this.listViewMyBooks.TabIndex = 2;
            this.listViewMyBooks.UseCompatibleStateImageBehavior = false;
            this.listViewMyBooks.UseSelectable = true;
            this.listViewMyBooks.View = System.Windows.Forms.View.Details;
            this.listViewMyBooks.SelectedIndexChanged += new System.EventHandler(this.listViewMyBooks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rezervasyon Mu";
            this.columnHeader4.Width = 124;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.txtPass);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.txtEmail);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.txtSurname);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.txtName);
            this.metroTabPage3.Controls.Add(this.buttonUpdateInfos);
            this.metroTabPage3.Controls.Add(this.labelKisiName);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1001, 586);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Bilgilerim";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(153, 228);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(223, 23);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(43, 232);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Şifre :";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(153, 178);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(223, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 182);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "E-Posta :";
            // 
            // txtSurname
            // 
            // 
            // 
            // 
            this.txtSurname.CustomButton.Image = null;
            this.txtSurname.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtSurname.CustomButton.Name = "";
            this.txtSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSurname.CustomButton.TabIndex = 1;
            this.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSurname.CustomButton.UseSelectable = true;
            this.txtSurname.CustomButton.Visible = false;
            this.txtSurname.Lines = new string[0];
            this.txtSurname.Location = new System.Drawing.Point(153, 128);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSurname.SelectedText = "";
            this.txtSurname.SelectionLength = 0;
            this.txtSurname.SelectionStart = 0;
            this.txtSurname.ShortcutsEnabled = true;
            this.txtSurname.Size = new System.Drawing.Size(223, 23);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.UseSelectable = true;
            this.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Soyisim :";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(153, 78);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(223, 23);
            this.txtName.TabIndex = 4;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonUpdateInfos
            // 
            this.buttonUpdateInfos.Location = new System.Drawing.Point(224, 291);
            this.buttonUpdateInfos.Name = "buttonUpdateInfos";
            this.buttonUpdateInfos.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateInfos.TabIndex = 3;
            this.buttonUpdateInfos.Text = "Güncelle";
            this.buttonUpdateInfos.UseSelectable = true;
            this.buttonUpdateInfos.Click += new System.EventHandler(this.buttonUpdateInfos_Click);
            // 
            // labelKisiName
            // 
            this.labelKisiName.AutoSize = true;
            this.labelKisiName.Location = new System.Drawing.Point(43, 82);
            this.labelKisiName.Name = "labelKisiName";
            this.labelKisiName.Size = new System.Drawing.Size(39, 19);
            this.labelKisiName.TabIndex = 2;
            this.labelKisiName.Text = "İsim :";
            // 
            // labelBakiye
            // 
            this.labelBakiye.AutoSize = true;
            this.labelBakiye.Depth = 0;
            this.labelBakiye.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBakiye.Location = new System.Drawing.Point(823, 41);
            this.labelBakiye.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBakiye.Name = "labelBakiye";
            this.labelBakiye.Size = new System.Drawing.Size(65, 19);
            this.labelBakiye.TabIndex = 38;
            this.labelBakiye.Text = "Bakiye : ";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Depth = 0;
            this.labelWelcome.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWelcome.Location = new System.Drawing.Point(391, 41);
            this.labelWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(87, 19);
            this.labelWelcome.TabIndex = 38;
            this.labelWelcome.Text = "Hoş Geldin ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 702);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.labelBakiye);
            this.Controls.Add(this.labelWelcome);
            this.Name = "UserPage";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "UserPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton buttonRezervation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCategory;
        private MaterialSkin.Controls.MaterialLabel categoroiesLabel;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox textboxSearch;
        private MetroFramework.Controls.MetroListView listViewProducts;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader toplamAdet;
        private System.Windows.Forms.ColumnHeader anlık;
        private System.Windows.Forms.ColumnHeader rezerve;
        private System.Windows.Forms.ColumnHeader tip;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MaterialSkin.Controls.MaterialLabel labelBakiye;
        private MaterialSkin.Controls.MaterialLabel labelWelcome;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroButton buttonUpdateInfos;
        private MetroFramework.Controls.MetroLabel labelKisiName;
        private MetroFramework.Controls.MetroListView listViewMyBooks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelName;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSurname;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroButton buttonCancelRez;
    }
}