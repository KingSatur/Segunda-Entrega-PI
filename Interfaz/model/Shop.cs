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


        public Shop(String s, String bus, String adr)
        {
            Subject = s;
            BusinessName = bus;
            Adress = adr;
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
