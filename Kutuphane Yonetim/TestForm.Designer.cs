namespace Kutuphane_Yonetim {
    partial class TestForm {
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
            this.textboxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
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
            this.textboxSearch.Location = new System.Drawing.Point(38, 85);
            this.textboxSearch.MaxLength = 32767;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.PasswordChar = '\0';
            this.textboxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxSearch.SelectedText = "";
            this.textboxSearch.SelectionLength = 0;
            this.textboxSearch.SelectionStart = 0;
            this.textboxSearch.ShortcutsEnabled = true;
            this.textboxSearch.Size = new System.Drawing.Size(434, 23);
            this.textboxSearch.TabIndex = 2;
            this.textboxSearch.UseSelectable = true;
            this.textboxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(65, 129);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(430, 330);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 531);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.textboxSearch);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textboxSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}