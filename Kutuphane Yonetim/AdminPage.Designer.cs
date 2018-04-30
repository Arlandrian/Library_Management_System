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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
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
            this.listViewProducts.Location = new System.Drawing.Point(155, 138);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.OwnerDraw = true;
            this.listViewProducts.Size = new System.Drawing.Size(643, 473);
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
            this.tip.Width = 122;
            // 
            // textboxSearch
            // 
            // 
            // 
            // 
            this.textboxSearch.CustomButton.Image = null;
            this.textboxSearch.CustomButton.Location = new System.Drawing.Point(467, 1);
            this.textboxSearch.CustomButton.Name = "";
            this.textboxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxSearch.CustomButton.TabIndex = 1;
            this.textboxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxSearch.CustomButton.UseSelectable = true;
            this.textboxSearch.CustomButton.Visible = false;
            this.textboxSearch.Lines = new string[0];
            this.textboxSearch.Location = new System.Drawing.Point(39, 90);
            this.textboxSearch.MaxLength = 32767;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.PasswordChar = '\0';
            this.textboxSearch.PromptText = "Search...";
            this.textboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSearch.SelectedText = "";
            this.textboxSearch.SelectionLength = 0;
            this.textboxSearch.SelectionStart = 0;
            this.textboxSearch.ShortcutsEnabled = true;
            this.textboxSearch.Size = new System.Drawing.Size(489, 23);
            this.textboxSearch.TabIndex = 1;
            this.textboxSearch.UseSelectable = true;
            this.textboxSearch.WaterMark = "Search...";
            this.textboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // backButton
            // 
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(39, 576);
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
            "Kitap",
            "Ders Kitabı",
            "Dergi",
            "DVD"});
            this.listBox1.Location = new System.Drawing.Point(12, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 173);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 657);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.listViewProducts);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

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
    }
}