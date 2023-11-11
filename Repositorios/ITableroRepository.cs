using Tableros;

namespace TrabajoPractico9{
    public interface ITableroRepository{
        public void Create(Tablero tableroNuevo);
        public void Update(int id, Tablero tableroModificar);
        public Tablero GetById(int id);
        public List<Tablero> GetAll();
        public List<Tablero> GetAllById(int idUsuario);
        public void Remove(int id);

    }
}