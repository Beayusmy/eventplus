using EventPlus.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Context
{
    public class EventContext : DbContext
    {

            public EventContext()
            {

            }
            public EventContext(DbContextOptions<EventContext> options) : base(options)
            {
            }
            /// <summary>
            /// Define que as classes se tranformarao em tabelas no BD
            /// </summary>

            public DbSet<ComentariosEvento> ComentarioEvento { get; set; }
            public DbSet<Evento> Evento { get; set; }
            public DbSet<Instituicao> Instituicao { get; set; }
            public DbSet<PresencasEvento> PresencasEvento { get; set; }
            public DbSet<TipoEvento> TipoEvento { get; set; }
            public DbSet<TipoUsuario> TipoUsuarios { get; set; }
            public DbSet<Usuario> Usuario { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server = NOTE04-S28\\SQLEXPRESS; Database = EventPlus; User Id=sa; Pwd = Senai@134; TrustServerCertificate=true;");

                }
            }
        }
    }



