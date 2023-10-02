using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _18_CLUD_BD.Models
{
    //DataAnnotion de como sera criado o nome da tabela do BD
    [Table("Jogos")]
    public class Jogo
    {
        [Key] //Falando para o BD que este atributo sera uma chave
        public int jogoId { get; set; }
        [Required(ErrorMessage="nome é obrigatorio")]
        [MaxLength(200, ErrorMessage = "descrição pode exceder {1} caracteries")]
        public int Nome { get; set; }
        public int Descricao { get; set; }
        public int Imafem { get; set; }
        public int Ativo { get; set; }

    }
}