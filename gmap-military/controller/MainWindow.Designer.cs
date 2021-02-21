
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
            this.numeroZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterB = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            this.filterOptionsCB = new System.Windows.Forms.ComboBox();
            this.stringTB = new System.Windows.Forms.TextBox();
            this.mapViewB = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desdeTB = new System.Windows.Forms.TextBox();
            this.hastaTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroZona,
            this.zona,
            this.addressTC,
            this.cityTC,
            this.phoneTC,
            this.locationTC});
            this.table.Location = new System.Drawing.Point(89, 267);
            this.table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 82;
            this.table.RowTemplate.Height = 33;
            this.table.Size = new System.Drawing.Size(1337, 629);
            this.table.TabIndex = 0;
            this.table.TabStop = false;
            // 
            // numeroZona
            // 
            this.numeroZona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroZona.HeaderText = "Número Zona";
            this.numeroZona.MinimumWidth = 10;
            this.numeroZona.Name = "numeroZona";
            this.numeroZona.ReadOnly = true;
            // 
            // zona
            // 
            this.zona.HeaderText = "Zona";
            this.zona.MinimumWidth = 10;
            this.zona.Name = "zona";
            this.zona.ReadOnly = true;
            this.zona.Width = 200;
            // 
            // addressTC
            // 
            this.addressTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressTC.HeaderText = "Direccion";
            this.addressTC.MinimumWidth = 10;
            this.addressTC.Name = "addressTC";
            this.addressTC.ReadOnly = true;
            this.addressTC.Width = 147;
            // 
            // cityTC
            // 
            this.cityTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cityTC.HeaderText = "Ciudad";
            this.cityTC.MinimumWidth = 10;
            this.cityTC.Name = "cityTC";
            this.cityTC.ReadOnly = true;
            this.cityTC.Width = 125;
            // 
            // phoneTC
            // 
            this.phoneTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phoneTC.HeaderText = "Teléfono";
            this.phoneTC.MinimumWidth = 10;
            this.phoneTC.Name = "phoneTC";
            this.phoneTC.ReadOnly = true;
            this.phoneTC.Width = 141;
            // 
            // locationTC
            // 
            this.locationTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locationTC.HeaderText = "Ubicación";
            this.locationTC.MinimumWidth = 10;
            this.locationTC.Name = "locationTC";
            this.locationTC.ReadOnly = true;
            this.locationTC.Width = 152;
            // 
            // filterB
            // 
            this.filterB.Enabled = false;
            this.filterB.Location = new System.Drawing.Point(1288, 113);
            this.filterB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterB.Name = "filterB";
            this.filterB.Size = new System.Drawing.Size(116, 52);
            this.filterB.TabIndex = 1;
            this.filterB.Text = "Filtrar";
            this.filterB.UseVisualStyleBackColor = true;
            this.filterB.Click += new System.EventHandler(this.filterB_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(557, 37);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            this.filterOptionsCB.Location = new System.Drawing.Point(36, 123);
            this.filterOptionsCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterOptionsCB.Name = "filterOptionsCB";
            this.filterOptionsCB.Size = new System.Drawing.Size(318, 33);
            this.filterOptionsCB.TabIndex = 3;
            this.filterOptionsCB.SelectedIndexChanged += new System.EventHandler(this.filterOptionsCB_SelectedIndexChanged);
            // 
            // stringTB
            // 
            this.stringTB.Enabled = false;
            this.stringTB.Location = new System.Drawing.Point(854, 123);
            this.stringTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stringTB.Name = "stringTB";
            this.stringTB.Size = new System.Drawing.Size(360, 31);
            this.stringTB.TabIndex = 4;
            this.stringTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desdeTB_KeyPress);
            // 
            // mapViewB
            // 
            this.mapViewB.Location = new System.Drawing.Point(451, 914);
            this.mapViewB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mapViewB.Name = "mapViewB";
            this.mapViewB.Size = new System.Drawing.Size(280, 58);
            this.mapViewB.TabIndex = 6;
            this.mapViewB.Text = "Ver datos en el mapa";
            this.mapViewB.UseVisualStyleBackColor = true;
            this.mapViewB.Click += new System.EventHandler(this.showMap);
            // 
            // categoryCB
            // 
            this.categoryCB.Enabled = false;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Zona",
            "DIM"});
            this.categoryCB.Location = new System.Drawing.Point(600, 123);
            this.categoryCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(196, 33);
            this.categoryCB.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta";
            // 
            // desdeTB
            // 
            this.desdeTB.Enabled = false;
            this.desdeTB.Location = new System.Drawing.Point(434, 123);
            this.desdeTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.desdeTB.MaxLength = 2;
            this.desdeTB.Name = "desdeTB";
            this.desdeTB.Size = new System.Drawing.Size(100, 31);
            this.desdeTB.TabIndex = 14;
            // 
            // hastaTB
            // 
            this.hastaTB.Enabled = false;
            this.hastaTB.Location = new System.Drawing.Point(434, 212);
            this.hastaTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hastaTB.MaxLength = 2;
            this.hastaTB.Name = "hastaTB";
            this.hastaTB.Size = new System.Drawing.Size(100, 31);
            this.hastaTB.TabIndex = 15;
            this.hastaTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hastaTB_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 914);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ver gráficos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 985);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hastaTB);
            this.Controls.Add(this.desdeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.mapViewB);
            this.Controls.Add(this.stringTB);
            this.Controls.Add(this.filterOptionsCB);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.filterB);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desdeTB;
        private System.Windows.Forms.TextBox hastaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationTC;
        private System.Windows.Forms.Button button1;
    }
}

