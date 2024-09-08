namespace ToDoApp.UI.AppForm
{
    partial class ToDoAppForm
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
            dtDueDate = new DateTimePicker();
            lvToDoChecked = new ListView();
            ID = new ColumnHeader();
            Title = new ColumnHeader();
            Description = new ColumnHeader();
            Date = new ColumnHeader();
            Done = new ColumnHeader();
            lvToDoList = new ListView();
            ToDoID = new ColumnHeader();
            ToDoTitle = new ColumnHeader();
            ToDoDescription = new ColumnHeader();
            ToDoDate = new ColumnHeader();
            ToBeCompleted = new ColumnHeader();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnDelete = new Button();
            rtxtDescription = new RichTextBox();
            txtSearchDo = new TextBox();
            txtSearchCompleted = new TextBox();
            groupBox1 = new GroupBox();
            grpCompleted = new GroupBox();
            btnUpdate = new Button();
            label5 = new Label();
            lnklblUserName = new LinkLabel();
            groupBox1.SuspendLayout();
            grpCompleted.SuspendLayout();
            SuspendLayout();
            // 
            // dtDueDate
            // 
            dtDueDate.CustomFormat = "dd/MM/yy hh:mm";
            dtDueDate.Location = new Point(154, 289);
            dtDueDate.Name = "dtDueDate";
            dtDueDate.Size = new Size(302, 23);
            dtDueDate.TabIndex = 2;
            // 
            // lvToDoChecked
            // 
            lvToDoChecked.AllowColumnReorder = true;
            lvToDoChecked.AllowDrop = true;
            lvToDoChecked.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvToDoChecked.BackColor = SystemColors.InactiveCaption;
            lvToDoChecked.Columns.AddRange(new ColumnHeader[] { ID, Title, Description, Date, Done });
            lvToDoChecked.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lvToDoChecked.ForeColor = Color.IndianRed;
            lvToDoChecked.FullRowSelect = true;
            lvToDoChecked.GridLines = true;
            lvToDoChecked.Location = new Point(6, 83);
            lvToDoChecked.Name = "lvToDoChecked";
            lvToDoChecked.Size = new Size(727, 748);
            lvToDoChecked.TabIndex = 9;
            lvToDoChecked.UseCompatibleStateImageBehavior = false;
            lvToDoChecked.View = View.Details;
            lvToDoChecked.ItemActivate += lvToDoChecked_ItemActivate;
            lvToDoChecked.DragDrop += lvToDoChecked_DragDrop;
            lvToDoChecked.DragEnter += lvToDoChecked_DragEnter;
            lvToDoChecked.MouseDown += lvToDoChecked_MouseDown;
            lvToDoChecked.MouseMove += lvToDoChecked_MouseMove;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Title
            // 
            Title.Text = "BAŞLIK";
            Title.Width = 120;
            // 
            // Description
            // 
            Description.Text = "AÇIKLAMA";
            Description.Width = 250;
            // 
            // Date
            // 
            Date.Text = "TARİH";
            Date.Width = 160;
            // 
            // Done
            // 
            Done.Text = "TAMAMLANDI";
            Done.Width = 100;
            // 
            // lvToDoList
            // 
            lvToDoList.AllowColumnReorder = true;
            lvToDoList.AllowDrop = true;
            lvToDoList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvToDoList.BackColor = SystemColors.InactiveCaption;
            lvToDoList.Columns.AddRange(new ColumnHeader[] { ToDoID, ToDoTitle, ToDoDescription, ToDoDate, ToBeCompleted });
            lvToDoList.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lvToDoList.ForeColor = Color.IndianRed;
            lvToDoList.FullRowSelect = true;
            lvToDoList.GridLines = true;
            lvToDoList.Location = new Point(6, 83);
            lvToDoList.Name = "lvToDoList";
            lvToDoList.Size = new Size(743, 742);
            lvToDoList.TabIndex = 10;
            lvToDoList.UseCompatibleStateImageBehavior = false;
            lvToDoList.View = View.Details;
            lvToDoList.ItemActivate += lvToDoList_ItemActivate;
            lvToDoList.DragDrop += lvToDoList_DragDrop;
            lvToDoList.DragEnter += lvToDoList_DragEnter;
            lvToDoList.MouseDown += lvToDoList_MouseDown;
            lvToDoList.MouseMove += lvToDoList_MouseMove;
            // 
            // ToDoID
            // 
            ToDoID.Text = "ID";
            // 
            // ToDoTitle
            // 
            ToDoTitle.Text = "BAŞLIK";
            ToDoTitle.Width = 120;
            // 
            // ToDoDescription
            // 
            ToDoDescription.Text = "AÇIKLAMA";
            ToDoDescription.Width = 250;
            // 
            // ToDoDate
            // 
            ToDoDate.Text = "TARİH";
            ToDoDate.Width = 150;
            // 
            // ToBeCompleted
            // 
            ToBeCompleted.Text = "TAMAMLANACAK";
            ToBeCompleted.Width = 100;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(159, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(297, 23);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 31);
            label1.TabIndex = 12;
            label1.Text = "Görev Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 13;
            label2.Text = "Başlık :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(141, 31);
            label3.TabIndex = 14;
            label3.Text = "Açıklama :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 16;
            label4.Text = "Tarih :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(57, 332);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1892, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 40);
            btnExit.TabIndex = 10;
            btnExit.Text = "Çıkış Yap";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(258, 332);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(159, 121);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(297, 138);
            rtxtDescription.TabIndex = 1;
            rtxtDescription.Text = "";
            // 
            // txtSearchDo
            // 
            txtSearchDo.Location = new Point(508, 48);
            txtSearchDo.Name = "txtSearchDo";
            txtSearchDo.PlaceholderText = "Ara Tamamlanacak";
            txtSearchDo.Size = new Size(241, 29);
            txtSearchDo.TabIndex = 7;
            txtSearchDo.TextChanged += txtSearchDo_TextChanged;
            // 
            // txtSearchCompleted
            // 
            txtSearchCompleted.Location = new Point(489, 48);
            txtSearchCompleted.Name = "txtSearchCompleted";
            txtSearchCompleted.PlaceholderText = "Ara Tamamlanan";
            txtSearchCompleted.Size = new Size(241, 29);
            txtSearchCompleted.TabIndex = 8;
            txtSearchCompleted.TextChanged += txtSearchCompleted_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvToDoList);
            groupBox1.Controls.Add(txtSearchDo);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(494, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 831);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamamlanacaklar";
            // 
            // grpCompleted
            // 
            grpCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpCompleted.Controls.Add(lvToDoChecked);
            grpCompleted.Controls.Add(txtSearchCompleted);
            grpCompleted.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpCompleted.Location = new Point(1255, 49);
            grpCompleted.Name = "grpCompleted";
            grpCompleted.Size = new Size(739, 831);
            grpCompleted.TabIndex = 25;
            grpCompleted.TabStop = false;
            grpCompleted.Text = "Tamamlananlar";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(159, 332);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(1496, 9);
            label5.Name = "label5";
            label5.Size = new Size(157, 31);
            label5.TabIndex = 27;
            label5.Text = "Hoşgeldiniz";
            // 
            // lnklblUserName
            // 
            lnklblUserName.AutoSize = true;
            lnklblUserName.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold);
            lnklblUserName.LinkColor = Color.IndianRed;
            lnklblUserName.Location = new Point(1659, 9);
            lnklblUserName.Name = "lnklblUserName";
            lnklblUserName.Size = new Size(170, 31);
            lnklblUserName.TabIndex = 9;
            lnklblUserName.TabStop = true;
            lnklblUserName.Text = "USERNAME";
            lnklblUserName.LinkClicked += lnklblUserName_LinkClicked;
            // 
            // ToDoAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1997, 886);
            Controls.Add(lnklblUserName);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
            Controls.Add(grpCompleted);
            Controls.Add(groupBox1);
            Controls.Add(rtxtDescription);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(dtDueDate);
            ForeColor = Color.IndianRed;
            Name = "ToDoAppForm";
            Text = "To Do List";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpCompleted.ResumeLayout(false);
            grpCompleted.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtDueDate;
        private ListView lvToDoChecked;
        private ColumnHeader ID;
        private ColumnHeader Title;
        private ColumnHeader Description;
        private ColumnHeader Date;
        private ListView lvToDoList;
        private ColumnHeader ToDoID;
        private ColumnHeader ToDoTitle;
        private ColumnHeader ToDoDescription;
        private ColumnHeader ToDoDate;
        private ColumnHeader Done;
        private ColumnHeader ToBeCompleted;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnExit;
        private Button btnDelete;
        private RichTextBox rtxtDescription;
        private TextBox txtSearchDo;
        private TextBox txtSearchCompleted;
        private GroupBox groupBox1;
        private GroupBox grpCompleted;
        private Button btnUpdate;
        private Label label5;
        private LinkLabel lnklblUserName;
    }
}