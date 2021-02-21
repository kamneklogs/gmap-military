
namespace gmap_military.controller
{
    partial class MapView
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
            this.mainMap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // mainMap
            // 
            this.mainMap.AllowDrop = true;
            this.mainMap.AutoSize = true;
            this.mainMap.Bearing = 0F;
            this.mainMap.CanDragMap = true;
            this.mainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMap.GrayScaleMode = false;
            this.mainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMap.LevelsKeepInMemmory = 5;
            this.mainMap.Location = new System.Drawing.Point(14, 4);
            this.mainMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mainMap.MarkersEnabled = true;
            this.mainMap.MaxZoom = 20;
            this.mainMap.MinZoom = 2;
            this.mainMap.MouseWheelZoomEnabled = true;
            this.mainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainMap.Name = "mainMap";
            this.mainMap.NegativeMode = false;
            this.mainMap.PolygonsEnabled = true;
            this.mainMap.RetryLoadTile = 0;
            this.mainMap.RoutesEnabled = true;
            this.mainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMap.ShowTileGridLines = false;
            this.mainMap.Size = new System.Drawing.Size(1850, 906);
            this.mainMap.TabIndex = 0;
            this.mainMap.Zoom = 5D;
            this.mainMap.Load += new System.EventHandler(this.gMapLoad);
            // 
            // MapView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1880, 1031);
            this.Controls.Add(this.mainMap);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MapView";
            this.Text = "Zonas Militares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mainMap;
    }
}