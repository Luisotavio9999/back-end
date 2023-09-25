class Program
{
    public static void Main()
    {
        //chamar a recebe valor do metodo dobro
        Console.WriteLine("insira o numero a ser calculado");
        int Numero = int.Parse(Console.ReadLine());

        Console.WriteLine(Dobro(Numero));
        //exibir o valor da variavel
        Console.WriteLine(Divisao(Numero));
        //exibir o valor da variavel
        Tabuada();
        ResumoSalarios();

    }

    public static int Dobro(int valor)
    {


        //criar variavel para calcular o dobro 
        int Dobro = valor * 2;
        //retornar o valor da funçao

        return Dobro;
    }

    public static int Divisao(int valor)
    {

        int Divisao = valor / 2;
        return Divisao;
    }

    public static void Tabuada()
    {
        Console.WriteLine("insira o numero para a tabuada");
        int NumeroTabuada = int.Parse(Console.ReadLine());
        int Contador = 1;

        while (Contador <= 10)
        {
            Console.WriteLine($"{NumeroTabuada} x {Contador} = {NumeroTabuada * Contador}");
            Contador++;
        }

    }

    public static void ResumoSalarios()
    {
        int SomaSalarios = 0;
        int MenorSalario = 100000;
        int MaiorSalario = 0;
        int SalarioEmpregado = 0;

        do
        {
            Console.WriteLine("Digite o Salario do empregado:");
            SalarioEmpregado = int.Parse(Console.ReadLine());

            if(SalarioEmpregado > 0)
            SomaSalarios = SomaSalarios + SalarioEmpregado;
            //SomaSalarios += SlarioEmpregado;
            if (SalarioEmpregado > MaiorSalario)
            {
                MaiorSalario = SalarioEmpregado;
            }
            if(SalarioEmpregado < MenorSalario && SalarioEmpregado > 0)
            {
                MenorSalario = SalarioEmpregado;
            }

        } while (SalarioEmpregado > 0);

        Console.WriteLine($"A soma dos salarios é {SomaSalarios} e o Maior salario é {MaiorSalario} e o menor salario é {MenorSalario}");
    }


}