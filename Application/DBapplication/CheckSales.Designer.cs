namespace DBapplication
{
    partial class CheckSales
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new DBapplication.DataSet1();
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesStatisticsTableAdapter = new DBapplication.DataSet1TableAdapters.SalesStatisticsTableAdapter();
            this.BackSalesButton = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesStatisticsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesStatisticsBindingSource
            // 
            this.SalesStatisticsBindingSource.DataMember = "SalesStatistics";
            this.SalesStatisticsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.DataSet1;
            // 
            // SalesStatisticsTableAdapter
            // 
            this.SalesStatisticsTableAdapter.ClearBeforeFill = true;
            // 
            // BackSalesButton
            // 
            this.BackSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.BackSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSalesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSalesButton.Location = new System.Drawing.Point(717, 573);
            this.BackSalesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackSalesButton.Name = "BackSalesButton";
            this.BackSalesButton.Size = new System.Drawing.Size(127, 55);
            this.BackSalesButton.TabIndex = 31;
            this.BackSalesButton.Text = "Back";
            this.BackSalesButton.UseVisualStyleBackColor = false;
            this.BackSalesButton.Click += new System.EventHandler(this.BackSalesButton_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.BackColor = System.Drawing.Color.GhostWhite;
            this.reportViewer2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SalesStatisticsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DBapplication.CheckforSales.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(62, 82);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(763, 439);
            this.reportViewer2.TabIndex = 37;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(908, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 702);
            this.panel1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(366, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(982, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.BackSalesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.CheckSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesStatisticsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource SalesStatisticsBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SalesStatisticsTableAdapter SalesStatisticsTableAdapter;
        private System.Windows.Forms.BindingSource SalesBindingSource;
       
        private System.Windows.Forms.Button BackSalesButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}