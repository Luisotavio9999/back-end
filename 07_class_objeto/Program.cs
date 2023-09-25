//sempre que formos utilizar bibliotecas ou classes ja criadas 
//importanamos ele com using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma variavel aluno1 = instanciando da classe aluno 
        //ou seja, estamos criando nosso projeto
        var aluno1 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Luis";
        aluno1.idade = 17;
        aluno1.turma = "2° EM";
        //chamando o metodo da classe aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);

        //criando uma variavel aluno1 = instanciando da classe aluno 
        //ou seja, estamos criando nosso projeto
        var aluno2 = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1
        aluno2.nome = "Lu";
        aluno2.idade = 16;
        aluno2.turma = "2° EM";
        //chamando o metodo da classe aluno
        aluno2.Apresentar();
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
    }
}