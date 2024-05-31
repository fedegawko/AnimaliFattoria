namespace Models;

public class Mucca : Animale, IComunicante
{
    public string Allevamento { get; set; }

    public Mucca(string nome, string colore, int numero, string allevamento) : base(nome, colore, numero)
    {
        this.Allevamento = allevamento;
    }

    public override void Comunica()
    {
        Console.WriteLine("muuuh");
    }

}