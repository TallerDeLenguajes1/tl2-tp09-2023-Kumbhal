using Tareas;

namespace TrabajoPractico9{
    public interface ITareaRepository{
        public Tarea Create(Tarea tarea);
        public void UpdateNombre(int id, string nombre);
        public void UpdateEstado(int id, EstadoTarea estado);
        public Tarea GetById(int id);
        public List<Tarea> GetAllById(int idUsuario);
    }
}