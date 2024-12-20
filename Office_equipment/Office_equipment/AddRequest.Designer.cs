namespace Office_equipment
{
    partial class AddRequest
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
            back_button = new Button();
            type_comboBox = new ComboBox();
            model_comboBox = new ComboBox();
            problem_textBox = new RichTextBox();
            add_button = new Button();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(11, 97, 164);
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            back_button.ForeColor = SystemColors.ControlLightLight;
            back_button.Location = new Point(22, 24);
            back_button.Name = "back_button";
            back_button.Size = new Size(137, 36);
            back_button.TabIndex = 5;
            back_button.Text = "НАЗАД";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // type_comboBox
            // 
            type_comboBox.BackColor = Color.FromArgb(255, 235, 193);
            type_comboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(22, 87);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(312, 29);
            type_comboBox.TabIndex = 6;
            type_comboBox.SelectedIndexChanged += type_comboBox_SelectedIndexChanged;
            // 
            // model_comboBox
            // 
            model_comboBox.BackColor = Color.FromArgb(255, 235, 193);
            model_comboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            model_comboBox.FormattingEnabled = true;
            model_comboBox.Location = new Point(22, 146);
            model_comboBox.Name = "model_comboBox";
            model_comboBox.Size = new Size(312, 29);
            model_comboBox.TabIndex = 7;
            // 
            // problem_textBox
            // 
            problem_textBox.BorderStyle = BorderStyle.None;
            problem_textBox.Font = new Font("Cascadia Mono", 12F);
            problem_textBox.Location = new Point(22, 200);
            problem_textBox.Name = "problem_textBox";
            problem_textBox.Size = new Size(312, 169);
            problem_textBox.TabIndex = 8;
            problem_textBox.Text = "";
            // 
            // add_button
            // 
            add_button.BackColor = Color.FromArgb(11, 97, 164);
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            add_button.ForeColor = SystemColors.ControlLightLight;
            add_button.Location = new Point(22, 396);
            add_button.Name = "add_button";
            add_button.Size = new Size(312, 36);
            add_button.TabIndex = 9;
            add_button.Text = "СОЗДАТЬ ЗАЯВКУ";
            add_button.UseVisualStyleBackColor = false;
            add_button.Click += add_button_Click;
            // 
            // AddRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(362, 451);
            Controls.Add(add_button);
            Controls.Add(problem_textBox);
            Controls.Add(model_comboBox);
            Controls.Add(type_comboBox);
            Controls.Add(back_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddRequest";
            Text = "Добавить заявку";
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private ComboBox type_comboBox;
        private ComboBox model_comboBox;
        private RichTextBox problem_textBox;
        private Button add_button;
    }
}