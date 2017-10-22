namespace MatthewsCrossingFoodBank
{
    partial class DataAnalytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLoadedInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoadedInfo
            // 
            this.lblLoadedInfo.AutoSize = true;
            this.lblLoadedInfo.Location = new System.Drawing.Point(238, 165);
            this.lblLoadedInfo.Name = "lblLoadedInfo";
            this.lblLoadedInfo.Size = new System.Drawing.Size(0, 13);
            this.lblLoadedInfo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 73);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Visualization";
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(50, 199);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(408, 227);
            this.barChart.TabIndex = 15;
            this.barChart.Text = "barChart";
            this.barChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(477, 165);
            this.pieChart.Name = "pieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(300, 300);
            this.pieChart.TabIndex = 16;
            this.pieChart.Text = "pieChart";
            // 
            // DataAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(826, 536);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.barChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoadedInfo);
            this.Name = "DataAnalytics";
            this.Text = "DataAnalytics";
            this.Load += new System.EventHandler(this.DataAnalytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadedInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}