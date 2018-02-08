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
            Console.WriteLine("Teie amet on " + Name);
        }
    }

    class Nooremarendaja : Töötaja
    {
        public Nooremarendaja()
        {
            Name = "Nooremarendaja";
        }

        public void Amet()
        {
            base.Amet();
        }
    }

    class Vanemarendaja : Töötaja
    {
        public Vanemarendaja()
        {
            Name = "Vanemarendaja";
        }
    }

    class Koristaja : Töötaja
    {
        public Koristaja()
        {
            Name = "Koristaja";
        }
    }

    class Spetsiaalkoristaja : Töötaja
    {
        public Spetsiaalkoristaja()
        {
            Name = "Spetsiaalkoristaja";
        }
    }

    class Ülemused : Töötaja
    {
        public Ülemused()
        {
            Name = "Ülemused";
        }
    }

    class Andmetöötleja : Töötaja
    {
        public Andmetöötleja()
        {
            Name = "Andmetöötleja";
        }
    }
}
