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
                //Niveles educativos (preescolar, básica y media) 
                msgLabel.Text = "Seleccione el nivel educativo por el que desea filtrar los datos";
                categoryCB.Enabled = true;

            } else if (filterOptionsCB.SelectedItem.Equals("Cadena"))
            {   //Municipios

                msgLabel.Text = "Escriba el municipio por el que desea filtrar los datos";
                stringTB.Enabled = true;

            } else if (filterOptionsCB.SelectedItem.Equals("Numérico"))
            {
                //Código región

                msgLabel.Text = "Escriba el rango de códigos de los departamento por los que desea filtrar los datos";
                fromUD.Enabled = true;
                toUD.Enabled = true;

            }
        }
    }
}
