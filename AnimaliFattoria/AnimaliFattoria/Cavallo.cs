using System;
using System.Collections.Generic;

namespace AnimaliFattoria
{
    /*
     * competizione si intende il tipo di gara a cui il cavallo partecipa
     */
    public class Cavallo : Animale, IComunicante
    {
        public bool Competizione { get; set; }


        public Cavallo(string nome, string colore, int numero, bool competizione) : base(nome, colore, numero)
        {
            this.Competizione = competizione;
        }

        public override void Comunica()
        {
            Console.WriteLine("hiiii");
        }

    }
}
