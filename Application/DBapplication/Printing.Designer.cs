namespace DBapplication
{
    partial class Printing
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
            this.PrintingPaperSizeComboBox = new System.Windows.Forms.ComboBox();
            this.PrintingColorCombobox = new System.Windows.Forms.ComboBox();
            this.PrintingCopiesTextBox = new System.Windows.Forms.TextBox();
            this.PrintingLinkTextBox = new System.Windows.Forms.TextBox();
            this.AddPrintingButton = new System.Windows.Forms.Button();
            this.BackPrintingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrintingPaperSizeComboBox
            // 
            this.PrintingPaperSizeComboBox.BackColor = System.Drawing.Color.GhostWhite;
            this.PrintingPaperSizeComboBox.FormattingEnabled = true;
            this.PrintingPaperSizeComboBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "B1",
            "B2",
            "B3"});
            this.PrintingPaperSizeComboBox.Location = new System.Drawing.Point(213, 201);
            this.PrintingPaperSizeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrintingPaperSizeComboBox.Name = "PrintingPaperSizeComboBox";
            this.PrintingPaperSizeComboBox.Size = new System.Drawing.Size(160, 24);
            this.PrintingPaperSizeComboBox.TabIndex = 79;
            this.PrintingPaperSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.PrintingPaperSizeComboBox_SelectedIndexChanged);
            // 
            // PrintingColorCombobox
            // 
            this.PrintingColorCombobox.BackColor = System.Drawing.Color.GhostWhite;
            this.PrintingColorCombobox.FormattingEnabled = true;
            this.PrintingColorCombobox.Items.AddRange(new object[] {
            "Black and White",
            "Colors"});
            this.PrintingColorCombobox.Location = new System.Drawing.Point(213, 167);
            this.PrintingColorCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.PrintingColorCombobox.Name = "PrintingColorCombobox";
            this.PrintingColorCombobox.Size = new System.Drawing.Size(160, 24);
            this.PrintingColorCombobox.TabIndex = 78;
            // 
            // PrintingCopiesTextBox
            // 
            this.PrintingCopiesTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.PrintingCopiesTextBox.Location = new System.Drawing.Point(213, 238);
            this.PrintingCopiesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrintingCopiesTextBox.Name = "PrintingCopiesTextBox";
            this.PrintingCopiesTextBox.Size = new System.Drawing.Size(160, 22);
            this.PrintingCopiesTextBox.TabIndex = 73;
            // 
            // PrintingLinkTextBox
            // 
            this.PrintingLinkTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.PrintingLinkTextBox.Location = new System.Drawing.Point(213, 133);
            this.PrintingLinkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrintingLinkTextBox.Name = "PrintingLinkTextBox";
            this.PrintingLinkTextBox.Size = new System.Drawing.Size(160, 22);
            this.PrintingLinkTextBox.TabIndex = 72;
            // 
            // AddPrintingButton
            // 
            this.AddPrintingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.AddPrintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPrintingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPrintingButton.Location = new System.Drawing.Point(224, 347);
            this.AddPrintingButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPrintingButton.Name = "AddPrintingButton";
            this.AddPrintingButton.Size = new System.Drawing.Size(149, 58);
            this.AddPrintingButton.TabIndex = 71;
            this.AddPrintingButton.Text = "Order";
            this.AddPrintingButton.UseVisualStyleBackColor = false;
            this.AddPrintingButton.Click += new System.EventHandler(this.AddPrintingButton_Click);
            // 
            // BackPrintingButton
            // 
            this.BackPrintingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.BackPrintingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackPrintingButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackPrintingButton.Location = new System.Drawing.Point(709, 477);
            this.BackPrintingButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackPrintingButton.Name = "BackPrintingButton";
            this.BackPrintingButton.Size = new System.Drawing.Size(133, 50);
            this.BackPrintingButton.TabIndex = 70;
            this.BackPrintingButton.Text = "Back";
            this.BackPrintingButton.UseVisualStyleBackColor = false;
            this.BackPrintingButton.Click += new System.EventHandler(this.BackPrintingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(868, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 549);
            this.panel1.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(53, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "Link";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(53, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(53, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "Paper Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label9.Location = new System.Drawing.Point(51, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 84;
            this.label9.Text = "No. Of Copies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(357, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 85;
            this.label1.Text = "Printing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(929, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PrintingPaperSizeComboBox);
            this.Controls.Add(this.PrintingColorCombobox);
            this.Controls.Add(this.PrintingCopiesTextBox);
            this.Controls.Add(this.PrintingLinkTextBox);
            this.Controls.Add(this.AddPrintingButton);
            this.Controls.Add(this.BackPrintingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Printing";
            this.Text = "Printing";
            this.Load += new System.EventHandler(this.Printing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PrintingPaperSizeComboBox;
        private System.Windows.Forms.ComboBox PrintingColorCombobox;
        private System.Windows.Forms.TextBox PrintingCopiesTextBox;
        private System.Windows.Forms.TextBox PrintingLinkTextBox;
        private System.Windows.Forms.Button AddPrintingButton;
        private System.Windows.Forms.Button BackPrintingButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}