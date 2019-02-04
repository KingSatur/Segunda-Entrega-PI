using model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class TunjaC
    {
        private Dictionary<String, Shop> superMarkets;
        private Dictionary<String, Shop> autoServices;
        private Dictionary<String, Shop> cencoSud;
        private Dictionary<String, Shop> bigSurfaces;
        private Dictionary<String, Shop> wareHouses;
        private Dictionary<String, Shop> miniMarket;

        public TunjaC()
        {
            superMarkets = new Dictionary<string, Shop>();
            autoServices = new Dictionary<string, Shop>();
            cencoSud = new Dictionary<string, Shop>();
            bigSurfaces = new Dictionary<string, Shop>();
            wareHouses = new Dictionary<string, Shop>();
            miniMarket = new Dictionary<string, Shop>();
            loadData();
        }

        public Dictionary<String, Shop> SuperMarkets
        {
            get
            {
                return superMarkets;
            }
            set
            {
                superMarkets = value;
            }
        }

        public Dictionary<String, Shop> CencoSud
        {
            get
            {
                return cencoSud;
            }
            set
            {
                cencoSud = value;
            }
        }

        public Dictionary<String, Shop> AutoServices
        {
            get
            {
                return autoServices;
            }
            set
            {
                autoServices = value;
            }
        }

        public Dictionary<String, Shop> BigSurfaces
        {
            get
            {
                return bigSurfaces;
            }
            set
            {
                bigSurfaces = value;
            }
        }

        public Dictionary<String, Shop> WareHouses
        {
            get
            {
                return wareHouses;
            }
            set
            {
                wareHouses = value;
            }
        }

        public Dictionary<String, Shop> MiniMarkets
        {
            get
            {
                return miniMarket ;
            }
            set
            {
                miniMarket = value;
            }
        }


        public void loadData()
        {
            String[] allShopsInformation = File.ReadAllLines("./Supermarkets.csv");
            String[] allLatitudes = File.ReadAllLines("./Latitudes.txt");
            String[] allLongitudes = File.ReadAllLines("./Longitudes.txt");

            int i = 0;
            foreach(var shops in allShopsInformation)
            {
                var information = shops.Split(',');
                Shop m = new Shop(information[1], information[2], information[3] + " " + i, Double.Parse(allLatitudes[i]), Double.Parse(allLongitudes[i]));
                if (m.Subject.Equals("SUPERMERCADO"))
                {
                    superMarkets.Add(m.Adress, m);
                }
                else if (m.Subject.Equals("AUTOSERVICIO"))
                {
                    autoServices.Add(m.Adress, m);
                }
                else if(m.Subject.Equals("GRANDES SUPERFICIES"))
                {
                    bigSurfaces.Add(m.Adress, m);
                }
                else if(m.Subject.Equals("CENCO SUD"))
                {
                    cencoSud.Add(m.Adress, m);
                }
                else if (m.Subject.Equals("ALMACENES"))
                {
                    wareHouses.Add(m.Adress, m);
                }
                else if (m.Subject.Equals("MINIMERCADO"))
                {
                    miniMarket.Add(m.Adress, m);
                }
                i++; 
            }
   
        }

        
 
       
     
 



    }
}
