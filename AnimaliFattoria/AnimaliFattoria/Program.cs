using System;
using System.Collections.Generic;

namespace AnimaliFattoria
{
    public class Program
    {
        public static void Main()
        {
            string scelta2;

            List<Animale> animali = new List<Animale> {
            new Pecora("pecora","bianca", 20, "caucasica"),
            new Cavallo("cavallo","marrone", 2, true),
            new Mucca("mucca","bianconera", 50,"collinare"),
        };

        // stampa tutti gli animali
        Console.WriteLine("Stampiamo tutti gli animali");
        foreach(var a in animali){

                if (a is Pecora pecora)
                {
                    Console.WriteLine($"{pecora.Nome} {pecora.Colore} {pecora.Numero} {pecora.Razza}");
                }
                else if (a is Cavallo cavallo)
                {
                    Console.WriteLine($"{cavallo.Nome} {cavallo.Colore} {cavallo.Numero} {cavallo.Competizione}");
                }
                else if (a is Mucca mucca)
                {
                    Console.WriteLine($"{mucca.Nome} {mucca.Colore} {mucca.Numero} {mucca.Allevamento}");
                }
                Console.WriteLine();

            }

        // output dei versi degli animali
            Console.WriteLine("###############");
            Console.WriteLine("Adesso stampiamo tutti i loro versi");
            foreach (var a in animali)
            {
                a.Comunica();
            }
            Console.WriteLine("###############");
            do
            {
                Console.WriteLine("Scegli un animale digitando p per pecora, c per cavallo, m per mucca");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "p":
                        Pecora p = (Pecora)animali[0];
                        Console.WriteLine($"{p.Colore} {p.Numero} {p.Razza}");
                        break;
                    case "c":
                        Cavallo c = (Cavallo)animali[1];
                        Console.WriteLine($"{c.Colore} {c.Numero} {c.Competizione}");
                        break;
                    case "m":
                        Mucca m = (Mucca)animali[2];
                        Console.WriteLine($"{m.Colore} {m.Numero} {m.Allevamento}");
                        break;
                    default:
                        Console.WriteLine("Non ho trovato l'animale :(");
                        break;
                }
                Console.WriteLine("Vuoi continuare? Premi 's' o 'n'");
                scelta2 = Console.ReadLine();
            } while (scelta2 == "s");

            Console.WriteLine("###############");

            // Aggiunta animale

            Console.WriteLine("Aggiungi un animale, quale nome ha questo animale?");
            string name = Console.ReadLine();
            Console.WriteLine("Che colore è?");
            string colour = Console.ReadLine();
            Console.WriteLine("Quanti sono?");
            int num = int.Parse(Console.ReadLine());


            Console.WriteLine("###############");

            Animale nuovoAnimale = new Animale(name,colour, num);
            animali.Add(nuovoAnimale);

            Console.WriteLine("Stampo l'elenco aggiornato:");
            foreach (var a in animali)
            {

                if (a is Pecora pecora)
                {
                    Console.WriteLine($"{pecora.Colore} {pecora.Numero} {pecora.Razza}");
                }
                else if (a is Cavallo cavallo)
                {
                    Console.WriteLine($"{cavallo.Colore} {cavallo.Numero} {cavallo.Competizione}");
                }
                else if (a is Mucca mucca)
                {
                    Console.WriteLine($"{mucca.Colore} {mucca.Numero} {mucca.Allevamento}");
                }
                else
                {
                    Console.WriteLine($"{a.Nome} {a.Colore} {a.Numero}");
                }
                Console.WriteLine();
            }

            // eliminare un animale 

            Console.WriteLine("Quale animale vuoi elimiare? Scrivi il suo nome");
            string elimina = Console.ReadLine();
            Animale eliminato = animali.Find(a=>a.Nome.Equals(elimina,StringComparison.OrdinalIgnoreCase));
            if (eliminato != null)
            {
                animali.Remove(eliminato);

            }
            

            foreach (var a in animali)
            {
                Console.WriteLine(a);
            }
        }
    }
  }


