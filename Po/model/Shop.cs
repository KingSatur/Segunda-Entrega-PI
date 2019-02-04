using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Shop
    {

        private String subject;
        private String businessName;
        private String adress;
        private double latitud;
        private double longitud;


        public Shop(String s, String bus, String adr, double l, double lon)
        {
            Subject = s;
            BusinessName = bus;
            Adress = adr;
            Latitud = l;
            Longitud = lon;
        }

        public double Latitud
        {
            get
            {
                return latitud;
            }
            set
            {
                latitud = value;
            }
        }

        public double Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }


        public String Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public String BusinessName
        {
            get
            {
                return businessName;
            }
            set
            {
                businessName = value;
            }

        }

        public String Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }



        








    }
}
