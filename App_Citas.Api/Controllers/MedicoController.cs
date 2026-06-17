using App_Citas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace App_Citas.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicoController : ControllerBase
{
    private readonly IMedicoRepository _repo;

    public MedicoController(IMedicoRepository repo)
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
        var medico = _repo.ObtenerPorId(id);
        return medico == null ? NotFound() : Ok(medico);
    }
}