using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gmap_military.model
{
    class MilitaryBase
    {
        //ZONA,ZONA -DIM,DIRECCION,CIUDAD,TELEFONO,LOCATION
        public string address { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public string zona { get; set; }

        public string zonaN { get; set; }

        public MilitaryBase(string zonaN, string zona, string address, string city, string phone, string location)
        {
            this.zonaN = zonaN;
            this.zona = zona;
            this.address = address;
            this.city = city;
            this.phone = phone;
            this.location = location;
        }

    }
}
