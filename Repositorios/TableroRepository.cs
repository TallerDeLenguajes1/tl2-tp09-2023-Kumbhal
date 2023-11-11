using System.Data.SQLite;
using Tableros;

namespace TrabajoPractico9{
    public class TableroRepository : ITableroRepository{
        private string cadenaConexion = "Data Source=DB/kanban.db;Cache=Shared";
        public void Create(Tablero tableroNuevo){
            var query = $"UPDATE INTO Tablero"
        }
        public void Update(int id, Tablero tableroModificar){

        }
        public Tablero GetById(int id){
            Tablero Nuevo = new Tablero();
            return Nuevo;
        }
        public List<Tablero> GetAll(){
            List<Tablero> Nuevo = new List<Tablero>();
            return Nuevo;
        }
        public List<Tablero> GetAllById(int idUsuario){
            List<Tablero> Nuevo = new List<Tablero>();
            return Nuevo;
        }
        public void Remove(int id){

        }
    }
}