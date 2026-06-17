using App_Citas.Domain;

namespace App_Citas.Domain
{
    public interface IPacienteRepository
    {
        List<Paciente> ObtenerTodos();
        Paciente? ObtenerPorId(int id);
        void Agregar(Paciente paciente);
        void Actualizar(Paciente paciente);
        void Eliminar(int id);
    }
}