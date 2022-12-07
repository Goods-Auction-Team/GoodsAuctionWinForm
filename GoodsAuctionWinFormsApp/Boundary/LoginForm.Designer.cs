namespace GoodsAuctionWinFormsApp.Boundary
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.failedLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(15, 17);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(544, 50);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Auction House!";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(44, 114);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(122, 31);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(172, 111);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(339, 38);
            this.usernameTextbox.TabIndex = 1;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(172, 177);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '●';
            this.passwordTextbox.Size = new System.Drawing.Size(339, 38);
            this.passwordTextbox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(44, 180);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(115, 31);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(185, 301);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(211, 54);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // failedLoginLabel
            // 
            this.failedLoginLabel.AutoSize = true;
            this.failedLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.failedLoginLabel.Location = new System.Drawing.Point(62, 232);
            this.failedLoginLabel.Name = "failedLoginLabel";
            this.failedLoginLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.failedLoginLabel.Size = new System.Drawing.Size(0, 31);
            this.failedLoginLabel.TabIndex = 5;
            this.failedLoginLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.failedLoginLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(578, 347);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Label usernameLabel;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label passwordLabel;
        private Button loginButton;
        private Label failedLoginLabel;
    }
}