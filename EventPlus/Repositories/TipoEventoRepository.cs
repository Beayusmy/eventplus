using EventPlus.Context;
using EventPlus.Domains;
using EventPlus.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventPlus.Repositories
{
    public class TipoEventoRepository : ITiposEventosRepository
    {
        //Variavel que armazena o context 
        
        private readonly EventContext _context;
        
        //Metodo construtor
        
        public TipoEventoRepository(EventContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TipoEvento tiposeventos)
        {
            try
            {
                TipoEvento tiposEventosBuscados = _context.TipoEvento.Find(id)!;

                if (tiposEventosBuscados != null)
                {
                    tiposEventosBuscados.TituloTipoEvento = tiposeventos.TituloTipoEvento;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
          

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
            TipoEvento tiposEventosBuscado = _context.TipoEvento.Find(id)!;
            return tiposEventosBuscado;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoEvento tipoevento)
        {
            try
            {
                _context.TipoEvento.Add(tipoevento);
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
                    TipoEvento tiposEventos = _context.TipoEvento.Find(id)!;

                    if (tiposEventos != null)
                    {
                        _context.TipoEvento.Remove(tiposEventos);
                    }
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        

        public List<TipoEvento> Listar()
        {
            return _context.TipoEvento.ToList();
        }

        


    }
}
