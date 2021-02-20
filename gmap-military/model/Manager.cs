using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmap_military.model
{
    class Manager
    {
        const string path = "..\\data\\dataset.csv";

        private ICollection<MilitaryBase> militaryBases;

        public Manager()
        {

        }

        public bool loadData()
        {

            bool success = false;
            militaryBases = new List<MilitaryBase>();

            string[] temp = null;
            MilitaryBase baseTemp = null;
            try
            {
                var sr = new StreamReader(path);
                string s = sr.ReadLine();
                s = sr.ReadLine();
                while (s != null)
                {

                    temp = s.Split(',');
                    //ZONA 0,ZONA -DIM 1,DIRECCION 2,CIUDAD 3,TELEFONO 4,LOCATION 5
                    baseTemp = new MilitaryBase(temp[2], temp[3], temp[4], temp[5]);
                    militaryBases.Add(baseTemp);

                    s = sr.ReadLine();
                }
                sr.Close();
                success = true;

            }
            catch (Exception)
            {

                success = false;

                MessageBox.Show("Ocurrio un error");
                throw;
            }



            return success;
        }


    }
}
