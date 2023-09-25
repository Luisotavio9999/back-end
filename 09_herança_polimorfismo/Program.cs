//classe pai que sea herdada pelo filho - SuperClasse
class Animal 
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

//classe filha que herdara da classe animal
//recebera todos os atributos e metodods da SuperClasse
class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"o cachorro {cor} esta latindo");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("o gato esta miando ");
    }
}


class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}