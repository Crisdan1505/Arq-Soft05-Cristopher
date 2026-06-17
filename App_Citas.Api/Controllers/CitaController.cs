using App_Citas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace App_Citas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitaController : ControllerBase
{
    private readonly ICitaRepository _repo;

    public CitaController(ICitaRepository repo)
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
        var cita = _repo.ObtenerPorId(id);
        return cita == null ? NotFound() : Ok(cita);
    }

    [HttpGet("paciente/{pacienteId}")]
    public IActionResult GetByPaciente(int pacienteId)
    {
        return Ok(_repo.ObtenerPorPaciente(pacienteId));
    }
}