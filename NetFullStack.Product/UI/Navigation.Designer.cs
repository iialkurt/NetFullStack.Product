namespace NetFullStack.Product.UI
{
    partial class Navigation
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
            btnProduct = new Button();
            btnDictonary = new Button();
            lblUser = new Label();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(29, 41);
            btnProduct.Margin = new Padding(5, 4, 5, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(746, 95);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "Ürün Listesine Git";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnDictonary
            // 
            btnDictonary.Location = new Point(29, 153);
            btnDictonary.Margin = new Padding(5, 4, 5, 4);
            btnDictonary.Name = "btnDictonary";
            btnDictonary.Size = new Size(746, 95);
            btnDictonary.TabIndex = 0;
            btnDictonary.Text = "Özlü Sözlere Git";
            btnDictonary.UseVisualStyleBackColor = true;
            btnDictonary.Click += btnDictonary_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(299, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 27);
            lblUser.TabIndex = 1;
            // 
            // Navigation
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 411);
            Controls.Add(lblUser);
            Controls.Add(btnDictonary);
            Controls.Add(btnProduct);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Navigation";
            Text = "Navigation";
            FormClosed += Navigation_FormClosed;
            Load += Navigation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProduct;
        private Button btnDictonary;
        private Label lblUser;
    }
}