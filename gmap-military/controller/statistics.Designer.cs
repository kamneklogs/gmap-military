
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.barsStat.Location = new System.Drawing.Point(1610, 521);
            this.barsStat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barsStat.Name = "barsStat";
            this.barsStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "zonesSerie";
            this.barsStat.Series.Add(series1);
            this.barsStat.Size = new System.Drawing.Size(1106, 896);
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
            this.pieStat.Location = new System.Drawing.Point(24, 23);
            this.pieStat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pieStat.Name = "pieStat";
            this.pieStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.MarkerSize = 0;
            series2.Name = "citiesSerie";
            this.pieStat.Series.Add(series2);
            this.pieStat.Size = new System.Drawing.Size(1548, 1394);
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
            this.donutStat.Location = new System.Drawing.Point(1610, 23);
            this.donutStat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.donutStat.Name = "donutStat";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.MarkerSize = 0;
            series3.Name = "zonesSerie";
            this.donutStat.Series.Add(series3);
            this.donutStat.Size = new System.Drawing.Size(1106, 462);
            this.donutStat.TabIndex = 2;
            this.donutStat.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1621, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Concentración de bases militares por zonas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2382, 772);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1621, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Concentración de bases militares por zonas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concentración de bases militares por ciudades del país";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.donutStat);
            this.Controls.Add(this.pieStat);
            this.Controls.Add(this.barsStat);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donutStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart barsStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart donutStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}