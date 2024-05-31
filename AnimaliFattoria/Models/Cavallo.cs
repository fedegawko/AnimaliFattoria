namespace Models;

/*
 * competizione si intende il tipo di gara a cui il cavallo partecipa
 */
public class Cavallo : Animale
{
    public bool Competizione { get; set; }

    public Cavallo(string nome, string colore, int numero, bool competizione) : base(nome, colore)
    {
        this.Competizione = competizione;
    }

    public override void Comunica()
    {
        Console.WriteLine("hiiii");
    }

}

