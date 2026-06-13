using App_Citas.Domain.Entities;
using App_Citas.Domain.Ports;

namespace App_Citas.Domain.Ports
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