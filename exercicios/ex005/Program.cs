class Program
{

    public static void Main()
    {
        ListaDoChurrasco();
        SonhoDeConsumo();
    }
    public static void ListaDoChurrasco()
    {

        string[] lista = new string[6];

        Console.WriteLine("insira os 6 ingredientes ");
        lista[0] = Console.ReadLine();
        lista[1] = Console.ReadLine();
        lista[2] = Console.ReadLine();
        lista[3] = Console.ReadLine();
        lista[4] = Console.ReadLine();

        Console.WriteLine("insira a quantidade de carne a ser comprada");
        lista[5] = Console.ReadLine();

        Array.Sort(lista);

        foreach (string i in lista)
        {
            Console.WriteLine(i);
        }
}
        public static void SonhoDeConsumo()
        {

            string[] sonhos = new string[3];
            decimal[] valores = new decimal[3];
            decimal total = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($" insira o seu {i} sonho ");
                string sonho = Console.ReadLine();
                Console.WriteLine($"informe o valor do {i} sonho");
                decimal valor = decimal.Parse(sonho);
                sonhos[i] = sonho;
                valores[i] = valor;

            }

            foreach (decimal val in valores)
            {
                total = total + val;
            }
            Console.WriteLine($"Seus sonhos custarão aprox... R${total}");

        }

    



}