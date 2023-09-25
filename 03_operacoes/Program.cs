    Console.WriteLine("digite o valor de x:");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o valor de y:");
    int y = int.Parse(Console.ReadLine());

    // exemplos de operadores aritimeticos
    int soma = x + y;
    int subtracao = x - y;
    int multiplicacao = x * y;
    int divisao = x / y;
    int resto = x % y;
    int restoDiv2 = x % 2; //calculando o resto da divisao de x / 2
    int restoDiv1 = y % 2;

    //console para exibir na tela as variaçoes em cada linha 
    //soma: 15

    Console.WriteLine($"{soma}");
    Console.WriteLine($"{subtracao}");
    Console.WriteLine($"{multiplicacao}");
    Console.WriteLine($"{divisao}");
    Console.WriteLine($"{resto}");

    //operadores ternario
    //condicoes ? se verdade : senao
    string resultado = (restoDiv2 == 0) ? $"o numero {x} é par" : $"o numero {x} é impar";
    Console.WriteLine(resultado);

    string resultado2 = (restoDiv1 == 0) ? $"o numero {y} é par" : $"o numero {y} é impar";
    Console.WriteLine(resultado2);

    int diaSemana = 3;
    //aprendendo o switch case
    switch (diaSemana)
    {
        case 1:
            Console.WriteLine("hoje é domingo");
            break;
        case 2:
            Console.WriteLine("hoje é segunda");
            break;
        case 3:
            Console.WriteLine("hoje é terça");
            break;
        case 4:
            Console.WriteLine("hoje é quarta");
            break;
        case 5:
            Console.WriteLine("hoje é quinta");
            break;
        case 6:
            Console.WriteLine("hoje é sexta");
            break;
        case 7:
            Console.WriteLine("hoje é sabado");
            break;
        default:
            Console.WriteLine("dia invalido!");
            break;
    }