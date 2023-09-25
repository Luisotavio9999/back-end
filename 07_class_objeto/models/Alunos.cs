//O namespace é um noome que usaremos para fazer referencia quando usarmos
//em outras classes 
namespace Sesi.Model
{
    //declarando nossa classe aluno 
    public class Aluno
    {
        //declarando atributos (propriedades) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        public string nrFaltas { get; set; }

        //riando um metodo
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome}, eu tenho {idade} anos e estudo na {turma} !!!");
        }

        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }

        public void ResumirFaltas()
        {
            Console.WriteLine($"{nome} voce tem {nrFaltas} faltas");
            
        }

        public void JustificarFaltas(int nr)
        {
            nrFaltas = nrFaltas - nr;
        }


        }
}