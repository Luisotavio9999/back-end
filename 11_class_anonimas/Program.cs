public class Program
{
    public static void Main()
    {
        //criando uma classe anonima (classe sem definiçao inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine(pessoa1.nome, pessoa1.idade);

        Console.WriteLine($"a pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"a pessoa é {pessoa2.nome} e tem {pessoa2.email} anos");

        //pessoa.nome = "Douglas";

        //criar 2 objrtos de classe anonima de carro

        var carro1 = new {
            marca = "ford",
            modelo = "Ranger",
            ano = 2019
        };
        var carro2 = new {
            marca = "vw",
            modelo = "gol",
            ano = 2020
        };

        Console.WriteLine($"a marca do carro é {carro1.marca}, com o modelo {carro1.modelo} que foi deito no ano {carro1.ano}");
        Console.WriteLine($"a marca do carro é {carro2.marca}, com o modelo {carro2.modelo} que foi deito no ano {carro2.ano}");

    }
}