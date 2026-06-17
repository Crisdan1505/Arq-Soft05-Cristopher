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
        return Ok(_repo.ObtenerTodos());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var paciente = _repo.ObtenerPorId(id);
        return paciente == null ? NotFound() : Ok(paciente);
    }
}