//funçao no javascript
//function nomeFunction (nome) {
//}

//funçao / metodo em c#
//public static string nomeFuncao(string nome){
 //}M╗┬³░í~±°º│♣#Àw#çÙ­+─‼­Ò­­´
 class Sesi {

    public static void Main()
    {
        MostrarMensagem("seja bem vindo");
        MostrarMensagem("SESI / Senai");
        ImprimeDataHora();
        double Potencia = Potenciacao(4);
        Console.WriteLine($"Potenciacao {Potencia}");

        ContagemRegressiva(100);
        JogoQueSouEu();
    }

    public static double Potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }

//Metodo sem parametro e sem retorno
    private static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

public static void MostrarMensagem(string mensagem)
    {
    Console.WriteLine(mensagem);
    } 

    public static void ContagemRegressiva(int n)
    {
          while (n >= 0)
          {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(2);
          }  
          Console.WriteLine("BBOOOOOOO");
              }

              public static void JogoQueSouEu()
              {
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine("            Bem vindo ao topo             ");
                Console.WriteLine("Sorteei um n° de 1 a 28, tente adivinha lp");
                Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * ");
                Console.WriteLine(""); //linha em branco
                
                Random rnd = new Random();
                int nrSorteado = rnd.Next(20);
                int nrDigitando = -1;

                do {
                    Console.WriteLine("Digite um nº");
                    nrDigitando = int.Parse(Console.ReadLine());
                    if (nrDigitando > nrSorteado)
                        Console.WriteLine("o numero digitado e MAIOR que o sorteado");
                    else if (nrDigitando < nrSorteado)
                        Console.WriteLine("o numero digitando é MELHOR que o sorteado");
                } while (nrDigitando != nrSorteado);

                Console.WriteLine("Parabens voce acertou");
              }
    
}