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
            this.listViewProducts = new MetroFramework.Controls.MetroListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toplamAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anlık = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rezerve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.backButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoroiesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textboxName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new MetroFramework.Controls.MetroButton();
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
            this.listViewProducts.Size = new System.Drawing.Size(604, 488);
            this.listViewProducts.Style = MetroFramework.MetroColorStyle.Orange;
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.UseSelectable = true;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
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
            // 
            // backButton
            // 
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(38, 559);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = true;
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Kitap",
            "Ders Kitabı",
            "Dergi",
            "DVD"});
            this.listBox1.Location = new System.Drawing.Point(11, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 173);
            this.listBox1.TabIndex = 3;
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
            this.categoroiesLabel.Click += new System.EventHandler(this.categoroiesLabel_Click);
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(851, 168);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(148, 23);
            this.metroTextBox1.TabIndex = 12;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(910, 217);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(89, 23);
            this.metroTextBox2.TabIndex = 14;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(910, 269);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(89, 23);
            this.metroTextBox3.TabIndex = 16;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(910, 318);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(89, 23);
            this.metroTextBox4.TabIndex = 18;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.buttonUpdate.Location = new System.Drawing.Point(827, 360);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 23);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Rezervasyon Yap";
            this.buttonUpdate.UseSelectable = true;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.categoroiesLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.listViewProducts);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPage_FormClosing);
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
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel categoroiesLabel;
        private System.Windows.Forms.Label labelCategory;
        private MetroFramework.Controls.MetroTextBox textboxName;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton buttonUpdate;
    }
}