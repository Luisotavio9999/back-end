namespace Models
{

    public class Pessoa
    {
        //atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        public int anoNascimento { get; set; }

        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }

        //metodo da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} esta cantando");
        }
        public void Informacoes()
        {
            Console.WriteLine($"{nome} tem o email {email}, nasceu em {anoNascimento} e tem {idade}");
        }

    }

}