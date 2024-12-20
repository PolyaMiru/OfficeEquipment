namespace Office_equipment
{
    partial class UpdateRequestMaster
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
            problemTextBox = new RichTextBox();
            typeTextBox = new TextBox();
            modelTextBox = new TextBox();
            partGrid = new DataGridView();
            commentButton = new Button();
            addPartButton = new Button();
            startButton = new Button();
            endButton = new Button();
            ((System.ComponentModel.ISupportInitialize)partGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(11, 97, 164);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.ForeColor = SystemColors.ControlLightLight;
            backButton.Location = new Point(22, 24);
            backButton.Name = "backButton";
            backButton.Size = new Size(137, 36);
            backButton.TabIndex = 5;
            backButton.Text = "НАЗАД";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // problemTextBox
            // 
            problemTextBox.BorderStyle = BorderStyle.None;
            problemTextBox.Enabled = false;
            problemTextBox.Font = new Font("Cascadia Mono", 12F);
            problemTextBox.Location = new Point(22, 200);
            problemTextBox.Name = "problemTextBox";
            problemTextBox.Size = new Size(347, 142);
            problemTextBox.TabIndex = 8;
            problemTextBox.Text = "";
            // 
            // typeTextBox
            // 
            typeTextBox.Enabled = false;
            typeTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typeTextBox.Location = new Point(22, 85);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(347, 26);
            typeTextBox.TabIndex = 10;
            // 
            // modelTextBox
            // 
            modelTextBox.Enabled = false;
            modelTextBox.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            modelTextBox.Location = new Point(22, 147);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(347, 26);
            modelTextBox.TabIndex = 11;
            // 
            // partGrid
            // 
            partGrid.AllowUserToAddRows = false;
            partGrid.AllowUserToDeleteRows = false;
            partGrid.AllowUserToResizeColumns = false;
            partGrid.AllowUserToResizeRows = false;
            partGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            partGrid.BackgroundColor = Color.FromArgb(255, 235, 193);
            partGrid.BorderStyle = BorderStyle.None;
            partGrid.Location = new Point(22, 370);
            partGrid.Name = "partGrid";
            partGrid.ReadOnly = true;
            partGrid.RowHeadersVisible = false;
            partGrid.Size = new Size(347, 144);
            partGrid.TabIndex = 12;
            // 
            // commentButton
            // 
            commentButton.BackColor = Color.FromArgb(11, 97, 164);
            commentButton.FlatStyle = FlatStyle.Flat;
            commentButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            commentButton.ForeColor = SystemColors.ControlLightLight;
            commentButton.Location = new Point(22, 532);
            commentButton.Name = "commentButton";
            commentButton.Size = new Size(181, 36);
            commentButton.TabIndex = 13;
            commentButton.Text = "ПРОКОММЕНТИРОВАТЬ";
            commentButton.UseVisualStyleBackColor = false;
            commentButton.Click += commentButton_Click;
            // 
            // addPartButton
            // 
            addPartButton.BackColor = Color.FromArgb(11, 97, 164);
            addPartButton.FlatStyle = FlatStyle.Flat;
            addPartButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addPartButton.ForeColor = SystemColors.ControlLightLight;
            addPartButton.Location = new Point(209, 532);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(160, 36);
            addPartButton.TabIndex = 14;
            addPartButton.Text = "ДОБАВИТЬ ДЕТАЛЬ";
            addPartButton.UseVisualStyleBackColor = false;
            addPartButton.Click += addPartButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(11, 97, 164);
            startButton.Enabled = false;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = SystemColors.ControlLightLight;
            startButton.Location = new Point(232, 24);
            startButton.Name = "startButton";
            startButton.Size = new Size(137, 36);
            startButton.TabIndex = 15;
            startButton.Text = "НАЧАТЬ";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // endButton
            // 
            endButton.BackColor = Color.FromArgb(11, 97, 164);
            endButton.Enabled = false;
            endButton.FlatStyle = FlatStyle.Flat;
            endButton.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endButton.ForeColor = SystemColors.ControlLightLight;
            endButton.Location = new Point(22, 583);
            endButton.Name = "endButton";
            endButton.Size = new Size(347, 36);
            endButton.TabIndex = 16;
            endButton.Text = "ЗАКОНЧИТЬ РАБОТУ";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // UpdateRequestMaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 193);
            ClientSize = new Size(393, 626);
            Controls.Add(endButton);
            Controls.Add(startButton);
            Controls.Add(addPartButton);
            Controls.Add(commentButton);
            Controls.Add(partGrid);
            Controls.Add(modelTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(problemTextBox);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateRequestMaster";
            Text = "Исполнить заявку";
            ((System.ComponentModel.ISupportInitialize)partGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private RichTextBox problemTextBox;
        private TextBox typeTextBox;
        private TextBox modelTextBox;
        private DataGridView partGrid;
        private Button commentButton;
        private Button addPartButton;
        private Button startButton;
        private Button endButton;
    }
}