using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Meil on maja/kontor kus töötajad peaksid saama ligipääsu erinevatele ruumidele. 
            Ruumideks on: arendajate ruum, ülemuste ruum, köök, andmetöötlejate ruum.
            Töötajad jagunevad gruppidesse: Nooremarendajad, vanemarendajad, koristajad, spetsiaalkoristaja, ülemused, andmetöötlejad.

            Peauksest peaks saama sisse iga töötaja. Arendajate ruumi peaks sisse saama kõik peale andmetöötlejate. Ülemuste ruumi peaks sisse saama vanemarendajad,
            spetsiaalkoristajad ja ülemused. Kööki peaks kõik sisse saama. Andmetöötlejate ruumi peaks kõik peale nooremarendajate sisse saama.
            
            Kasutada tuleb objektorienteeritust - pärilikkus, kapseldamine, polümorfism.
            */

            new Nooremarendaja().Amet();
        }
    }
}
