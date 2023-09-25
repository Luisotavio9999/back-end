//somente declarando uma variavel do tipo inteira e sem valor 
//    int numl;

//declarando uma variavel do tipo inteira e atribuindo o numero 5
//   int num2 = 5;


//declarando variavel string 
//    string nomeAluno = 'paulo';

//variavel do tipo logico (true ou false)
//    bool resultado = true

//variavel do tipo double valor com variaçao 
//    double cordenada = 1.0023535;

//variavel do tipo decimal - utilizado para valores
//    decimal valor = 1.00M;

    int idade = 17;
    string meuNome = "Luis"; 
    Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
    Console.WriteLine("");
    Console.WriteLine("em qual cidade voce naceu?");
    //ReadLine serve apensas para que eu receba uma informacao do usuario 
    //e armazena em uma variavel    
    string nomeCidade = Console.ReadLine();
    Console.WriteLine($"voce nasceu em {nomeCidade}");
