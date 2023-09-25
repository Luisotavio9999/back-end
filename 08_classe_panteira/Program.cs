using Sesi.Model;

class Program
{
    public static void Main()
    {
        var pantera1 = new Pantera();

        pantera1.tamanho = 180;
        pantera1.peso = 50;
        pantera1.cor = "preto";
        pantera1.especie = "panterapreta";
        pantera1.alimentacao = "carne";

        pantera1.correr();
        pantera1.cacar();
        pantera1.procriando();

        pantera1.Apresentar();

    }
}