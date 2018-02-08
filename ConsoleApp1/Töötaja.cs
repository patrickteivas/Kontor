using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Töötaja
    {
        public string Name;
        protected bool PeauksAccess = true;
        protected bool ArendajateRuumAccess = false;
        protected bool ÜlemusteRuumAccess = false;
        protected bool KöökAccess = true;
        protected bool AndmetöötlejateRuumAccess = false;

        public void Amet()
        {
            Console.Clear();
            Console.WriteLine("Teie amet on: " + Name.ToLower() + "\n\nTeil on ligipääs järgmistele ruumidele:");
            int i = 0;
            if (PeauksAccess == true)
            {
                i++;
                Console.WriteLine(i + ") Peauksele");
            }
            if (ArendajateRuumAccess == true)
            {
                i++;
                Console.WriteLine(i + ") Arendajate ruumile");
            }
            if (ÜlemusteRuumAccess == true)
            {
                i++;
                Console.WriteLine(i + ") Ülemuste ruumile");
            }
            if (KöökAccess == true)
            {
                i++;
                Console.WriteLine(i + ") Köögile");
            }
            if (AndmetöötlejateRuumAccess == true)
            {
                i++;
                Console.WriteLine(i + ") Andmetöötlejate ruumile");
            }
        }
    }

    class Nooremarendaja : Töötaja
    {
        public Nooremarendaja()
        {
            Name = "Nooremarendaja";
            ArendajateRuumAccess = true;
        }
    }

    class Vanemarendaja : Töötaja
    {
        public Vanemarendaja()
        {
            Name = "Vanemarendaja";
            ArendajateRuumAccess = true;
            ÜlemusteRuumAccess = true;
            AndmetöötlejateRuumAccess = true;
        }
    }

    class Koristaja : Töötaja
    {
        public Koristaja()
        {
            Name = "Koristaja";
            ArendajateRuumAccess = true;
            ÜlemusteRuumAccess = true;
            AndmetöötlejateRuumAccess = true;
        }
    }

    class Spetsiaalkoristaja : Töötaja
    {
        public Spetsiaalkoristaja()
        {
            Name = "Spetsiaalkoristaja";
            ArendajateRuumAccess = true;
            AndmetöötlejateRuumAccess = true;
        }
    }

    class Ülemused : Töötaja
    {
        public Ülemused()
        {
            Name = "Ülemused";
            ArendajateRuumAccess = true;
            ÜlemusteRuumAccess = true;
            AndmetöötlejateRuumAccess = true;
        }
    }

    class Andmetöötleja : Töötaja
    {
        public Andmetöötleja()
        {
            Name = "Andmetöötleja";
            AndmetöötlejateRuumAccess = true;
        }
    }
}
