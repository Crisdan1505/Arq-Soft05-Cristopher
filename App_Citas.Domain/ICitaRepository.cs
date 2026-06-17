using App_Citas.Domain;

namespace App_Citas.Domain
{
    public interface ICitaRepository
    {
        List<Cita> ObtenerTodos();
        List<Cita> ObtenerPorPaciente(int pacienteId);
        Cita? ObtenerPorId(int id);
        void Agregar(Cita cita);
        void Actualizar(Cita cita);
        void Eliminar(int id);
    }
}