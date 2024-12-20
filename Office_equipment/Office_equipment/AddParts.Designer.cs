namespace Office_equipment
{
    partial class AddParts
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
            addButton = new Button();
            nameTextBox = new TextBox();
            countNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(11, 97, 164);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(12, 115);
            addButton.Name = "addButton";
            addButton.Size = new Size(328, 36);
            addButton.TabIndex = 4;
            addButton.Text = "ДОБАВИТЬ ДЕТАЛЬ";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += add_button_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(12, 33);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(328, 26);
            nameTextBox.TabIndex = 5;
            // 
            // countNumericUpDown
            // 
            countNumericUpDown.BackColor = Color.FromArgb(255, 235, 193);
            countNumericUpDown.BorderStyle = BorderStyle.None;
            countNumericUpDown.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold);
            countNumericUpDown.Location = new Point(12, 77);
            countNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            countNumericUpDown.Name = "countNumericUpDown";
            countNumericUpDown.RightToLeft = RightToLeft.No;
            countNumericUpDown.Size = new Size(46, 22);
            countNumericUpDown.TabIndex = 6;
            countNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(352, 163);
            Controls.Add(countNumericUpDown);
            Controls.Add(nameTextBox);
            Controls.Add(addButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddParts";
            Text = "Добавление деталей";
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox nameTextBox;
        private NumericUpDown countNumericUpDown;
    }
}