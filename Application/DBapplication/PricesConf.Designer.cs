namespace DBapplication
{
    partial class PricesConf
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesStatisticsforownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new DBapplication.DataSet1();
            this.PercentageTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ActionButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.addsaleradio = new System.Windows.Forms.RadioButton();
            this.removesaleradio = new System.Windows.Forms.RadioButton();
            this.increasepriceradio = new System.Windows.Forms.RadioButton();
            this.SalesStatisticsforownersTableAdapter = new DBapplication.DataSet1TableAdapters.SalesStatisticsforownersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesStatisticsforownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesStatisticsforownersBindingSource
            // 
            this.SalesStatisticsforownersBindingSource.DataMember = "SalesStatisticsforowners";
            this.SalesStatisticsforownersBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PercentageTextbox
            // 
            this.PercentageTextbox.BackColor = System.Drawing.Color.GhostWhite;
            this.PercentageTextbox.Location = new System.Drawing.Point(188, 135);
            this.PercentageTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PercentageTextbox.Name = "PercentageTextbox";
            this.PercentageTextbox.Size = new System.Drawing.Size(161, 22);
            this.PercentageTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(123, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "ADD SALE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.BackColor = System.Drawing.Color.Crimson;
            this.ActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.Location = new System.Drawing.Point(806, 137);
            this.ActionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(159, 60);
            this.ActionButton.TabIndex = 20;
            this.ActionButton.Text = "Action";
            this.ActionButton.UseVisualStyleBackColor = false;
            this.ActionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1058, 537);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 57);
            this.button2.TabIndex = 21;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(336, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(735, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "INCREASE PRICES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(384, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 34);
            this.label6.TabIndex = 25;
            this.label6.Text = "REMOVE SALE";
            this.label6.EnabledChanged += new System.EventHandler(this.label6_EnabledChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 84);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 24);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.GhostWhite;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalesStatisticsforownersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.SetSales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 241);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(986, 315);
            this.reportViewer1.TabIndex = 28;
            // 
            // addsaleradio
            // 
            this.addsaleradio.AutoSize = true;
            this.addsaleradio.Location = new System.Drawing.Point(97, 27);
            this.addsaleradio.Margin = new System.Windows.Forms.Padding(4);
            this.addsaleradio.Name = "addsaleradio";
            this.addsaleradio.Size = new System.Drawing.Size(17, 16);
            this.addsaleradio.TabIndex = 29;
            this.addsaleradio.TabStop = true;
            this.addsaleradio.UseVisualStyleBackColor = true;
            // 
            // removesaleradio
            // 
            this.removesaleradio.AutoSize = true;
            this.removesaleradio.ForeColor = System.Drawing.Color.Crimson;
            this.removesaleradio.Location = new System.Drawing.Point(356, 32);
            this.removesaleradio.Margin = new System.Windows.Forms.Padding(4);
            this.removesaleradio.Name = "removesaleradio";
            this.removesaleradio.Size = new System.Drawing.Size(17, 16);
            this.removesaleradio.TabIndex = 30;
            this.removesaleradio.TabStop = true;
            this.removesaleradio.UseVisualStyleBackColor = true;
            this.removesaleradio.CheckedChanged += new System.EventHandler(this.removesaleradio_CheckedChanged);
            // 
            // increasepriceradio
            // 
            this.increasepriceradio.AutoSize = true;
            this.increasepriceradio.ForeColor = System.Drawing.Color.Crimson;
            this.increasepriceradio.Location = new System.Drawing.Point(709, 27);
            this.increasepriceradio.Margin = new System.Windows.Forms.Padding(4);
            this.increasepriceradio.Name = "increasepriceradio";
            this.increasepriceradio.Size = new System.Drawing.Size(17, 16);
            this.increasepriceradio.TabIndex = 31;
            this.increasepriceradio.TabStop = true;
            this.increasepriceradio.UseVisualStyleBackColor = true;
            // 
            // SalesStatisticsforownersTableAdapter
            // 
            this.SalesStatisticsforownersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(1215, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(29, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Percentage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label8.Location = new System.Drawing.Point(29, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label4.Location = new System.Drawing.Point(386, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(748, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Please Make sure that the department you will increase is the price Not ON SALE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PricesConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1281, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.increasepriceradio);
            this.Controls.Add(this.removesaleradio);
            this.Controls.Add(this.addsaleradio);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PercentageTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PricesConf";
            this.Text = "AddSale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesStatisticsforownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PercentageTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton addsaleradio;
        private System.Windows.Forms.RadioButton removesaleradio;
        private System.Windows.Forms.RadioButton increasepriceradio;
        private System.Windows.Forms.BindingSource SalesStatisticsforownersBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SalesStatisticsforownersTableAdapter SalesStatisticsforownersTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}