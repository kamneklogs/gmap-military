using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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

        public List<string> data;

        private List<PointLatLng> points;

        private GMapOverlay markers;


        public MapView(DataGridViewRowCollection rows)
        {
            InitializeComponent();

            this.rows = rows;

            data = new List<string>();

            points = new List<PointLatLng>();

            markers = new GMapOverlay("puntos");

            foreach (DataGridViewRow item in rows)
            {
                data.Add((string)item.Cells[2].Value + ";" + (string)item.Cells[5].Value);
            }

        }

        private void backToMainView(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gMapLoad(object sender, EventArgs e)
        {
            mainMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            mainMap.Position = new PointLatLng(4.6097100, -74.0817500);

            mainMap.Overlays.Add(markers);

            //Aqui carga puntos

            foreach (string item in data)
            {
                string[] temp = item.Split(';');
                string[] loc = temp[1].Split(' ');

                double lat = double.Parse(loc[0]); //Si te pc esta en español, usa comas con los decimales
      
                double lon = double.Parse(loc[2]);
                

                PointLatLng p = new PointLatLng(lat, lon);
                points.Add(p);
            }

            foreach (PointLatLng p in points) //P es un punto creado con latitud y longitud
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker); //Aqui se agrega el marcador a la capa
            }

        }
    }
}
