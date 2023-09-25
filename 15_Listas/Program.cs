using System.Collections.Generic;
namespace Sesi.Models;

public class Program
{
    public static void Main()
    {
        //criando uma lista de inteiros 
        List<int> listaNumeros = new List<int>();

        //adicionando elementos a lista
        listaNumeros.Add(10); // posiçao (0)
        listaNumeros.Add(20); // posiçao (1)
        listaNumeros.Add(45); // posiçao (2)

        //acessando os dados da lista pelo indice 
        Console.WriteLine(listaNumeros[0]);

        //contagem de elementos 
        Console.WriteLine($" neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posiçao (3)
        Console.WriteLine($" neste momento temos {listaNumeros.Count} elementos");


        List<string> listaPessoas = new List<string>();

        listaPessoas.Add("Luis");
        listaPessoas.Add("Otávio");
        listaPessoas.Add("Rodrigues");
        listaPessoas.Add("Santos");

        Console.WriteLine(listaPessoas[2]);

        //CRIANDO UMA LISTA DE NUMEROS DE ATRIBUTOS VALORES
        List<int> numero = new List<int> { 1, 2, 5, 6, 8, 9 };
        Console.WriteLine($"quantidoade de elementos na lista numeros: {numero.Count}");
        numero.Remove(5); //remover o elemento 5
        numero.RemoveAt(1); //remove o elemento no indice 1
        numero.RemoveRange(2, 0); //remove 2 elementos a partir do indice 2

        //substituindo informaçao do intem da lista 
        numero[0] = 100;

        //inteirando sobre todos os itens da lista
        foreach (int item in numero)
        {
            Console.WriteLine(item);
        }

        foreach (string item in listaPessoas)
        {
            Console.WriteLine(item);
        }

        //criando uma linha com objetos de classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //adicionando um novo aluno e alinha lista
        Aluno novoAluno = new Aluno("Pedro", 10);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("bob", 16));

        //exibindo lista alunos
        Console.WriteLine("lista aluno");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno {item.nome} tem {item.idade} anos");
        }

        //criando uma nova lista ordenada por nome
        var consulta = from aluno in listaAlunos
                       where aluno.idade == 17
                       orderby aluno.nome
                       select aluno.nome;

        foreach (var aluno in consulta)
            Console.WriteLine(aluno);
        //LINQ utilizando sistaze do metodo
        var consulta = listaAlunos
                        .where(novoAluno => Aluno.idade => 17)
                        .orderby(novoAluno => Aluno.nome)
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);            
        }



    }
}