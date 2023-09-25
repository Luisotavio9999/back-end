using conta.Model;
class Program
{
    public static string[] bank;

    public static void Main()
    {

        Contacorrente conta1 = new Contacorrente();

        Console.Clear();
        Console.WriteLine("    Bem-vindo ao bank   ");
        Console.WriteLine("----------------------------");

        conta1.Conta();

        conta1.titular = Console.ReadLine();


        string opcao = "";

        do
        {
            Console.WriteLine(" ######## MENU ########");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    conta1.ConsultarSaldo();

                    break;
                case "2":
                    conta1.Depositar();

                    break;
                case "3":
                    conta1.Saque();
                    break;
                default:
                    Console.WriteLine("opcao invalido");
                    break;
            }

        } while (opcao != "");
    }
}
