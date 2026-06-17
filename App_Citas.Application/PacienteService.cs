using App_Citas.Domain;

namespace App_Citas.Application
{
    public class PacienteService
    {
        private readonly IPacienteRepository _repo;

        public PacienteService(IPacienteRepository repo)
        {
            _repo = repo;
        }

        public List<Paciente> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }

        public Paciente? ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }

        public void Agregar(Paciente paciente)
        {
            _repo.Agregar(paciente);
        }

        public void Actualizar(Paciente paciente)
        {
            _repo.Actualizar(paciente);
        }

        public void Eliminar(int id)
        {
            _repo.Eliminar(id);
        }
    }
}