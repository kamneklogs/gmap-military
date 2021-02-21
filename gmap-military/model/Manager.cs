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
            //refresh();

            string[] lines = System.IO.File.ReadAllLines(path);

            if (lines.Length > 1)
            {

                for (int i = 1; i < lines.Length; i++)
                {

                    string[] data = Regex.Split(lines[i], ",");

                    if (data.Length > 0)
                    {
                        msg.Add(data[3]);

                        System.Data.DataRow row = table.NewRow();
                        for (int j = 0; j < data.Length; j++)
                        {
                            try
                            {
                                row[j] = data[j];
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("WARNING");
                            }
                        }

                        table.Rows.Add(row);

                    }


                }

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

                        string address = temp[2];
                        string city = temp[3];
                        string phone = temp[4];
                        string location = temp[5].Substring(1, temp[5].Length - 1) + temp[6].Substring(1, temp[6].Length - 1);

                        militaryBases.Add(new MilitaryBase(address, city, phone, location));

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
}
