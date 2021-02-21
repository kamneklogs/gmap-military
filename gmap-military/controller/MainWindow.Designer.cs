
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
            this.addressTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressTC,
            this.cityTC,
            this.phoneTC,
            this.locationTC});
            this.table.Location = new System.Drawing.Point(18, 95);
            this.table.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 82;
            this.table.RowTemplate.Height = 33;
            this.table.Size = new System.Drawing.Size(828, 307);
            this.table.TabIndex = 0;
            // 
            // filterB
            // 
            this.filterB.Enabled = false;
            this.filterB.Location = new System.Drawing.Point(788, 43);
            this.filterB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterB.Name = "filterB";
            this.filterB.Size = new System.Drawing.Size(58, 27);
            this.filterB.TabIndex = 1;
            this.filterB.Text = "Filtrar";
            this.filterB.UseVisualStyleBackColor = true;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(326, 15);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(191, 13);
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
            this.filterOptionsCB.Location = new System.Drawing.Point(23, 49);
            this.filterOptionsCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterOptionsCB.Name = "filterOptionsCB";
            this.filterOptionsCB.Size = new System.Drawing.Size(161, 21);
            this.filterOptionsCB.TabIndex = 3;
            this.filterOptionsCB.SelectedIndexChanged += new System.EventHandler(this.filterOptionsCB_SelectedIndexChanged);
            // 
            // stringTB
            // 
            this.stringTB.Enabled = false;
            this.stringTB.Location = new System.Drawing.Point(466, 49);
            this.stringTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stringTB.Name = "stringTB";
            this.stringTB.Size = new System.Drawing.Size(300, 20);
            this.stringTB.TabIndex = 4;
            // 
            // mapViewB
            // 
            this.mapViewB.Location = new System.Drawing.Point(359, 414);
            this.mapViewB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapViewB.Name = "mapViewB";
            this.mapViewB.Size = new System.Drawing.Size(140, 30);
            this.mapViewB.TabIndex = 6;
            this.mapViewB.Text = "Ver datos en el mapa";
            this.mapViewB.UseVisualStyleBackColor = true;
            // 
            // fromUD
            // 
            this.fromUD.Enabled = false;
            this.fromUD.Location = new System.Drawing.Point(216, 40);
            this.fromUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromUD.Name = "fromUD";
            this.fromUD.Size = new System.Drawing.Size(60, 20);
            this.fromUD.TabIndex = 9;
            this.fromUD.Text = "Desde";
            // 
            // toUD
            // 
            this.toUD.Enabled = false;
            this.toUD.Location = new System.Drawing.Point(216, 67);
            this.toUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toUD.Name = "toUD";
            this.toUD.Size = new System.Drawing.Size(60, 20);
            this.toUD.TabIndex = 10;
            this.toUD.Text = "Hasta";
            // 
            // categoryCB
            // 
            this.categoryCB.Enabled = false;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(298, 48);
            this.categoryCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(151, 21);
            this.categoryCB.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addressTC
            // 
            this.addressTC.HeaderText = "Direccion";
            this.addressTC.Name = "addressTC";
            // 
            // cityTC
            // 
            this.cityTC.HeaderText = "Ciudad";
            this.cityTC.Name = "cityTC";
            // 
            // phoneTC
            // 
            this.phoneTC.HeaderText = "Teléfono";
            this.phoneTC.Name = "phoneTC";
            // 
            // locationTC
            // 
            this.locationTC.HeaderText = "Ubicación";
            this.locationTC.Name = "locationTC";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.toUD);
            this.Controls.Add(this.fromUD);
            this.Controls.Add(this.mapViewB);
            this.Controls.Add(this.stringTB);
            this.Controls.Add(this.filterOptionsCB);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.filterB);
            this.Controls.Add(this.table);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationTC;
    }
}

