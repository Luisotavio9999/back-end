class Program
{
    public static void Main()
    {

        for (int i = 1; i <= 10; i += 4)
        {
            Console.WriteLine($"estou passando pela {i}ª vez no form");
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($" variavel sesi vale {sesi}");
        }

        int numero = 87;
        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($" {numero} x {cont} = {numero * cont}");
        }
        //declarando um vetor
        string[] alunos = new string[35];

        //atribuindo valores aos vetores
        alunos[1] = "abner";
        alunos[2] = "adalberto kaio";
        alunos[3] = "ana carolina";
        alunos[34] = "samuel";

        foreach (string aluno in alunos)
        {
            if (aluno != null)
                Console.WriteLine(aluno);
        }



        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;


        int laura = 0; //soma
        int jorge = 0; //maior
        int bianca = 100; //menor
        foreach (int enzo in cadeiras)
        {
            laura = laura + enzo;
            if (enzo > jorge)
            {
                jorge = enzo;
            }

            if (enzo < bianca)
            {
                bianca = enzo;
            }
        }
        Console.WriteLine($"Soma: {laura}, Maior {jorge} menor {bianca}");

        Array.Sort(cadeiras);

        for (int x = 0; x < cadeiras.Length; x++)
        {
            Console.WriteLine($"Pos {x} - valor {cadeiras[x]}");
        }

    }
}
