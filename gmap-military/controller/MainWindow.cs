using gmap_military.model;
using System;
using System.Collections;
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

            Console.WriteLine(manager.militaryBases.Count);

            int index = 0;
            for (int i = 0; i < manager.militaryBases.Count; i++)
            {

                index = table.Rows.Add();
                MilitaryBase temp = manager.militaryBases.ElementAt(i);
                //   dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                table.Rows[index].Cells[0].Value = temp.address;
                table.Rows[index].Cells[1].Value = temp.city;
                table.Rows[index].Cells[2].Value = temp.phone;
                table.Rows[index].Cells[3].Value = "("+temp.location + ")";

            }

        }

        public void configurateCategoryCB()
        {
            ArrayList msg = manager.configurateCategory();
            string[] agregados = new string[1000];
            for (int i = 0; i < msg.Count; i++)
            {
                 
                for(int j = 0; j < agregados.Length; i++)
                {
                   
                }
            }
            
            categoryCB.Items.Add("");

        }

        private void filterOptionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOptionsCB.SelectedItem.Equals("Categórico"))
            {
                //Zona
                msgLabel.Text = "Seleccione el tipo de zona por el que desea filtrar los datos";
                categoryCB.Enabled = true;
                stringTB.Enabled = false;
                fromUD.Enabled = true;
                toUD.Enabled = true;

            } else if (filterOptionsCB.SelectedItem.Equals("Cadena"))
            {   //Ciudades

                msgLabel.Text = "Escriba la ciudad por la que desea filtrar los datos";
                stringTB.Enabled = true;
                categoryCB.Enabled = true;
                fromUD.Enabled = true;
                toUD.Enabled = true;

            } else if (filterOptionsCB.SelectedItem.Equals("Numérico"))
            {
                //Número zona

                msgLabel.Text = "Escriba el rango de las zonas por las que desea filtrar los datos";
                fromUD.Enabled = true;
                toUD.Enabled = true;
                categoryCB.Enabled = true;
                stringTB.Enabled = false;

            }
        }

        private void showMap(object sender, EventArgs e)
        {
            controller.MapView mv = new controller.MapView();
            mv.ShowDialog();
        }
    }
}
