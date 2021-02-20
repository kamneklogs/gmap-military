using gmap_military.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmap_military
{
    public partial class MainWindow : Form
    {

        private Manager manager;

        public MainWindow()
        {
            InitializeComponent();
            manager = new Manager();
            manager.loadData();

        }

        private void filterOptionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOptionsCB.SelectedItem.Equals("Categórico"))
            {
                msgLabel.Text = "Seleccione de la lista la categoria que desea";
                categoryCB.Enabled = true;

            } else if (filterOptionsCB.SelectedItem.Equals("Cadena"))
            {

            } else if (filterOptionsCB.SelectedItem.Equals("Numérico"))
            {

            }
        }
    }
}
