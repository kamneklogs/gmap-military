using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gmap_military.model
{
    class Manager
    {
        private string path;
        private System.Data.DataTable table;

        public List<MilitaryBase> militaryBases { get; }

        public Manager()
        {
            militaryBases = new List<MilitaryBase>();
        }

        public ArrayList configurateCategory()
        {
            ArrayList msg = new ArrayList();
            try
            {
                int contador = 0;
                var sr = new StreamReader(path);

                string s = sr.ReadLine();
                s = sr.ReadLine();
                string[] temp = null;

                while (s != null)
                {
                    temp = s.Split(',');

                    string address = temp[2];
                    string city = temp[3];
                    msg[contador] = city;
                    string phone = temp[4];
                    string location = temp[5].Substring(1, temp[5].Length - 1) + temp[6].Substring(1, temp[6].Length - 1);

                    //militaryBases.Add(new MilitaryBase(address, city, phone, location));

                    s = sr.ReadLine();
                    contador++;
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de los datos");
            }
            return msg;
        }

        public void loadData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    path = openFileDialog.FileName;

                    var sr = new StreamReader(path);

                    string s = sr.ReadLine();
                    s = sr.ReadLine();
                    string[] temp = null;

                    while (s != null)
                    {
                        temp = s.Split(',');

                        string zonaN = temp[0];
                        string zona = temp[1];
                        string address = temp[2];
                        string city = temp[3];
                        string phone = temp[4];
                        string location = temp[5] + " " + temp[6];

                        militaryBases.Add(new MilitaryBase(zonaN, zona, address, city, phone, location));

                        s = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la carga de los datos");
                }

            }

        }


    public void filterZN(int desde, int hasta)
    {     
            try
            {
                var sr = new StreamReader(path);

                string s = sr.ReadLine();
                s = sr.ReadLine();
                string[] temp = null;

                while (s != null)
                {
                    temp = s.Split(',');

                    string zonaN = temp[0];
                    string zona = temp[1];
                    string address = temp[2];
                    string city = temp[3];
                    string phone = temp[4];
                    string location = temp[5].Substring(1, temp[5].Length - 1) + temp[6].Substring(1, temp[6].Length - 1);


                    if (Int32.Parse(zonaN) >= desde && Int32.Parse(zonaN) <= hasta)
                    {
                        militaryBases.Add(new MilitaryBase(zonaN, zona, address, city, phone, location));
                    }

                    s = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de los datos");
            }

        }

    

    public void filterCity(string cityF)
    {
        try
        {
            var sr = new StreamReader(path);

            string s = sr.ReadLine();
            s = sr.ReadLine();
            string[] temp = null;

            while (s != null)
            {
                temp = s.Split(',');

                string zonaN = temp[0];
                string zona = temp[1];
                string address = temp[2];
                string city = temp[3];
                string phone = temp[4];
                string location = temp[5] +" "+ temp[6];


                if (city.Equals(cityF))
                {
                    militaryBases.Add(new MilitaryBase(zonaN, zona, address, city, phone, location));
                }

                s = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception)
        {
            MessageBox.Show("Error en la carga de los datos");
        }

    }

        public void filterZona(string zonaF)
        {
            try
            {
                var sr = new StreamReader(path);

                string s = sr.ReadLine();
                s = sr.ReadLine();
                string[] temp = null;

                while (s != null)
                {
                    temp = s.Split(',');

                    string zonaN = temp[0];
                    string zona = temp[1];
                    string address = temp[2];
                    string city = temp[3];
                    string phone = temp[4];
                    string location = temp[5].Substring(1, temp[5].Length - 1) + temp[6].Substring(1, temp[6].Length - 1);


                    if (zona.Contains(zonaF))
                    {
                        militaryBases.Add(new MilitaryBase(zonaN, zona, address, city, phone, location));
                    }

                    s = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la carga de los datos");
            }

        }

    }

}




