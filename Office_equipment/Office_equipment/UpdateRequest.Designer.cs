namespace Office_equipment
{
    partial class UpdateRequest
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
            backButton = new Button();
            typeComboBox = new ComboBox();
            modelComboBox = new ComboBox();
            problemTextBox = new RichTextBox();
            updateButton = new Button();
            QRPictureBox = new PictureBox();
            label1 = new Label();
            updatePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)QRPictureBox).BeginInit();
            updatePanel.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(11, 97, 164);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(12, 14);
            backButton.Name = "backButton";
            backButton.Size = new Size(137, 36);
            backButton.TabIndex = 5;
            backButton.Text = "НАЗАД";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += back_button_Click;
            // 
            // typeComboBox
            // 
            typeComboBox.BackColor = Color.FromArgb(255, 235, 193);
            typeComboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(12, 74);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(312, 29);
            typeComboBox.TabIndex = 6;
            // 
            // modelComboBox
            // 
            modelComboBox.BackColor = Color.FromArgb(255, 235, 193);
            modelComboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(12, 133);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(312, 29);
            modelComboBox.TabIndex = 7;
            // 
            // problemTextBox
            // 
            problemTextBox.BorderStyle = BorderStyle.None;
            problemTextBox.Font = new Font("Cascadia Mono", 12F);
            problemTextBox.Location = new Point(12, 188);
            problemTextBox.Name = "problemTextBox";
            problemTextBox.Size = new Size(312, 169);
            problemTextBox.TabIndex = 8;
            problemTextBox.Text = "";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(11, 97, 164);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            updateButton.ForeColor = SystemColors.ControlLightLight;
            updateButton.Location = new Point(12, 380);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(312, 36);
            updateButton.TabIndex = 9;
            updateButton.Text = "СОХРАНИТЬ";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += update_button_Click;
            // 
            // QRPictureBox
            // 
            QRPictureBox.Location = new Point(208, 450);
            QRPictureBox.Name = "QRPictureBox";
            QRPictureBox.Size = new Size(126, 126);
            QRPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            QRPictureBox.TabIndex = 10;
            QRPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F);
            label1.Location = new Point(40, 496);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 11;
            label1.Text = "Оцените работу:";
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(backButton);
            updatePanel.Controls.Add(typeComboBox);
            updatePanel.Controls.Add(updateButton);
            updatePanel.Controls.Add(modelComboBox);
            updatePanel.Controls.Add(problemTextBox);
            updatePanel.Location = new Point(10, 12);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(340, 432);
            updatePanel.TabIndex = 12;
            // 
            // UpdateRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(362, 439);
            Controls.Add(label1);
            Controls.Add(QRPictureBox);
            Controls.Add(updatePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateRequest";
            Text = "Редактировать заявку";
            ((System.ComponentModel.ISupportInitialize)QRPictureBox).EndInit();
            updatePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private ComboBox typeComboBox;
        private ComboBox modelComboBox;
        private RichTextBox problemTextBox;
        private Button updateButton;
        private PictureBox QRPictureBox;
        private Label label1;
        private Panel updatePanel;
    }
}