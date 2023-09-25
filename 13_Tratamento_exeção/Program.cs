
public class Program
{
    public static void Main()
    {
        // o try serve para tratar um erro e nao parar a execuçao do programa
        //se ocorrer qualquer erro dentro do bloco try, o sistema interrompe
        //a execuçao do bloco e vai para o catch
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voce digitou o numero° {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O Resultado é: {resultado}");
        }
        //tratando exceção de overflow (estouro de campo)
        catch (OverFlowException)
        {
            onsole.WriteLine($"Este numero inteiro é maior que o suportado");
        }
        //tratando exceçao de erro de formato 
        catch (FormatException)
        {
            Console.WriteLine($"Erro: Digite um numero inteiro");
        }
        //catch e o tratamento do erro, normalmente colocamos as mensagens de acordo
        //com o tipo do erro, para melhor compreendimento do usuario 
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        //o finally e um bloco executado independentemente se ocorrer um erro ou não
        finally
        {
            Console.WriteLine($"entrando no finally");
        }

    }
}