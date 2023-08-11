namespace NetFullStack.Product.UI
{
    partial class Notes
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
            lblUser = new Label();
            label2 = new Label();
            listNotes = new ListBox();
            label1 = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNew = new Button();
            rcSoz = new RichTextBox();
            label3 = new Label();
            lblUpdateUser = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(590, 463);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 23);
            lblUser.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 463);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı : ";
            // 
            // listNotes
            // 
            listNotes.FormattingEnabled = true;
            listNotes.ItemHeight = 23;
            listNotes.Location = new Point(21, 33);
            listNotes.Name = "listNotes";
            listNotes.Size = new Size(399, 464);
            listNotes.TabIndex = 1;
            listNotes.DoubleClick += listNotes_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 43);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 9;
            label1.Text = "Söz Ekle:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(540, 300);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(286, 47);
            btnClose.TabIndex = 4;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(540, 247);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(286, 47);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(540, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet  Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(540, 141);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(286, 47);
            btnNew.TabIndex = 7;
            btnNew.Text = "Yeni";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // rcSoz
            // 
            rcSoz.Location = new Point(547, 34);
            rcSoz.Name = "rcSoz";
            rcSoz.Size = new Size(279, 88);
            rcSoz.TabIndex = 10;
            rcSoz.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 365);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(362, 23);
            label3.TabIndex = 0;
            label3.Text = "Son Değişikli Yapan Kullanıcı : ";
            // 
            // lblUpdateUser
            // 
            lblUpdateUser.AutoSize = true;
            lblUpdateUser.Location = new Point(515, 388);
            lblUpdateUser.Margin = new Padding(4, 0, 4, 0);
            lblUpdateUser.Name = "lblUpdateUser";
            lblUpdateUser.Size = new Size(0, 23);
            lblUpdateUser.TabIndex = 0;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 555);
            Controls.Add(rcSoz);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(listNotes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUpdateUser);
            Controls.Add(lblUser);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Notes";
            Text = "Notes";
            Load += Notes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label label2;
        private ListBox listNotes;
        private Label label1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNew;
        private RichTextBox rcSoz;
        private Label label3;
        private Label lblUpdateUser;
    }
}