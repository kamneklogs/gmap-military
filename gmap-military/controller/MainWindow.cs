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

         

            loadTable();
            
            //configurateCategoryCB();
        }

        public void loadTable()
        {
            int index = 0;
            for (int i = 0; i < manager.militaryBases.Count; i++)
            {

                index = table.Rows.Add();
                MilitaryBase temp = manager.militaryBases.ElementAt(i);
                //   dataTownGridRecord.Rows[index].Cells[0].Value = temp[0];
                table.Rows[index].Cells[0].Value = temp.zonaN;
                table.Rows[index].Cells[1].Value = temp.zona;
                table.Rows[index].Cells[2].Value = temp.address;
                table.Rows[index].Cells[3].Value = temp.city;
                table.Rows[index].Cells[4].Value = temp.phone;
                table.Rows[index].Cells[5].Value = temp.location;
                Console.WriteLine(temp.location);
            }
        }

        public void configurateCategoryCB()
        {
            ArrayList msg = manager.configurateCategory();
            string[] agregados = new string[50];
            Boolean yaEsta = false;
            for (int i = 0; i < msg.Count; i++)
            {

                for (int j = 0; j < agregados.Length; i++)
                {
                    if (agregados[j].Equals(msg.IndexOf(i)))
                    {
                        yaEsta = true;
                    }
                }
                    if(yaEsta != true)
                    {
                        agregados[i] = (string)msg[i];
                        categoryCB.Items.Add(agregados[i]);
                }
                
            }
            
        }

        private void filterOptionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterOptionsCB.SelectedItem.Equals("Categórico"))
            {
                //Zona
                msgLabel.Text = "Seleccione el tipo de zona por el que desea filtrar los datos";
                categoryCB.Enabled = true;
                stringTB.Enabled = false;
                desdeTB.Enabled = false;
                hastaTB.Enabled = false;
                filterB.Enabled = false;

            } else if (filterOptionsCB.SelectedItem.Equals("Cadena"))
            {   //Ciudades

                msgLabel.Text = "Escriba la ciudad por la que desea filtrar los datos";
                stringTB.Enabled = true;
                categoryCB.Enabled = false;
                desdeTB.Enabled = false;
                hastaTB.Enabled = false;
                filterB.Enabled = false;
                filterB.Enabled = true;


            }
            else if (filterOptionsCB.SelectedItem.Equals("Numérico"))
            {
                //Número zona
                msgLabel.Text = "Escriba el rango de las zonas por las que desea filtrar los datos";
                desdeTB.Enabled = true;
                hastaTB.Enabled = true;
                categoryCB.Enabled = false;
                stringTB.Enabled = false;
                filterB.Enabled = true;

            }
        }



        private void showMap(object sender, EventArgs e)
        {
            controller.MapView mv = new controller.MapView(table.Rows);
            mv.ShowDialog();
        }

        private void filterB_Click(object sender, EventArgs e)
        {
            if (filterOptionsCB.SelectedItem.Equals("Cadena")){

                if (stringTB.Text != "")
                {
                    manager.filterCity(stringTB.Text);
                    table.Rows.Clear();
                    int index = 0;
                    for (int i = 0; i < manager.militaryBases.Count; i++)
                    {

                        index = table.Rows.Add();
                        MilitaryBase temp = manager.militaryBases.ElementAt(i);

                        table.Rows[index].Cells[0].Value = temp.zonaN;
                        table.Rows[index].Cells[1].Value = temp.zona;
                        table.Rows[index].Cells[2].Value = temp.address;
                        table.Rows[index].Cells[3].Value = temp.city;
                        table.Rows[index].Cells[4].Value = temp.phone;
                        table.Rows[index].Cells[5].Value = temp.location;


                    }
                }
            } else if (filterOptionsCB.SelectedItem.Equals("Numérico"))
            {
                if (desdeTB.Text != "" && hastaTB.Text != "")
                {
                    manager.filterZN(Int32.Parse(desdeTB.Text), Int32.Parse(hastaTB.Text));
                    table.Rows.Clear();
                    int index = 0;
                    for (int i = 0; i < manager.militaryBases.Count; i++)
                    {

                        index = table.Rows.Add();
                        MilitaryBase temp = manager.militaryBases.ElementAt(i);

                        table.Rows[index].Cells[0].Value = temp.zonaN;
                        table.Rows[index].Cells[1].Value = temp.zona;
                        table.Rows[index].Cells[2].Value = temp.address;
                        table.Rows[index].Cells[3].Value = temp.city;
                        table.Rows[index].Cells[4].Value = temp.phone;
                        table.Rows[index].Cells[5].Value = temp.location;


                    }
                }
            }
        }

        private void desdeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            } else
                if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void hastaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (categoryCB.SelectedItem.Equals("Zona"))
            {
                manager.filterZona("ZONA");
                table.Rows.Clear();
                int index = 0;
                for (int i = 0; i < manager.militaryBases.Count; i++)
                {

                    index = table.Rows.Add();
                    MilitaryBase temp = manager.militaryBases.ElementAt(i);

                    table.Rows[index].Cells[0].Value = temp.zonaN;
                    table.Rows[index].Cells[1].Value = temp.zona;
                    table.Rows[index].Cells[2].Value = temp.address;
                    table.Rows[index].Cells[3].Value = temp.city;
                    table.Rows[index].Cells[4].Value = temp.phone;
                    table.Rows[index].Cells[5].Value = temp.location;


                }
            }
            else
            {
                manager.filterZona("DIM");
                table.Rows.Clear();
                int index = 0;
                for (int i = 0; i < manager.militaryBases.Count; i++)
                {

                    index = table.Rows.Add();
                    MilitaryBase temp = manager.militaryBases.ElementAt(i);

                    table.Rows[index].Cells[0].Value = temp.zonaN;
                    table.Rows[index].Cells[1].Value = temp.zona;
                    table.Rows[index].Cells[2].Value = temp.address;
                    table.Rows[index].Cells[3].Value = temp.city;
                    table.Rows[index].Cells[4].Value = temp.phone;
                    table.Rows[index].Cells[5].Value = temp.location;


                }
            }


        }
    }
}
