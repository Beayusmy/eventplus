using EventPlus.Context;
using EventPlus.Domains;

namespace EventPlus.Repositories
{
    public class TipoUsuarioRepository
    {
        private readonly EventContext _context;
        public TipoUsuarioRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoUsuario tiposUsuarios)
        {
            try
            {
                TipoUsuario tiposUsuariosBuscado = _context.TipoUsuarios.Find(id)!;

                if (tiposUsuariosBuscado != null)
                {
                    tiposUsuariosBuscado.TituloTipoUsuario = tiposUsuarios.TituloTipoUsuario;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TipoUsuario BuscarPorId(Guid id)
        {
            try
            {
                TipoUsuario tiposUsuariosBuscado = _context.TipoUsuarios.Find(id)!;
                return tiposUsuariosBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoUsuario tiposUsuarios)
        {
            try
            {
                _context.TipoUsuarios.Add(tiposUsuarios);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TipoUsuario tiposUsuariosBuscado = _context.TipoUsuarios.Find(id)!;

                if (tiposUsuariosBuscado != null)
                {
                    _context.TipoUsuarios.Remove(tiposUsuariosBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TipoUsuario> Listar()
        {
            return _context.TipoUsuarios.ToList();
        }
    }
}
    
