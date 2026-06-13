using App_Citas.Domain.Entities;
using App_Citas.Domain.Ports;

namespace App_Citas.Domain.Ports
{
    public interface IMedicoRepository
    {
        List<Medico> ObtenerTodos();
        Medico? ObtenerPorId(int id);
        void Agregar(Medico medico);
        void Actualizar(Medico medico);
        void Eliminar(int id);
    }
}