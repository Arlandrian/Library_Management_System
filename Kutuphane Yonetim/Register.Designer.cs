namespace Kutuphane_Yonetim {
    partial class Register {
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
            this.textboxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxLastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.registerButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelRegister = new System.Windows.Forms.Label();
            this.cancelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // textboxEmail
            // 
            this.textboxEmail.Depth = 0;
            this.textboxEmail.Hint = "E-Mail";
            this.textboxEmail.Location = new System.Drawing.Point(44, 159);
            this.textboxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.PasswordChar = '\0';
            this.textboxEmail.SelectedText = "";
            this.textboxEmail.SelectionLength = 0;
            this.textboxEmail.SelectionStart = 0;
            this.textboxEmail.Size = new System.Drawing.Size(330, 23);
            this.textboxEmail.TabIndex = 0;
            this.textboxEmail.UseSystemPasswordChar = false;
            // 
            // textboxName
            // 
            this.textboxName.Depth = 0;
            this.textboxName.Hint = "Name";
            this.textboxName.Location = new System.Drawing.Point(44, 222);
            this.textboxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.Size = new System.Drawing.Size(330, 23);
            this.textboxName.TabIndex = 1;
            this.textboxName.UseSystemPasswordChar = false;
            // 
            // textboxLastname
            // 
            this.textboxLastname.Depth = 0;
            this.textboxLastname.Hint = "Last Name";
            this.textboxLastname.Location = new System.Drawing.Point(44, 285);
            this.textboxLastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxLastname.Name = "textboxLastname";
            this.textboxLastname.PasswordChar = '\0';
            this.textboxLastname.SelectedText = "";
            this.textboxLastname.SelectionLength = 0;
            this.textboxLastname.SelectionStart = 0;
            this.textboxLastname.Size = new System.Drawing.Size(330, 23);
            this.textboxLastname.TabIndex = 2;
            this.textboxLastname.UseSystemPasswordChar = false;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Depth = 0;
            this.textboxPassword.Hint = "Password";
            this.textboxPassword.Location = new System.Drawing.Point(44, 348);
            this.textboxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.Size = new System.Drawing.Size(330, 23);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.UseSystemPasswordChar = false;
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Depth = 0;
            this.registerButton.Location = new System.Drawing.Point(172, 408);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Primary = false;
            this.registerButton.Size = new System.Drawing.Size(74, 36);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(37, 83);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(144, 42);
            this.labelRegister.TabIndex = 5;
            this.labelRegister.Text = "Register";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Location = new System.Drawing.Point(85, 408);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = false;
            this.cancelButton.Size = new System.Drawing.Size(64, 36);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 527);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxLastname);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxEmail);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textboxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxLastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxPassword;
        private MaterialSkin.Controls.MaterialFlatButton registerButton;
        private System.Windows.Forms.Label labelRegister;
        private MaterialSkin.Controls.MaterialFlatButton cancelButton;
    }
}