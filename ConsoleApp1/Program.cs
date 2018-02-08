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
            bool State = false;
            int Valik = 0;
            while (State == false)
            {
                Console.WriteLine("Mis on teie amet?\n1) Nooremarendaja\n2) Vanemarendaja\n3) Koristaja\n4) Spetsiaalkoristaja\n5) Ülemused\n6) Andmetöötleja");
                State = true;
                var RawInput = Console.ReadLine();
                State = Int32.TryParse(RawInput, out Valik);
                if (State == true)
                {
                    if (Valik <= 0 | Valik >= 7)
                    {
                        State = false;
                        Console.Clear();
                        Console.WriteLine("Vale valik! Proovige uuesti.\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Vale valik! Proovige uuesti.\n");
                }
            }

            if (Valik == 1) new Nooremarendaja().Amet();
            else if (Valik == 2) new Vanemarendaja().Amet();
            else if (Valik == 3) new Koristaja().Amet();
            else if (Valik == 4) new Spetsiaalkoristaja().Amet();
            else if (Valik == 5) new Ülemused().Amet();
            else if (Valik == 6) new Andmetöötleja().Amet();
        }
    }
}
