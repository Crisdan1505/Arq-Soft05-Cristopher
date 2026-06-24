using App_Citas.Domain;

namespace App_Citas.Application
{
    public class PacienteRepositoryDecorator : IPacienteRepository
    {
        private readonly IPacienteRepository _repo;

        public PacienteRepositoryDecorator(IPacienteRepository repo)
        {
            _repo = repo;
        }

        public List<Paciente> ObtenerTodos()
        {
            Console.WriteLine("[Decorator] Obteniendo lista de pacientes");
            return _repo.ObtenerTodos();
        }

        public Paciente? ObtenerPorId(int id)
        {
            Console.WriteLine($"[Decorator] Buscando paciente con ID {id}");
            return _repo.ObtenerPorId(id);
        }

        public void Agregar(Paciente paciente)
        {
            Console.WriteLine($"[Decorator] Registrando paciente: {paciente.Nombre}");
            _repo.Agregar(paciente);
        }

        public void Actualizar(Paciente paciente)
        {
            Console.WriteLine($"[Decorator] Actualizando paciente: {paciente.Nombre}");
            _repo.Actualizar(paciente);
        }

        public void Eliminar(int id)
        {
            Console.WriteLine($"[Decorator] Eliminando paciente con ID {id}");
            _repo.Eliminar(id);
        }
    }
}