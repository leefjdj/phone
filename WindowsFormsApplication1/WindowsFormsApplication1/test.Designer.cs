namespace WindowsFormsApplication1
{
    partial class test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.datebegin = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.grid_sell = new System.Windows.Forms.DataGridView();
            this.phone_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // datebegin
            // 
            this.datebegin.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.datebegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebegin.Location = new System.Drawing.Point(12, 12);
            this.datebegin.Name = "datebegin";
            this.datebegin.Size = new System.Drawing.Size(155, 26);
            this.datebegin.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(356, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 26);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "검색";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dateend
            // 
            this.dateend.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateend.Location = new System.Drawing.Point(185, 12);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(155, 26);
            this.dateend.TabIndex = 0;
            // 
            // grid_sell
            // 
            this.grid_sell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phone_name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_sell.Location = new System.Drawing.Point(13, 45);
            this.grid_sell.Name = "grid_sell";
            this.grid_sell.ReadOnly = true;
            this.grid_sell.RowTemplate.Height = 23;
            this.grid_sell.Size = new System.Drawing.Size(841, 281);
            this.grid_sell.TabIndex = 3;
            // 
            // phone_name
            // 
            this.phone_name.HeaderText = "기기명";
            this.phone_name.Name = "phone_name";
            this.phone_name.ReadOnly = true;
            this.phone_name.Width = 66;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "가격";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "구매자";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "나이";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 54;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "구매일";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 66;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("돋움", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 332);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(418, 235);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "핸드폰 판매량";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("돋움", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(436, 332);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(418, 235);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "제조사별 판매량";
            this.chart2.Titles.Add(title2);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 579);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.grid_sell);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datebegin);
            this.Name = "test";
            this.Text = "구매목록";
            ((System.ComponentModel.ISupportInitialize)(this.grid_sell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datebegin;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.DataGridView grid_sell;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}