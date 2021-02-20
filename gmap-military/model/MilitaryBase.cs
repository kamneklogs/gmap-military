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
        private string address { get; set; }
        private string city { get; set; }
        private string phone { get; set; }
        private string location { get; set; }

        public MilitaryBase(string address, string city, string phone, string location)
        {
            this.address = address;
            this.city = city;
            this.phone = phone;
            this.location = location;
        }

    }
}
