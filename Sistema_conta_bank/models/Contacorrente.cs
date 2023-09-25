
namespace conta.Model
{
    public class Contacorrente
    {
        public string titular { get; set; }
        public decimal saldo { get; set; }

        public void Conta()
        {
            Console.WriteLine($" Bem vindo Senhor, digite seu nome:");
            Console.WriteLine($"");
        }
        

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo}");
        }
        public void Depositar()
        {
            int valor = int.Parse(Console.ReadLine());
            saldo += valor;
            Console.WriteLine($"Deposito efetuADO");
        }

        public void Saque()
        {
            int valor = int.Parse(Console.ReadLine());
            saldo -= valor;
            Console.WriteLine($"Saque efetuADO {saldo}");
        }
    }

}