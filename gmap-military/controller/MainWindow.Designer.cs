
namespace gmap_military
{
    partial class MainWindow
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
            this.table = new System.Windows.Forms.DataGridView();
            this.filterB = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.filterOptionsCB = new System.Windows.Forms.ComboBox();
            this.stringTB = new System.Windows.Forms.TextBox();
            this.mapViewB = new System.Windows.Forms.Button();
            this.fromUD = new System.Windows.Forms.DomainUpDown();
            this.toUD = new System.Windows.Forms.DomainUpDown();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(35, 182);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 82;
            this.table.RowTemplate.Height = 33;
            this.table.Size = new System.Drawing.Size(1656, 591);
            this.table.TabIndex = 0;
            // 
            // filterB
            // 
            this.filterB.Enabled = false;
            this.filterB.Location = new System.Drawing.Point(1575, 83);
            this.filterB.Name = "filterB";
            this.filterB.Size = new System.Drawing.Size(116, 52);
            this.filterB.TabIndex = 1;
            this.filterB.Text = "Filtrar";
            this.filterB.UseVisualStyleBackColor = true;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(653, 29);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(388, 25);
            this.msgLabel.TabIndex = 2;
            this.msgLabel.Text = "Seleccione como desea filtrar los datos";
            // 
            // filterOptionsCB
            // 
            this.filterOptionsCB.FormattingEnabled = true;
            this.filterOptionsCB.Items.AddRange(new object[] {
            "Categórico",
            "Cadena",
            "Numérico"});
            this.filterOptionsCB.Location = new System.Drawing.Point(46, 94);
            this.filterOptionsCB.Name = "filterOptionsCB";
            this.filterOptionsCB.Size = new System.Drawing.Size(318, 33);
            this.filterOptionsCB.TabIndex = 3;
            this.filterOptionsCB.SelectedIndexChanged += new System.EventHandler(this.filterOptionsCB_SelectedIndexChanged);
            // 
            // stringTB
            // 
            this.stringTB.Enabled = false;
            this.stringTB.Location = new System.Drawing.Point(933, 94);
            this.stringTB.Name = "stringTB";
            this.stringTB.Size = new System.Drawing.Size(595, 31);
            this.stringTB.TabIndex = 4;
            // 
            // mapViewB
            // 
            this.mapViewB.Location = new System.Drawing.Point(718, 796);
            this.mapViewB.Name = "mapViewB";
            this.mapViewB.Size = new System.Drawing.Size(280, 57);
            this.mapViewB.TabIndex = 6;
            this.mapViewB.Text = "Ver datos en el mapa";
            this.mapViewB.UseVisualStyleBackColor = true;
            // 
            // fromUD
            // 
            this.fromUD.Enabled = false;
            this.fromUD.Location = new System.Drawing.Point(432, 76);
            this.fromUD.Name = "fromUD";
            this.fromUD.Size = new System.Drawing.Size(120, 31);
            this.fromUD.TabIndex = 9;
            this.fromUD.Text = "Desde";
            // 
            // toUD
            // 
            this.toUD.Enabled = false;
            this.toUD.Location = new System.Drawing.Point(432, 129);
            this.toUD.Name = "toUD";
            this.toUD.Size = new System.Drawing.Size(120, 31);
            this.toUD.TabIndex = 10;
            this.toUD.Text = "Hasta";
            // 
            // categoryCB
            // 
            this.categoryCB.Enabled = false;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(596, 92);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(298, 33);
            this.categoryCB.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 865);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.toUD);
            this.Controls.Add(this.fromUD);
            this.Controls.Add(this.mapViewB);
            this.Controls.Add(this.stringTB);
            this.Controls.Add(this.filterOptionsCB);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.filterB);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "GMap Military V1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button filterB;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.ComboBox filterOptionsCB;
        private System.Windows.Forms.TextBox stringTB;
        private System.Windows.Forms.Button mapViewB;
        private System.Windows.Forms.DomainUpDown fromUD;
        private System.Windows.Forms.DomainUpDown toUD;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

