  Console.WriteLine("informe o mês?");
  int diaMes = int.Parse(Console.ReadLine());
  
  switch (diaMes)
    {
        case 1:
            Console.WriteLine("mês 1 janeiro e tem 31 dias");
            break;
        case 2:
            Console.WriteLine("mês 2 fevereiro 28 a 29 dias");
            break;
        case 3:
            Console.WriteLine("mês 3 março 31 dias");
            break;
        case 4:
            Console.WriteLine("mês 4 abril 30 dias");
            break;
        case 5:
            Console.WriteLine("mês 5 maio 31 dias");
            break;
        case 6:
            Console.WriteLine("mês 6 junho 30 dias");
            break; 
        case 7:
            Console.WriteLine("mês 7 julho 31 dias");
            break;
        case 8:
            Console.WriteLine("mês 8 agosto 30 dias");
            break;
        case 9:
            Console.WriteLine("mês 9 setembro 31 dias");
            break;
        case 10:
            Console.WriteLine("mês 10 outubro 30 dias");
            break;
        case 11:
            Console.WriteLine("mês 11 novembro 31 dias");
            break;
        case 12:
            Console.WriteLine("mês 12 dezembro 30 dias");
            break;
        default:
            Console.WriteLine("mês invalido!");
            break;
    }