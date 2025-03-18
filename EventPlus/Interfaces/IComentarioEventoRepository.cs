using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IComentarioEventoRepository
    {
        //Adiconar ou Criar um novo Comentario
        void Cadastrar(IComentarioEventoRepository coemntarioEvento);
        //Apagar um comentario
        void Deletar(int idComentario);
        //Listar os comentario
        List<ComentariosEvento> Listar (Guid Id);
        //Buscar o comentario

        ComentariosEvento BuscarPrId (Guid idUsuario, Guid idEvento);
        

    }
}
