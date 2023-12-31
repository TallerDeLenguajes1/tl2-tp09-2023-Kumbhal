using System.Data.SQLite;
using Usuarios;

namespace TrabajoPractico9{
    public class  UsuarioRepository : IUsuarioRepository{
        private string cadenaConexion = "Data Source=DB/kanban.db;Cache=Shared";
        public void Create(Usuario usuario){
            var query = $"INSERT INTO Usuario (nombre_de_usuario) VALUES (@nombre);";
            using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion)){
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@nombre", usuario.NombreDeUsuario));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Update(int id, Usuario usuarioModificar){
            var query = $"UPDATE Usuario SET nombre_de_usuario = @nombre WHERE id = @idUsuario;";
            using(SQLiteConnection connection = new SQLiteConnection(cadenaConexion)){
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@nombre", usuarioModificar.NombreDeUsuario));
                command.Parameters.Add(new SQLiteParameter("@idUsuario", id));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public List<Usuario> GetAll(){
            var query = $"SELECT * FROM Usuario;";
            List<Usuario> listaUsuarios = new List<Usuario>();
            using(SQLiteConnection connection = new SQLiteConnection(cadenaConexion)){
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using(SQLiteDataReader reader = command.ExecuteReader()){
                    while(reader.Read()){
                        var usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["id"]);
                        usuario.NombreDeUsuario = reader["nombre_de_usuario"].ToString();
                        listaUsuarios.Add(usuario);
                    }
                command.ExecuteNonQuery();
                connection.Close();
                }
            }
            return listaUsuarios;
        }
        public Usuario GetById(int id){
            var query = $"SELECT * FROM Usuario WHERE id = @idUsuario;";
            Usuario usuario = new Usuario();
            using(SQLiteConnection connection = new SQLiteConnection(cadenaConexion)){
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                using(SQLiteDataReader reader = command.ExecuteReader()){
                    while(reader.Read()){
                        usuario.Id = Convert.ToInt32(reader["id"]);
                        usuario.NombreDeUsuario = reader["nombre_de_usuario"].ToString();
                    }
                }
                command.ExecuteNonQuery();
                connection.Close();
            }
            return usuario;
        }
        public void Remove (int id){
            using(SQLiteConnection connection = new SQLiteConnection(cadenaConexion)){
                connection.Open();
                var query = $"DELETE * FROM Usuario WHERE id = @idUsuario;";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@id", id));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}