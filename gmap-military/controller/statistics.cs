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
    public partial class statistics : Form
    {
        private DataGridViewRowCollection rows { get; set; }
        private List<string> cities;
        private List<string> zones;
        public statistics(DataGridViewRowCollection rows)
        {
            InitializeComponent();
            this.rows = rows;

            cities = new List<string>();
            zones = new List<string>();


            foreach (DataGridViewRow item in rows)
            {


                if (!zones.Contains((string)item.Cells[0].Value))
                {
                    zones.Add((string)item.Cells[0].Value);
                }

                if (!cities.Contains((string)item.Cells[3].Value))
                {
                    cities.Add((string)item.Cells[3].Value);
                }

            }


            double total = Convert.ToDouble(rows.Count);

            double[] proportionZones = new double[zones.Count];
            for (int i = 0; i < proportionZones.Length; i++)
            {
                proportionZones[i] = 0;
            }

            double[] proportionCities = new double[cities.Count];
            for (int i = 0; i < proportionCities.Length; i++)
            {
                proportionCities[i] = 0;
            }


            for (int i = 0; i < zones.Count; i++)
            {
                for (int j = 0; j < rows.Count; j++)
                {
                    if (((string)rows[j].Cells[0].Value).Equals(zones[i]))
                    {
                        proportionZones[i] += 1.0;
                    }
                }
            }

            for (int i = 0; i < cities.Count; i++)
            {
                for (int j = 0; j < rows.Count; j++)
                {
                    if (((string)rows[j].Cells[3].Value).Equals(cities[i]))
                    {
                        proportionCities[i] += 1.0;
                    }
                }
            }

            for (int i = 0; i < proportionCities.Length; i++)
            {
                pieStat.Series["citiesSerie"].Points.AddXY(cities[i], proportionCities[i] / total);
            }
            for (int i = 0; i < proportionZones.Length; i++)
            {
                donutStat.Series["zonesSerie"].Points.AddXY(zones[i], proportionZones[i] / total);
                barsStat.Series["zonesSerie"].Points.AddXY(zones[i], proportionZones[i] / total);
            }
        }

    }
}
