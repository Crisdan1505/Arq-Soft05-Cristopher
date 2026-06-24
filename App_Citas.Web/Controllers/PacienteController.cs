using App_Citas.Application;
using App_Citas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace App_Citas.Web.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteRepository _repo;

        public PacienteController(IPacienteRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index() => View(_repo.ObtenerTodos());

        public IActionResult Detalle(int id)
        {
            var paciente = _repo.ObtenerPorId(id);
            return paciente == null ? NotFound() : View(paciente);
        }

        public IActionResult Crear() => View(new Paciente());

        [HttpPost]
        public IActionResult Crear(Paciente paciente)
        {
            var pacienteCreado = PacienteFactory.Crear(paciente);

            var repoDecorado = new PacienteRepositoryDecorator(_repo);
            repoDecorado.Agregar(pacienteCreado);

            var observador = new PacienteObserver();
            observador.Notificar(pacienteCreado);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var paciente = _repo.ObtenerPorId(id);
            return paciente == null ? NotFound() : View(paciente);
        }

        [HttpPost]
        public IActionResult Editar(Paciente paciente)
        {
            _repo.Actualizar(paciente);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            _repo.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}