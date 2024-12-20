namespace Office_equipment
{
    partial class AddComment
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
            commentTextBox = new RichTextBox();
            addButton = new Button();
            SuspendLayout();
            // 
            // commentTextBox
            // 
            commentTextBox.BorderStyle = BorderStyle.None;
            commentTextBox.Font = new Font("Cascadia Mono", 12F);
            commentTextBox.Location = new Point(12, 12);
            commentTextBox.Name = "commentTextBox";
            commentTextBox.Size = new Size(328, 89);
            commentTextBox.TabIndex = 0;
            commentTextBox.Text = "";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(11, 97, 164);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(12, 117);
            addButton.Name = "addButton";
            addButton.Size = new Size(328, 36);
            addButton.TabIndex = 3;
            addButton.Text = "ДОБАВИТЬ КОММЕНТАРИЙ";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += add_button_Click;
            // 
            // AddComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(352, 163);
            Controls.Add(addButton);
            Controls.Add(commentTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddComment";
            Text = "Добавление комментария";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox commentTextBox;
        private Button addButton;
    }
}