using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("ComentarioEvento")]
    public class ComentariosEvento
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "BIT")]
        [Required]
        public bool Exibe { get; set; }

        //ref.tabela Uusario
        [Required(ErrorMessage = "Usuario obrigatório!")
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]

        public Usuario? Usuario { get; set; }

        //ref.tabela Evento

        [Required(ErrorMessage = "Evento obrigatório!")

        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]

        public Evento? evento { get; set; }

    }
}
