using App_Citas.Domain;

namespace App_Citas.Application
{
    public class CitaService
    {
        private readonly ICitaRepository _repo;

        public CitaService(ICitaRepository repo)
        {
            _repo = repo;
        }

        public List<Cita> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }

        public Cita? ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }

        public void Agregar(Cita cita)
        {
            _repo.Agregar(cita);
        }

        public void Actualizar(Cita cita)
        {
            _repo.Actualizar(cita);
        }

        public void Eliminar(int id)
        {
            _repo.Eliminar(id);
        }

        public List<Cita> ObtenerPorPaciente(int pacienteId)
        {
            return _repo.ObtenerPorPaciente(pacienteId);
        }
    }
}