using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IPresencaEventosRepository
    {

        //Inscrever no evento
        void Increver(IPresencaEventos incricao);
        //Deletar a presenca
        void Deletar(Guid Id);
        //Atualizar a nossa presenca no evento
        void Atualizar(Guid id, PresencasEvento presencas);
        //Listar as presencas por usuario(id)
        List<PresencasEvento> ListarMinahsPresencas(Guid id);
        //Listar as presencas
        List<PresencasEvento> Listar();
        //Buscar a presenca por ID
        PresencasEvento BuscarPorId(Guid id);

    }
}
