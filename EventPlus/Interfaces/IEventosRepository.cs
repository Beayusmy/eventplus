using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IEventosRepository
    {
        //Cadastrar um evento
        void Cadastrar(Evento evento);

        //Atualizar um evento
        void Atualizar(Guid id, Evento evento);

        //Deletar um evento
        void Deletar(Guid Id);

        //Listar os eventos
        List<Evento> Listar();

        //Buscar os eventos por Id 
        Evento BuscarPorId(Guid Id);

        //Listar os eventos por Id
        List<Evento> ListarPorId (Guid Id);

        //Listar proximos eventos 
        List<Evento> ProximosEvento();
    }
}
