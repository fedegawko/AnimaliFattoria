namespace Models;

public class Pecora : Animale, IComunicante
{
    public string Razza { get; set; }

    public Pecora(string nome, string colore, /*int numero, */string razza) : base(nome, colore/*, numero*/)
    {
        Razza = razza;
    }
    public override void Comunica()
    {
        Console.WriteLine("beeehhh");
    }
}