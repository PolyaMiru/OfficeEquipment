namespace Office_equipment
{
    partial class ShowRequest
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            requestGrid = new DataGridView();
            statusComboBox = new ComboBox();
            addButton = new Button();
            countLabel = new Label();
            label2 = new Label();
            fullCountLable = new Label();
            ((System.ComponentModel.ISupportInitialize)requestGrid).BeginInit();
            SuspendLayout();
            // 
            // requestGrid
            // 
            requestGrid.AllowUserToAddRows = false;
            requestGrid.AllowUserToDeleteRows = false;
            requestGrid.AllowUserToResizeColumns = false;
            requestGrid.AllowUserToResizeRows = false;
            requestGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            requestGrid.BackgroundColor = Color.FromArgb(255, 235, 193);
            requestGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cascadia Mono", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            requestGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            requestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestGrid.Location = new Point(36, 124);
            requestGrid.Name = "requestGrid";
            requestGrid.ReadOnly = true;
            requestGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            requestGrid.RowHeadersVisible = false;
            requestGrid.Size = new Size(641, 492);
            requestGrid.TabIndex = 0;
            requestGrid.CellClick += request_grid_CellClick;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(255, 235, 193);
            statusComboBox.FlatStyle = FlatStyle.System;
            statusComboBox.Font = new Font("Cascadia Mono", 12.25F);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(36, 76);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(215, 29);
            statusComboBox.TabIndex = 1;
            statusComboBox.SelectedIndexChanged += status_comboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(11, 97, 164);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(36, 24);
            addButton.Name = "addButton";
            addButton.Size = new Size(215, 36);
            addButton.TabIndex = 2;
            addButton.Text = "СОЗДАТЬ ЗАЯВКУ";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += add_button_Click;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Cascadia Mono", 12.25F);
            countLabel.Location = new Point(572, 620);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(20, 22);
            countLabel.TabIndex = 3;
            countLabel.Text = "0";
            countLabel.TextAlign = ContentAlignment.TopRight;
            countLabel.Click += countLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12.25F);
            label2.Location = new Point(591, 619);
            label2.Name = "label2";
            label2.Size = new Size(20, 22);
            label2.TabIndex = 4;
            label2.Text = "/";
            // 
            // fullCountLable
            // 
            fullCountLable.AutoSize = true;
            fullCountLable.Font = new Font("Cascadia Mono", 12.25F);
            fullCountLable.Location = new Point(607, 620);
            fullCountLable.Name = "fullCountLable";
            fullCountLable.Size = new Size(70, 22);
            fullCountLable.TabIndex = 5;
            fullCountLable.Text = "label3";
            // 
            // ShowRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(716, 651);
            Controls.Add(fullCountLable);
            Controls.Add(label2);
            Controls.Add(countLabel);
            Controls.Add(addButton);
            Controls.Add(statusComboBox);
            Controls.Add(requestGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ShowRequest";
            Text = "Просмотр заявок";
            ((System.ComponentModel.ISupportInitialize)requestGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView requestGrid;
        private ComboBox statusComboBox;
        private Button addButton;
        private Label countLabel;
        private Label label2;
        private Label fullCountLable;
    }
}
