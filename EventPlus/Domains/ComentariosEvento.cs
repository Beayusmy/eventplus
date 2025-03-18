using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("ComentarioEvento")]
    public class ComentariosEvento
    {
        [Key]
        public int IdComentario { get; set; }

        [Required(ErrorMessage = "O campo Exibe é obrigatório.")]
        public bool Exibe { get; set; }

        [Required(ErrorMessage = "A descrição do comentário é obrigatória."), Column(TypeName = "TEXT")]
        public string? Descricao { get; set; }

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("IdEvento")]
        public int IdEvento { get; set; }
        public Evento? Evento { get; set; }

    }
}
