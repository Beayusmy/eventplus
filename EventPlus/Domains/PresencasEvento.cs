using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("PresencasEventos")]
    public class PresencasEvento
    {
        public Guid IdPresencaEvento { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "Situacao obrigatorio!")]

        public bool Situacao { get; set; }

        //ref.tabela Usuario
        [Required(ErrorMessage = "Usuario obrigatorio!")]

        public Guid IdEvento { get; set; }

        [ForeignKey("IdUsuario")]

        public Usuario? Usuario { get; set; }

        //ref.tabela Evento

        [Required(ErrorMessage = "Evento obrigatorio!")]

        public Guid IdEventos { get; set; }

        [ForeignKey("IdEvento")]

        public Evento? Evento { get; set; }


    }
}
