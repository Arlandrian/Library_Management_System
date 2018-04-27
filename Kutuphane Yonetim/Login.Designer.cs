namespace Kutuphane_Yonetim {
    partial class Login {
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
            this.textboxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.registerButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxUsername
            // 
            this.textboxUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textboxUsername.Depth = 0;
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textboxUsername.Hint = "Username";
            this.textboxUsername.Location = new System.Drawing.Point(130, 155);
            this.textboxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.PasswordChar = '\0';
            this.textboxUsername.SelectedText = "";
            this.textboxUsername.SelectionLength = 0;
            this.textboxUsername.SelectionStart = 0;
            this.textboxUsername.Size = new System.Drawing.Size(235, 23);
            this.textboxUsername.TabIndex = 0;
            this.textboxUsername.UseSystemPasswordChar = false;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textboxPassword.Depth = 0;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textboxPassword.Hint = "Password";
            this.textboxPassword.Location = new System.Drawing.Point(130, 210);
            this.textboxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.Size = new System.Drawing.Size(235, 23);
            this.textboxPassword.TabIndex = 1;
            this.textboxPassword.UseSystemPasswordChar = false;
            this.textboxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxPassword_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.Depth = 0;
            this.loginButton.Location = new System.Drawing.Point(266, 271);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Primary = true;
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(58, 96);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(378, 35);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Library Management System";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            this.registerButton.Depth = 0;
            this.registerButton.Location = new System.Drawing.Point(154, 271);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Primary = true;
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Location = new System.Drawing.Point(-46, 63);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(583, 425);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 4;
            this.pictureBoxBG.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(494, 435);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.pictureBoxBG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textboxUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxPassword;
        private System.Windows.Forms.PictureBox pictureBoxBG;
        private MaterialSkin.Controls.MaterialRaisedButton loginButton;
        private System.Windows.Forms.Label labelTitle;
        private MaterialSkin.Controls.MaterialRaisedButton registerButton;
    }
}

