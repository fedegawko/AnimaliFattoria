using System;
using System.Collections.Generic;

namespace AnimaliFattoria
{
    public class Animale
    {
        public string Nome { get; set; }
        public string Colore { get; set; }
        public int Numero { get; set; }

        public Animale(string nome, string colore, int numero)
        {
            this.Colore = colore;
            this.Numero = numero;
            this.Nome = nome;
        }

        public virtual void Comunica()
        {
            Console.WriteLine("Nuovo animale comunica");
        }
    }
}
