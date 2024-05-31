namespace Models;

public abstract class Animale : IComunicante
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

    public abstract void Comunica();
}
