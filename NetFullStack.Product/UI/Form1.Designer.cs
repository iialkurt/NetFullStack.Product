namespace NetFullStack.Product
{
    partial class Form1
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
            ProductList = new ListBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            txtProductName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUrunId = new TextBox();
            label3 = new Label();
            txtProductQuantity = new MaskedTextBox();
            label4 = new Label();
            lblUser = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ProductList
            // 
            ProductList.FormattingEnabled = true;
            ProductList.ItemHeight = 23;
            ProductList.Location = new Point(11, 21);
            ProductList.Margin = new Padding(4, 3, 4, 3);
            ProductList.Name = "ProductList";
            ProductList.Size = new Size(458, 487);
            ProductList.TabIndex = 0;
            ProductList.DoubleClick += ProductList_DoubleClick;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(615, 170);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(286, 47);
            btnNew.TabIndex = 1;
            btnNew.Text = "Yeni";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(615, 223);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet  Güncelle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(615, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(286, 47);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(615, 329);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(286, 47);
            btnClose.TabIndex = 1;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(615, 71);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(286, 31);
            txtProductName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 72);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 3;
            label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 111);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 3;
            label2.Text = "Miktarı :";
            // 
            // txtUrunId
            // 
            txtUrunId.Enabled = false;
            txtUrunId.Location = new Point(615, 38);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new Size(286, 31);
            txtUrunId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 39);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 3;
            label3.Text = "Ürün Id :";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.BeepOnError = true;
            txtProductQuantity.Location = new Point(615, 111);
            txtProductQuantity.Mask = "000000000";
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(284, 31);
            txtProductQuantity.TabIndex = 4;
            txtProductQuantity.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(522, 470);
            label4.Name = "label4";
            label4.Size = new Size(131, 23);
            label4.TabIndex = 3;
            label4.Text = "Kullanıcı :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(664, 469);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 23);
            lblUser.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(686, 828);
            label6.Name = "label6";
            label6.Size = new Size(109, 23);
            label6.TabIndex = 3;
            label6.Text = "Miktarı :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 534);
            Controls.Add(txtProductQuantity);
            Controls.Add(label6);
            Controls.Add(lblUser);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtUrunId);
            Controls.Add(txtProductName);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(ProductList);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ProductList;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private TextBox txtProductName;
        private Label label1;
        private Label label2;
        private TextBox txtUrunId;
        private Label label3;
        private MaskedTextBox txtProductQuantity;
        private Label label4;
        private Label lblUser;
        private Label label6;
    }
}