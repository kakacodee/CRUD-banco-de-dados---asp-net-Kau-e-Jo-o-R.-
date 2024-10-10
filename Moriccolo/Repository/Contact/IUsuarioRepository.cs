using Moriccolo.Models;

namespace Moriccolo.Repository.Contact
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> ObterTodosUsuarios();

        void Cadastrar(Usuario usuario);

        void Atualizar(Usuario usuario);

        Usuario ObterUsuario(int id);

        void Excluir(int id);
    }
}
