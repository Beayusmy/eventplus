using EventPlus.Domains;

namespace EventPlus.Interfaces
{
    public interface IUsuariosRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario BuscarPorId(Guid id);

        Usuario BuscarPorEmailESenha(String email, string senha);
    }
}
