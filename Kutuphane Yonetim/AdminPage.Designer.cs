namespace Kutuphane_Yonetim {
    partial class AdminPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listViewProducts = new MetroFramework.Controls.MetroListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toplamAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anlık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezerve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.backButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoroiesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textboxName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxToplamAdet = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxAnlıkAdet = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxRezerveAdet = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new MetroFramework.Controls.MetroButton();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciKitap = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciSure = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgretimSure = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOgretimKitap = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemurSure = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemurKitap = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.listViewProducts.Location = new System.Drawing.Point(154, 121);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.OwnerDraw = true;
            this.listViewProducts.Size = new System.Drawing.Size(604, 503);
            this.listViewProducts.Style = MetroFramework.MetroColorStyle.Orange;
            this.listViewProducts.TabIndex = 0;
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
            this.textboxSearch.Location = new System.Drawing.Point(11, 79);
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
            this.textboxSearch.TabIndex = 1;
            this.textboxSearch.UseSelectable = true;
            this.textboxSearch.WaterMark = "Search...";
            this.textboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxSearch_KeyDown);
            // 
            // backButton
            // 
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(37, 620);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = true;
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tüm",
            "Kitap",
            "Ders Kitabi",
            "Dergi",
            "DVD"});
            this.listBox1.Location = new System.Drawing.Point(11, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 173);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // categoroiesLabel
            // 
            this.categoroiesLabel.AutoSize = true;
            this.categoroiesLabel.Depth = 0;
            this.categoroiesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.categoroiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoroiesLabel.Location = new System.Drawing.Point(11, 121);
            this.categoroiesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoroiesLabel.Name = "categoroiesLabel";
            this.categoroiesLabel.Size = new System.Drawing.Size(82, 19);
            this.categoroiesLabel.TabIndex = 4;
            this.categoroiesLabel.Text = "Kategoriler";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(764, 121);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(81, 22);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Ürün İsmi:";
            // 
            // textboxName
            // 
            // 
            // 
            // 
            this.textboxName.CustomButton.Image = null;
            this.textboxName.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.textboxName.CustomButton.Name = "";
            this.textboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxName.CustomButton.TabIndex = 1;
            this.textboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxName.CustomButton.UseSelectable = true;
            this.textboxName.CustomButton.Visible = false;
            this.textboxName.Lines = new string[0];
            this.textboxName.Location = new System.Drawing.Point(851, 121);
            this.textboxName.MaxLength = 32767;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.ShortcutsEnabled = true;
            this.textboxName.Size = new System.Drawing.Size(148, 23);
            this.textboxName.TabIndex = 10;
            this.textboxName.UseSelectable = true;
            this.textboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(764, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ürün Tipi:";
            // 
            // textboxToplamAdet
            // 
            // 
            // 
            // 
            this.textboxToplamAdet.CustomButton.Image = null;
            this.textboxToplamAdet.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.textboxToplamAdet.CustomButton.Name = "";
            this.textboxToplamAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxToplamAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxToplamAdet.CustomButton.TabIndex = 1;
            this.textboxToplamAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxToplamAdet.CustomButton.UseSelectable = true;
            this.textboxToplamAdet.CustomButton.Visible = false;
            this.textboxToplamAdet.Lines = new string[0];
            this.textboxToplamAdet.Location = new System.Drawing.Point(910, 217);
            this.textboxToplamAdet.MaxLength = 32767;
            this.textboxToplamAdet.Name = "textboxToplamAdet";
            this.textboxToplamAdet.PasswordChar = '\0';
            this.textboxToplamAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxToplamAdet.SelectedText = "";
            this.textboxToplamAdet.SelectionLength = 0;
            this.textboxToplamAdet.SelectionStart = 0;
            this.textboxToplamAdet.ShortcutsEnabled = true;
            this.textboxToplamAdet.Size = new System.Drawing.Size(89, 23);
            this.textboxToplamAdet.TabIndex = 14;
            this.textboxToplamAdet.UseSelectable = true;
            this.textboxToplamAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxToplamAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün Toplam Adet:";
            // 
            // textboxAnlıkAdet
            // 
            // 
            // 
            // 
            this.textboxAnlıkAdet.CustomButton.Image = null;
            this.textboxAnlıkAdet.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.textboxAnlıkAdet.CustomButton.Name = "";
            this.textboxAnlıkAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxAnlıkAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxAnlıkAdet.CustomButton.TabIndex = 1;
            this.textboxAnlıkAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxAnlıkAdet.CustomButton.UseSelectable = true;
            this.textboxAnlıkAdet.CustomButton.Visible = false;
            this.textboxAnlıkAdet.Lines = new string[0];
            this.textboxAnlıkAdet.Location = new System.Drawing.Point(910, 269);
            this.textboxAnlıkAdet.MaxLength = 32767;
            this.textboxAnlıkAdet.Name = "textboxAnlıkAdet";
            this.textboxAnlıkAdet.PasswordChar = '\0';
            this.textboxAnlıkAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxAnlıkAdet.SelectedText = "";
            this.textboxAnlıkAdet.SelectionLength = 0;
            this.textboxAnlıkAdet.SelectionStart = 0;
            this.textboxAnlıkAdet.ShortcutsEnabled = true;
            this.textboxAnlıkAdet.Size = new System.Drawing.Size(89, 23);
            this.textboxAnlıkAdet.TabIndex = 16;
            this.textboxAnlıkAdet.UseSelectable = true;
            this.textboxAnlıkAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxAnlıkAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ürün Anlık Adet:";
            // 
            // textboxRezerveAdet
            // 
            // 
            // 
            // 
            this.textboxRezerveAdet.CustomButton.Image = null;
            this.textboxRezerveAdet.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.textboxRezerveAdet.CustomButton.Name = "";
            this.textboxRezerveAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxRezerveAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxRezerveAdet.CustomButton.TabIndex = 1;
            this.textboxRezerveAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxRezerveAdet.CustomButton.UseSelectable = true;
            this.textboxRezerveAdet.CustomButton.Visible = false;
            this.textboxRezerveAdet.Lines = new string[0];
            this.textboxRezerveAdet.Location = new System.Drawing.Point(910, 318);
            this.textboxRezerveAdet.MaxLength = 32767;
            this.textboxRezerveAdet.Name = "textboxRezerveAdet";
            this.textboxRezerveAdet.PasswordChar = '\0';
            this.textboxRezerveAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxRezerveAdet.SelectedText = "";
            this.textboxRezerveAdet.SelectionLength = 0;
            this.textboxRezerveAdet.SelectionStart = 0;
            this.textboxRezerveAdet.ShortcutsEnabled = true;
            this.textboxRezerveAdet.Size = new System.Drawing.Size(89, 23);
            this.textboxRezerveAdet.TabIndex = 18;
            this.textboxRezerveAdet.UseSelectable = true;
            this.textboxRezerveAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxRezerveAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(764, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ürün Rezerve Adet:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(908, 362);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Güncelle";
            this.buttonUpdate.UseSelectable = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.FormattingEnabled = true;
            this.comboboxCategory.Items.AddRange(new object[] {
            "Kitap",
            "Ders Kitabi",
            "Dergi",
            "DVD"});
            this.comboboxCategory.Location = new System.Drawing.Point(851, 171);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(148, 21);
            this.comboboxCategory.TabIndex = 20;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(794, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Ekle";
            this.buttonAdd.UseSelectable = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOgrenciSure);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOgrenciKitap);
            this.groupBox1.Location = new System.Drawing.Point(768, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 83);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtOgrenciKitap
            // 
            // 
            // 
            // 
            this.txtOgrenciKitap.CustomButton.Image = null;
            this.txtOgrenciKitap.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtOgrenciKitap.CustomButton.Name = "";
            this.txtOgrenciKitap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOgrenciKitap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOgrenciKitap.CustomButton.TabIndex = 1;
            this.txtOgrenciKitap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOgrenciKitap.CustomButton.UseSelectable = true;
            this.txtOgrenciKitap.CustomButton.Visible = false;
            this.txtOgrenciKitap.Lines = new string[0];
            this.txtOgrenciKitap.Location = new System.Drawing.Point(140, 19);
            this.txtOgrenciKitap.MaxLength = 32767;
            this.txtOgrenciKitap.Name = "txtOgrenciKitap";
            this.txtOgrenciKitap.PasswordChar = '\0';
            this.txtOgrenciKitap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOgrenciKitap.SelectedText = "";
            this.txtOgrenciKitap.SelectionLength = 0;
            this.txtOgrenciKitap.SelectionStart = 0;
            this.txtOgrenciKitap.ShortcutsEnabled = true;
            this.txtOgrenciKitap.Size = new System.Drawing.Size(91, 23);
            this.txtOgrenciKitap.TabIndex = 15;
            this.txtOgrenciKitap.UseSelectable = true;
            this.txtOgrenciKitap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOgrenciKitap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kitap Sınırı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Süre Sınırı:";
            // 
            // txtOgrenciSure
            // 
            // 
            // 
            // 
            this.txtOgrenciSure.CustomButton.Image = null;
            this.txtOgrenciSure.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtOgrenciSure.CustomButton.Name = "";
            this.txtOgrenciSure.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOgrenciSure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOgrenciSure.CustomButton.TabIndex = 1;
            this.txtOgrenciSure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOgrenciSure.CustomButton.UseSelectable = true;
            this.txtOgrenciSure.CustomButton.Visible = false;
            this.txtOgrenciSure.Lines = new string[0];
            this.txtOgrenciSure.Location = new System.Drawing.Point(140, 51);
            this.txtOgrenciSure.MaxLength = 32767;
            this.txtOgrenciSure.Name = "txtOgrenciSure";
            this.txtOgrenciSure.PasswordChar = '\0';
            this.txtOgrenciSure.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOgrenciSure.SelectedText = "";
            this.txtOgrenciSure.SelectionLength = 0;
            this.txtOgrenciSure.SelectionStart = 0;
            this.txtOgrenciSure.ShortcutsEnabled = true;
            this.txtOgrenciSure.Size = new System.Drawing.Size(60, 23);
            this.txtOgrenciSure.TabIndex = 24;
            this.txtOgrenciSure.UseSelectable = true;
            this.txtOgrenciSure.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOgrenciSure.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOgretimSure);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtOgretimKitap);
            this.groupBox2.Location = new System.Drawing.Point(768, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 83);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğretim Üyesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Süre Sınırı:";
            // 
            // txtOgretimSure
            // 
            // 
            // 
            // 
            this.txtOgretimSure.CustomButton.Image = null;
            this.txtOgretimSure.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtOgretimSure.CustomButton.Name = "";
            this.txtOgretimSure.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOgretimSure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOgretimSure.CustomButton.TabIndex = 1;
            this.txtOgretimSure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOgretimSure.CustomButton.UseSelectable = true;
            this.txtOgretimSure.CustomButton.Visible = false;
            this.txtOgretimSure.Lines = new string[0];
            this.txtOgretimSure.Location = new System.Drawing.Point(140, 51);
            this.txtOgretimSure.MaxLength = 32767;
            this.txtOgretimSure.Name = "txtOgretimSure";
            this.txtOgretimSure.PasswordChar = '\0';
            this.txtOgretimSure.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOgretimSure.SelectedText = "";
            this.txtOgretimSure.SelectionLength = 0;
            this.txtOgretimSure.SelectionStart = 0;
            this.txtOgretimSure.ShortcutsEnabled = true;
            this.txtOgretimSure.Size = new System.Drawing.Size(60, 23);
            this.txtOgretimSure.TabIndex = 24;
            this.txtOgretimSure.UseSelectable = true;
            this.txtOgretimSure.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOgretimSure.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kitap Sınırı:";
            // 
            // txtOgretimKitap
            // 
            // 
            // 
            // 
            this.txtOgretimKitap.CustomButton.Image = null;
            this.txtOgretimKitap.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtOgretimKitap.CustomButton.Name = "";
            this.txtOgretimKitap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOgretimKitap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOgretimKitap.CustomButton.TabIndex = 1;
            this.txtOgretimKitap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOgretimKitap.CustomButton.UseSelectable = true;
            this.txtOgretimKitap.CustomButton.Visible = false;
            this.txtOgretimKitap.Lines = new string[0];
            this.txtOgretimKitap.Location = new System.Drawing.Point(140, 19);
            this.txtOgretimKitap.MaxLength = 32767;
            this.txtOgretimKitap.Name = "txtOgretimKitap";
            this.txtOgretimKitap.PasswordChar = '\0';
            this.txtOgretimKitap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOgretimKitap.SelectedText = "";
            this.txtOgretimKitap.SelectionLength = 0;
            this.txtOgretimKitap.SelectionStart = 0;
            this.txtOgretimKitap.ShortcutsEnabled = true;
            this.txtOgretimKitap.Size = new System.Drawing.Size(91, 23);
            this.txtOgretimKitap.TabIndex = 15;
            this.txtOgretimKitap.UseSelectable = true;
            this.txtOgretimKitap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOgretimKitap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtMemurSure);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMemurKitap);
            this.groupBox3.Location = new System.Drawing.Point(768, 582);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 83);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Süre Sınırı:";
            // 
            // txtMemurSure
            // 
            // 
            // 
            // 
            this.txtMemurSure.CustomButton.Image = null;
            this.txtMemurSure.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtMemurSure.CustomButton.Name = "";
            this.txtMemurSure.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMemurSure.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemurSure.CustomButton.TabIndex = 1;
            this.txtMemurSure.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemurSure.CustomButton.UseSelectable = true;
            this.txtMemurSure.CustomButton.Visible = false;
            this.txtMemurSure.Lines = new string[0];
            this.txtMemurSure.Location = new System.Drawing.Point(140, 51);
            this.txtMemurSure.MaxLength = 32767;
            this.txtMemurSure.Name = "txtMemurSure";
            this.txtMemurSure.PasswordChar = '\0';
            this.txtMemurSure.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemurSure.SelectedText = "";
            this.txtMemurSure.SelectionLength = 0;
            this.txtMemurSure.SelectionStart = 0;
            this.txtMemurSure.ShortcutsEnabled = true;
            this.txtMemurSure.Size = new System.Drawing.Size(60, 23);
            this.txtMemurSure.TabIndex = 24;
            this.txtMemurSure.UseSelectable = true;
            this.txtMemurSure.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemurSure.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Kitap Sınırı:";
            // 
            // txtMemurKitap
            // 
            // 
            // 
            // 
            this.txtMemurKitap.CustomButton.Image = null;
            this.txtMemurKitap.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.txtMemurKitap.CustomButton.Name = "";
            this.txtMemurKitap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMemurKitap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMemurKitap.CustomButton.TabIndex = 1;
            this.txtMemurKitap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMemurKitap.CustomButton.UseSelectable = true;
            this.txtMemurKitap.CustomButton.Visible = false;
            this.txtMemurKitap.Lines = new string[0];
            this.txtMemurKitap.Location = new System.Drawing.Point(140, 19);
            this.txtMemurKitap.MaxLength = 32767;
            this.txtMemurKitap.Name = "txtMemurKitap";
            this.txtMemurKitap.PasswordChar = '\0';
            this.txtMemurKitap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMemurKitap.SelectedText = "";
            this.txtMemurKitap.SelectionLength = 0;
            this.txtMemurKitap.SelectionStart = 0;
            this.txtMemurKitap.ShortcutsEnabled = true;
            this.txtMemurKitap.Size = new System.Drawing.Size(91, 23);
            this.txtMemurKitap.TabIndex = 15;
            this.txtMemurKitap.UseSelectable = true;
            this.txtMemurKitap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMemurKitap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Gün";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 22);
            this.label12.TabIndex = 27;
            this.label12.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(201, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 22);
            this.label13.TabIndex = 28;
            this.label13.Text = "Gün";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(621, 628);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(137, 35);
            this.materialRaisedButton1.TabIndex = 28;
            this.materialRaisedButton1.Text = "Sınırları  Güncelle";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 667);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboboxCategory);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textboxRezerveAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxAnlıkAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxToplamAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.categoroiesLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.listViewProducts);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewProducts;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader isim;
        private System.Windows.Forms.ColumnHeader toplamAdet;
        private System.Windows.Forms.ColumnHeader anlık;
        private System.Windows.Forms.ColumnHeader rezerve;
        private MetroFramework.Controls.MetroTextBox textboxSearch;
        private System.Windows.Forms.ColumnHeader tip;
        private MaterialSkin.Controls.MaterialRaisedButton backButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel categoroiesLabel;
        private System.Windows.Forms.Label labelCategory;
        private MetroFramework.Controls.MetroTextBox textboxName;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox textboxToplamAdet;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox textboxAnlıkAdet;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox textboxRezerveAdet;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton buttonUpdate;
        private System.Windows.Forms.ComboBox comboboxCategory;
        private MetroFramework.Controls.MetroButton buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtOgrenciSure;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtOgrenciKitap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtOgretimSure;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtOgretimKitap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroTextBox txtMemurSure;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtMemurKitap;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}