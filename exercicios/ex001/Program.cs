Console.WriteLine("digite o nome do aluno");
string nomeAluno = Console.ReadLine();

Console.WriteLine("digite a nota 1");
int nota = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota 2");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota 3");
int nota3 = int.Parse(Console.ReadLine());

int media = (nota + nota2 + nota3) / 3;

string resultado = (media >= 7) ? $"O aluno {nomeAluno} foi aprovado com a nota {media}" : $"O aluno {nomeAluno} foi reprovado com a nota {media}";
    Console.WriteLine(resultado);

 
