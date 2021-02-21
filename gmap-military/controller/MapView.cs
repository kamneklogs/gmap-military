using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmap_military.controller
{
    public partial class MapView : Form
    {

        public DataGridViewRowCollection rows { get; }

        public MapView(DataGridViewRowCollection rows)
        {
            InitializeComponent();

            this.rows = rows;


        }

        private void backToMainView(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gMapLoad(object sender, EventArgs e)
        {
            mainMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            mainMap.Position = new PointLatLng( 4.6097100,-74.0817500);

            //Aqui carga puntos

        }
    }
}
