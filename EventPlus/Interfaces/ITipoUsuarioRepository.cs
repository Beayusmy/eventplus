using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TipoUsuario tipoUsuario);
        void Deletar(Guid Id);
        List<TipoUsuario> Listar();
        TipoUsuario BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoUsuario tipoUsuario);
    }
}
