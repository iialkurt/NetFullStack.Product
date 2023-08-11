namespace NetFullStack.Product.UI
{
    partial class LoginForm
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
            label1 = new Label();
            txtUserName = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(181, 27);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(204, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(230, 34);
            txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 146);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(422, 62);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 91);
            label2.Name = "label2";
            label2.Size = new Size(77, 27);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(204, 91);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 34);
            txtPassword.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(456, 233);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Paneli";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
    }
}