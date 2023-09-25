namespace Sesi.Model
{
    public class Pantera
    {

        public decimal tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"A pantera tem {tamanho}cm de altura");
            Console.WriteLine($"A pantera pesa {peso} Kg ");
            Console.WriteLine($"A pantera é {cor} ");
            Console.WriteLine($"A pantera é da especie {especie}");
            Console.WriteLine($"A pantera se alimenta de {alimentacao}");
        }

        public void correr()
        {
            Console.WriteLine("a pantera esta correndo");
        }
        public void cacar()
        {
            Console.WriteLine("a pantera esta caçando");
        }
        public void procriando()
        {
            Console.WriteLine("a pantera esta procriando");
        }

    }
}