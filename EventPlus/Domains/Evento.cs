using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Domains
{
    [Table("Evento")]
    [Index(nameof(Evento), IsUnique = true)]
    public class Evento
    {
        [Key]
        public int IdComentario { get; set; }

        [Required(ErrorMessage = "O campo Exibe é obrigatório.")]
        public bool Exibe { get; set; }

        [Required(ErrorMessage = "A descrição do comentário é obrigatória."), Column(TypeName = "TEXT")]
        public string? Descricao { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("Evento")]
        public int IdEvento { get; set; }
        public Evento? evento { get; set; }

        //Adicionar instituicao

        public Instituicao? Instituicao { get; set; }


        public PresencasEvento? PresencasEventos { get; set; }  

    }
}
