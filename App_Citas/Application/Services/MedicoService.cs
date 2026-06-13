using App_Citas.Domain.Entities;
using App_Citas.Domain.Ports;

namespace App_Citas.Application.Services
{
    public class MedicoService
    {
        private readonly IMedicoRepository _repo;

        public MedicoService(IMedicoRepository repo)
        {
            _repo = repo;
        }

        public List<Medico> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }

        public Medico? ObtenerPorId(int id)
        {
            return _repo.ObtenerPorId(id);
        }

        public void Agregar(Medico medico)
        {
            _repo.Agregar(medico);
        }

        public void Actualizar(Medico medico)
        {
            _repo.Actualizar(medico);
        }

        public void Eliminar(int id)
        {
            _repo.Eliminar(id);
        }
    }
}