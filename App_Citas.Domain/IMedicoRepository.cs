using App_Citas.Domain;

namespace App_Citas.Domain
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