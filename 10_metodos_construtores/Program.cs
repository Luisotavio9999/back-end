using Models;

public class Program
{

    public static void Main()
    {

        //criando um objeto da classe pessoa
        //instanciando sem um metodo construtor
        /*
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Douglas";
        pessoa1.idade = 25;
        pessoa1.Cantar();

        //alternativa para a criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa
        {
            nome = "Ricardo",
            idade = 22
        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Douglas", 35, "Douglas.camata@docente.senai.br");
        pessoa1.Cantar();
        pessoa1.Informacoes();
        
        Pessoa pessoa2 = new Pessoa("Antartida", 20, "Antartida.naoseiondefica@docente.senai.br");
        pessoa2.Cantar();
        pessoa2.Informacoes();




    }

}