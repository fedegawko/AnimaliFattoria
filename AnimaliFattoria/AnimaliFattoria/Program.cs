using Models;

namespace AnimaliFattoria
{
    public class Program
    {
        private static List<Animale> _animali = new List<Animale>();

        public static void Main()
        {
            GeneraAnimali();

            ElencoAnimali();

            var animale = ScegliAnimale();

            Console.ReadKey();
        }

        public static void GeneraAnimali()
        {
            _animali.Clear();
            _animali.Add(new Pecora("Dolly", "Nero", "Merino"));
            _animali.Add(new Pecora("Meldy", "Bianco", "Merino"));
            _animali.Add(new Pecora("Cindy", "Rosa", "Merino"));
        }

        public static void ElencoAnimali()
        {
            Console.Clear();

            Console.WriteLine(" ***** Elenco degli animali: ***** ");
            Console.WriteLine();

            for (int i = 1; i <= _animali.Count; i++)
            {
                Animale? a = _animali[i - 1];
                Console.WriteLine($"{i} - {a.Nome}");
            }

            Console.WriteLine();
        }

        public static Animale ScegliAnimale()
        {
            bool validChoice = false;
            int choice = 0;
            while (!validChoice)
            {
                Console.Write(" ***** Scegli un animale tramite numero: ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= _animali.Count)
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Scelta non valida. Digita un numero tra 1 e 4.");
                }
            }

            var animaleScelto = _animali[choice - 1];

            Console.WriteLine($"Hai scelto: {animaleScelto}");

            return animaleScelto;

        }




    }
}


