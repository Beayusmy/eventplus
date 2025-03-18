using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus.Domains
{
    [Table("PresencasEventos")]
    public class PresencasEvento
    {

        [Key]
        public Guid IdPresenca { get; set; }

        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario? Usuario { get; set; }

        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public Evento? Evento { get; set; }


    }
}
