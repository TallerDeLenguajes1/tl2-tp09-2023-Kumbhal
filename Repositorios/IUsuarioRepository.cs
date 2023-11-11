using Usuarios;

namespace TrabajoPractico9{
    public interface IUsuarioRepository{
        public void Create (Usuario usuario);
        public void Update(int id, Usuario usuarioModificar);
        public List<Usuario> GetAll();
        public Usuario GetById(int id);
        public void Remove (int id);
    }
}