using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventPlus.Domains
{
    public class Presenca
    {
        [Key]
        public int IdPresenca { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("Evento")]
        public int IdEvento { get; set; }
        public Evento? Evento { get; set; }

        [Required(ErrorMessage = "A situação da presença é obrigatória."), Column(TypeName = "VARCHAR(60)")]
        public string? Situacao { get; set; }

    }
}
