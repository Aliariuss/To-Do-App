namespace ToDoApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            btnCancel = new Button();
            btnEnter = new Button();
            btnRegister = new Button();
            lnkIForgetMyPassword = new LinkLabel();
            cbShowMyPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 38);
            label1.TabIndex = 0;
            label1.Text = "Giriş Yap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Parola :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(153, 86);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(211, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(153, 144);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.PasswordChar = '*';
            txtUserPassword.Size = new Size(211, 23);
            txtUserPassword.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            btnCancel.Location = new Point(134, 314);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 47);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            btnEnter.Location = new Point(134, 266);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(112, 47);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Giriş";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            btnRegister.Location = new Point(134, 362);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 47);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lnkIForgetMyPassword
            // 
            lnkIForgetMyPassword.AutoSize = true;
            lnkIForgetMyPassword.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            lnkIForgetMyPassword.Location = new Point(149, 205);
            lnkIForgetMyPassword.Name = "lnkIForgetMyPassword";
            lnkIForgetMyPassword.Size = new Size(174, 25);
            lnkIForgetMyPassword.TabIndex = 4;
            lnkIForgetMyPassword.TabStop = true;
            lnkIForgetMyPassword.Text = "Şifremi Unuttum...";
            // 
            // cbShowMyPassword
            // 
            cbShowMyPassword.AutoSize = true;
            cbShowMyPassword.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            cbShowMyPassword.Location = new Point(153, 173);
            cbShowMyPassword.Name = "cbShowMyPassword";
            cbShowMyPassword.Size = new Size(158, 29);
            cbShowMyPassword.TabIndex = 3;
            cbShowMyPassword.Text = "Parolayı Göster";
            cbShowMyPassword.UseVisualStyleBackColor = true;
            cbShowMyPassword.CheckedChanged += cbShowMyPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 412);
            Controls.Add(cbShowMyPassword);
            Controls.Add(lnkIForgetMyPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnEnter);
            Controls.Add(btnCancel);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Button btnCancel;
        private Button btnEnter;
        private Button btnRegister;
        private LinkLabel lnkIForgetMyPassword;
        private CheckBox cbShowMyPassword;
    }
}
