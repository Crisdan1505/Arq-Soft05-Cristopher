using App_Citas.Application;
using App_Citas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace App_Citas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PacienteController : ControllerBase
{
    private readonly IPacienteRepository _repo;

    public PacienteController(IPacienteRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        Console.WriteLine("[GET] ObtenerTodos - inicio");

        var pacientes = _repo.ObtenerTodos();

        Console.WriteLine($"[GET] ObtenerTodos - {pacientes.Count} registros");

        return Ok(pacientes);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Console.WriteLine($"[GET] ObtenerPorId({id}) - inicio");

        var paciente = _repo.ObtenerPorId(id);

        if (paciente == null)
        {
            Console.WriteLine($"[GET] ObtenerPorId({id}) - no encontrado");
            return NotFound();
        }

        Console.WriteLine($"[GET] ObtenerPorId({id}) - encontrado");

        return Ok(paciente);
    }

    [HttpPost]
    public IActionResult Crear(Paciente paciente)
    {
        Console.WriteLine("[POST] Crear paciente - inicio");

        var pacienteCreado = PacienteFactory.Crear(paciente);

        var repoDecorado = new PacienteRepositoryDecorator(_repo);
        repoDecorado.Agregar(pacienteCreado);

        var observador = new PacienteObserver();
        observador.Notificar(pacienteCreado);

        Console.WriteLine($"[POST] Crear paciente - registrado ID {pacienteCreado.Id}");

        return CreatedAtAction(nameof(GetById), new { id = pacienteCreado.Id }, pacienteCreado);
    }
}