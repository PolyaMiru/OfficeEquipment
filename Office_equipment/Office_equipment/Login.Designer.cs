namespace Office_equipment
{
    partial class Login
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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            captchaPictureBox = new PictureBox();
            captchaTextBox = new TextBox();
            captchaButton = new Button();
            capthaPanel = new Panel();
            showButton = new Button();
            genButton = new Button();
            ((System.ComponentModel.ISupportInitialize)captchaPictureBox).BeginInit();
            capthaPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Cascadia Mono", 12F);
            loginTextBox.Location = new Point(38, 52);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(247, 26);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Cascadia Mono", 12F);
            passwordTextBox.Location = new Point(38, 121);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(247, 26);
            passwordTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(11, 97, 164);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            loginButton.ForeColor = SystemColors.ControlLightLight;
            loginButton.Location = new Point(38, 316);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(293, 38);
            loginButton.TabIndex = 2;
            loginButton.Text = "ВОЙТИ";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F);
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 3;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F);
            label2.Location = new Point(38, 97);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 4;
            label2.Text = "Пароль:";
            // 
            // captchaPictureBox
            // 
            captchaPictureBox.Location = new Point(12, 13);
            captchaPictureBox.Name = "captchaPictureBox";
            captchaPictureBox.Size = new Size(262, 71);
            captchaPictureBox.TabIndex = 5;
            captchaPictureBox.TabStop = false;
            // 
            // captchaTextBox
            // 
            captchaTextBox.Font = new Font("Cascadia Mono", 12F);
            captchaTextBox.Location = new Point(12, 106);
            captchaTextBox.Name = "captchaTextBox";
            captchaTextBox.Size = new Size(201, 26);
            captchaTextBox.TabIndex = 6;
            // 
            // captchaButton
            // 
            captchaButton.BackColor = Color.FromArgb(11, 97, 164);
            captchaButton.FlatStyle = FlatStyle.Flat;
            captchaButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            captchaButton.ForeColor = SystemColors.ControlLightLight;
            captchaButton.Location = new Point(219, 100);
            captchaButton.Name = "captchaButton";
            captchaButton.Size = new Size(40, 38);
            captchaButton.TabIndex = 7;
            captchaButton.Text = "✔";
            captchaButton.UseVisualStyleBackColor = false;
            captchaButton.Click += captchaButton_Click;
            // 
            // capthaPanel
            // 
            capthaPanel.Controls.Add(genButton);
            capthaPanel.Controls.Add(captchaTextBox);
            capthaPanel.Controls.Add(captchaPictureBox);
            capthaPanel.Controls.Add(captchaButton);
            capthaPanel.Enabled = false;
            capthaPanel.Location = new Point(26, 153);
            capthaPanel.Name = "capthaPanel";
            capthaPanel.Size = new Size(309, 148);
            capthaPanel.TabIndex = 8;
            // 
            // showButton
            // 
            showButton.BackColor = Color.Transparent;
            showButton.FlatStyle = FlatStyle.Flat;
            showButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            showButton.ForeColor = SystemColors.ActiveCaptionText;
            showButton.Location = new Point(292, 115);
            showButton.Name = "showButton";
            showButton.Size = new Size(40, 38);
            showButton.TabIndex = 8;
            showButton.Text = "👁";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // genButton
            // 
            genButton.BackColor = Color.FromArgb(11, 97, 164);
            genButton.FlatStyle = FlatStyle.Flat;
            genButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            genButton.ForeColor = SystemColors.ControlLightLight;
            genButton.Location = new Point(265, 100);
            genButton.Name = "genButton";
            genButton.Size = new Size(40, 38);
            genButton.TabIndex = 8;
            genButton.Text = "🔄";
            genButton.UseVisualStyleBackColor = false;
            genButton.Click += genButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(357, 381);
            Controls.Add(showButton);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(capthaPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)captchaPictureBox).EndInit();
            capthaPanel.ResumeLayout(false);
            capthaPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label label1;
        private Label label2;
        private PictureBox captchaPictureBox;
        private TextBox captchaTextBox;
        private Button captchaButton;
        private Panel capthaPanel;
        private Button showButton;
        private Button genButton;
    }
}