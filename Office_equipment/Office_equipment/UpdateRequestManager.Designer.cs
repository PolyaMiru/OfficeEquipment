namespace Office_equipment
{
    partial class UpdateRequestManager
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
            update_button = new Button();
            masters_comboBox = new ComboBox();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            statusComboBox = new ComboBox();
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
            problem_textBox.Location = new Point(22, 292);
            problem_textBox.Name = "problem_textBox";
            problem_textBox.Size = new Size(312, 124);
            problem_textBox.TabIndex = 8;
            problem_textBox.Text = "";
            // 
            // update_button
            // 
            update_button.BackColor = Color.FromArgb(11, 97, 164);
            update_button.FlatStyle = FlatStyle.Flat;
            update_button.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            update_button.ForeColor = SystemColors.ControlLightLight;
            update_button.Location = new Point(22, 522);
            update_button.Name = "update_button";
            update_button.Size = new Size(312, 36);
            update_button.TabIndex = 9;
            update_button.Text = "СОХРАНИТЬ";
            update_button.UseVisualStyleBackColor = false;
            update_button.Click += update_button_Click;
            // 
            // masters_comboBox
            // 
            masters_comboBox.BackColor = Color.FromArgb(255, 235, 193);
            masters_comboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            masters_comboBox.FormattingEnabled = true;
            masters_comboBox.Location = new Point(22, 433);
            masters_comboBox.Name = "masters_comboBox";
            masters_comboBox.Size = new Size(312, 29);
            masters_comboBox.TabIndex = 10;
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarTitleBackColor = Color.FromArgb(255, 235, 193);
            startDatePicker.Font = new Font("Cascadia Mono", 12F);
            startDatePicker.Location = new Point(22, 196);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(312, 26);
            startDatePicker.TabIndex = 11;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarTitleBackColor = Color.FromArgb(255, 235, 193);
            endDatePicker.Font = new Font("Cascadia Mono", 12F);
            endDatePicker.Location = new Point(22, 243);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(312, 26);
            endDatePicker.TabIndex = 12;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(255, 235, 193);
            statusComboBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(22, 477);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(312, 29);
            statusComboBox.TabIndex = 13;
            // 
            // UpdateRequestManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(362, 573);
            Controls.Add(statusComboBox);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(masters_comboBox);
            Controls.Add(update_button);
            Controls.Add(problem_textBox);
            Controls.Add(model_comboBox);
            Controls.Add(type_comboBox);
            Controls.Add(back_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateRequestManager";
            Text = "Редактировать заявку";
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private ComboBox type_comboBox;
        private ComboBox model_comboBox;
        private RichTextBox problem_textBox;
        private Button update_button;
        private ComboBox masters_comboBox;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private ComboBox statusComboBox;
    }
}