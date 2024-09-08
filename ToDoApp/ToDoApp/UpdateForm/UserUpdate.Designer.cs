namespace ToDoApp.UI.RegisterForms
{
    partial class UserUpdate
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
            btnRegisterUpdateCancel = new Button();
            btnRegisterUpdate = new Button();
            label11 = new Label();
            groupBox1 = new GroupBox();
            rbtnUpdateMan = new RadioButton();
            rbtnUpdateWomen = new RadioButton();
            txtUpdatePostalCode = new TextBox();
            txtUpdateCity = new TextBox();
            txtUpdateCountry = new TextBox();
            txtUpdatePhone = new TextBox();
            txtUpdateEmail = new TextBox();
            txtUpdateLastName = new TextBox();
            txtUpdateName = new TextBox();
            txtUpdateUserName = new TextBox();
            txtUpdatePassword = new TextBox();
            dtUpdateBirthdate = new DateTimePicker();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegisterUpdateCancel
            // 
            btnRegisterUpdateCancel.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            btnRegisterUpdateCancel.Location = new Point(238, 506);
            btnRegisterUpdateCancel.Name = "btnRegisterUpdateCancel";
            btnRegisterUpdateCancel.Size = new Size(94, 49);
            btnRegisterUpdateCancel.TabIndex = 14;
            btnRegisterUpdateCancel.Text = "İptal";
            btnRegisterUpdateCancel.UseVisualStyleBackColor = true;
            btnRegisterUpdateCancel.Click += btnRegisterUpdateCancel_Click;
            // 
            // btnRegisterUpdate
            // 
            btnRegisterUpdate.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold);
            btnRegisterUpdate.Location = new Point(338, 506);
            btnRegisterUpdate.Name = "btnRegisterUpdate";
            btnRegisterUpdate.Size = new Size(94, 49);
            btnRegisterUpdate.TabIndex = 13;
            btnRegisterUpdate.Text = "Güncelle";
            btnRegisterUpdate.UseVisualStyleBackColor = true;
            btnRegisterUpdate.Click += btnRegisterUpdate_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(24, 9);
            label11.Name = "label11";
            label11.Size = new Size(426, 44);
            label11.TabIndex = 52;
            label11.Text = "Kullanıcı Bilgileri Güncelle";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnUpdateMan);
            groupBox1.Controls.Add(rbtnUpdateWomen);
            groupBox1.Location = new Point(190, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 45);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            // 
            // rbtnUpdateMan
            // 
            rbtnUpdateMan.AutoSize = true;
            rbtnUpdateMan.Font = new Font("Rockwell Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnUpdateMan.Location = new Point(6, 20);
            rbtnUpdateMan.Name = "rbtnUpdateMan";
            rbtnUpdateMan.Size = new Size(52, 18);
            rbtnUpdateMan.TabIndex = 5;
            rbtnUpdateMan.TabStop = true;
            rbtnUpdateMan.Text = "Erkek";
            rbtnUpdateMan.UseVisualStyleBackColor = true;
            // 
            // rbtnUpdateWomen
            // 
            rbtnUpdateWomen.AutoSize = true;
            rbtnUpdateWomen.Font = new Font("Rockwell Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtnUpdateWomen.Location = new Point(182, 20);
            rbtnUpdateWomen.Name = "rbtnUpdateWomen";
            rbtnUpdateWomen.Size = new Size(54, 18);
            rbtnUpdateWomen.TabIndex = 6;
            rbtnUpdateWomen.TabStop = true;
            rbtnUpdateWomen.Text = "Kadın";
            rbtnUpdateWomen.UseVisualStyleBackColor = true;
            // 
            // txtUpdatePostalCode
            // 
            txtUpdatePostalCode.Location = new Point(190, 477);
            txtUpdatePostalCode.Name = "txtUpdatePostalCode";
            txtUpdatePostalCode.Size = new Size(242, 23);
            txtUpdatePostalCode.TabIndex = 12;
            // 
            // txtUpdateCity
            // 
            txtUpdateCity.Location = new Point(190, 441);
            txtUpdateCity.Name = "txtUpdateCity";
            txtUpdateCity.Size = new Size(242, 23);
            txtUpdateCity.TabIndex = 11;
            // 
            // txtUpdateCountry
            // 
            txtUpdateCountry.Location = new Point(190, 402);
            txtUpdateCountry.Name = "txtUpdateCountry";
            txtUpdateCountry.Size = new Size(242, 23);
            txtUpdateCountry.TabIndex = 10;
            // 
            // txtUpdatePhone
            // 
            txtUpdatePhone.Location = new Point(190, 362);
            txtUpdatePhone.Name = "txtUpdatePhone";
            txtUpdatePhone.Size = new Size(242, 23);
            txtUpdatePhone.TabIndex = 9;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(190, 327);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(242, 23);
            txtUpdateEmail.TabIndex = 8;
            // 
            // txtUpdateLastName
            // 
            txtUpdateLastName.Location = new Point(190, 206);
            txtUpdateLastName.Name = "txtUpdateLastName";
            txtUpdateLastName.Size = new Size(242, 23);
            txtUpdateLastName.TabIndex = 4;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(190, 166);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(242, 23);
            txtUpdateName.TabIndex = 3;
            // 
            // txtUpdateUserName
            // 
            txtUpdateUserName.Location = new Point(190, 95);
            txtUpdateUserName.Name = "txtUpdateUserName";
            txtUpdateUserName.Size = new Size(242, 23);
            txtUpdateUserName.TabIndex = 0;
            // 
            // txtUpdatePassword
            // 
            txtUpdatePassword.Location = new Point(190, 131);
            txtUpdatePassword.Name = "txtUpdatePassword";
            txtUpdatePassword.Size = new Size(242, 23);
            txtUpdatePassword.TabIndex = 1;
            // 
            // dtUpdateBirthdate
            // 
            dtUpdateBirthdate.Location = new Point(190, 286);
            dtUpdateBirthdate.Name = "dtUpdateBirthdate";
            dtUpdateBirthdate.Size = new Size(242, 23);
            dtUpdateBirthdate.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(39, 284);
            label12.Name = "label12";
            label12.Size = new Size(145, 25);
            label12.TabIndex = 40;
            label12.Text = "Doğum Tarihi :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 477);
            label10.Name = "label10";
            label10.Size = new Size(109, 25);
            label10.TabIndex = 39;
            label10.Text = "Posta Kod :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 441);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 38;
            label9.Text = "Şehir :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(39, 402);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 37;
            label8.Text = "Ülke :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 244);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 36;
            label7.Text = "Cinsiyet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 362);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 35;
            label6.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 325);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 34;
            label5.Text = "E-Mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 206);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 33;
            label4.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 166);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 32;
            label3.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 126);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 31;
            label1.Text = "Parola :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 90);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 30;
            label2.Text = "Kullanıcı Adı :";
            // 
            // UserUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 569);
            Controls.Add(btnRegisterUpdateCancel);
            Controls.Add(btnRegisterUpdate);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Controls.Add(txtUpdatePostalCode);
            Controls.Add(txtUpdateCity);
            Controls.Add(txtUpdateCountry);
            Controls.Add(txtUpdatePhone);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdateLastName);
            Controls.Add(txtUpdateName);
            Controls.Add(txtUpdateUserName);
            Controls.Add(txtUpdatePassword);
            Controls.Add(dtUpdateBirthdate);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UserUpdate";
            Text = "Kullanıcı Bilgilerini Güncelle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterUpdateCancel;
        private Button btnRegisterUpdate;
        private Label label11;
        private GroupBox groupBox1;
        private RadioButton rbtnUpdateMan;
        private RadioButton rbtnUpdateWomen;
        private TextBox txtUpdatePostalCode;
        private TextBox txtUpdateCity;
        private TextBox txtUpdateCountry;
        private TextBox txtUpdatePhone;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdateLastName;
        private TextBox txtUpdateName;
        private TextBox txtUpdateUserName;
        private TextBox txtUpdatePassword;
        private DateTimePicker dtUpdateBirthdate;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}