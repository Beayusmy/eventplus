using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "O título do tipo de usuário é obrigatório."), Column(TypeName = "VARCHAR(255)")]
        public string? TituloTipoUsuario { get; set; }

    }
}
