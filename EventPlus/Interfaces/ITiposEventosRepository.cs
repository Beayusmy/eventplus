using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface ITiposEventosRepository
    {
        void Cadastrar(TipoEvento tipoevento);

        void Deletar(Guid id);

        List<TipoEvento> Listar();

        TipoEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoEvento tiposeventos);
    }
}
