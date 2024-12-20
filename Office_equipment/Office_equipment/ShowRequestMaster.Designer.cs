namespace Office_equipment
{
    partial class ShowRequestMaster
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            requestGrid = new DataGridView();
            statusComboBox = new ComboBox();
            fullCountLable = new Label();
            label2 = new Label();
            countLabel = new Label();
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
            requestGrid.BackgroundColor = Color.FromArgb(255, 235, 193);
            requestGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cascadia Mono", 12.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            requestGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            requestGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestGrid.Location = new Point(36, 75);
            requestGrid.Name = "requestGrid";
            requestGrid.ReadOnly = true;
            requestGrid.RowHeadersVisible = false;
            requestGrid.Size = new Size(641, 542);
            requestGrid.TabIndex = 0;
            requestGrid.CellClick += request_grid_CellClick;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.FromArgb(255, 235, 193);
            statusComboBox.FlatStyle = FlatStyle.System;
            statusComboBox.Font = new Font("Cascadia Mono", 12.25F);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(36, 24);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(215, 29);
            statusComboBox.TabIndex = 1;
            statusComboBox.SelectedIndexChanged += status_comboBox_SelectedIndexChanged;
            // 
            // fullCountLable
            // 
            fullCountLable.AutoSize = true;
            fullCountLable.Font = new Font("Cascadia Mono", 12.25F);
            fullCountLable.Location = new Point(607, 620);
            fullCountLable.Name = "fullCountLable";
            fullCountLable.Size = new Size(70, 22);
            fullCountLable.TabIndex = 8;
            fullCountLable.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12.25F);
            label2.Location = new Point(591, 619);
            label2.Name = "label2";
            label2.Size = new Size(20, 22);
            label2.TabIndex = 7;
            label2.Text = "/";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new Font("Cascadia Mono", 12.25F);
            countLabel.Location = new Point(572, 620);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(20, 22);
            countLabel.TabIndex = 6;
            countLabel.Text = "0";
            countLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ShowRequestMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(716, 651);
            Controls.Add(fullCountLable);
            Controls.Add(label2);
            Controls.Add(countLabel);
            Controls.Add(statusComboBox);
            Controls.Add(requestGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ShowRequestMaster";
            Text = "Просмотр заявок";
            ((System.ComponentModel.ISupportInitialize)requestGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView requestGrid;
        private ComboBox statusComboBox;
        private Label fullCountLable;
        private Label label2;
        private Label countLabel;
    }
}
