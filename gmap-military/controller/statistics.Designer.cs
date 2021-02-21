
namespace gmap_military
{
    partial class statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.barsStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.donutStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.barsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutStat)).BeginInit();
            this.SuspendLayout();
            // 
            // barsStat
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.barsStat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barsStat.Legends.Add(legend1);
            this.barsStat.Location = new System.Drawing.Point(805, 271);
            this.barsStat.Name = "barsStat";
            this.barsStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "zonesSerie";
            this.barsStat.Series.Add(series1);
            this.barsStat.Size = new System.Drawing.Size(553, 466);
            this.barsStat.TabIndex = 0;
            this.barsStat.Text = "chart1";
            // 
            // pieStat
            // 
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.pieStat.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieStat.Legends.Add(legend2);
            this.pieStat.Location = new System.Drawing.Point(12, 12);
            this.pieStat.Name = "pieStat";
            this.pieStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.MarkerSize = 0;
            series2.Name = "citiesSerie";
            this.pieStat.Series.Add(series2);
            this.pieStat.Size = new System.Drawing.Size(774, 725);
            this.pieStat.TabIndex = 0;
            this.pieStat.Text = "chart2";
            // 
            // donutStat
            // 
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Name = "ChartArea1";
            this.donutStat.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.donutStat.Legends.Add(legend3);
            this.donutStat.Location = new System.Drawing.Point(805, 12);
            this.donutStat.Name = "donutStat";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.MarkerSize = 0;
            series3.Name = "zonesSerie";
            this.donutStat.Series.Add(series3);
            this.donutStat.Size = new System.Drawing.Size(553, 240);
            this.donutStat.TabIndex = 2;
            this.donutStat.Text = "chart3";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.donutStat);
            this.Controls.Add(this.pieStat);
            this.Controls.Add(this.barsStat);
            this.Name = "statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barsStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart donutStat;
    }
}