using System.IO;

public class Program
{
    public static string caminhoArquivo = "arquivo/arquivo.txt";
    public static void Main()
    {
        //GravarArquivo();
        LerArquivo();
    }
    public static void LerArquivo()
    { 
        try
        {
            string caminhoArquivo = "arquivo/arquivo.txt";
            //verificar se o arquivo existe
            if (File.Exists(caminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando e executado quando
                //a verificação do if é false ou seja o arquivo não existe 
                File.Create(caminhoArquivo);
            }

            //instanciando um objeto de Classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"ocorreu um erro ao ler o arquivo: {erro.Message}");
             }
    }
    public static void GravarArquivo()
    {
        try
        {
            //instanciando um objeto da class StreamWriter pra gravar um arquivo
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", true))
            {
                string Escrita = Console.ReadLine();

                arquivo.WriteLine(Escrita);
            }
        }

        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}