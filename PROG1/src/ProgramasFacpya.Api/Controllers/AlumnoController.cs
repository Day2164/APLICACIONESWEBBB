using Microsoft.AspNetCore.Mvc;
using ProgramasFacpya.Api.Features.Alumnos;
using ProgramasFacpya.Api.Features.Alumnos.Dominio.Dto;

namespace ProgramasFacpya.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlumnoController(AlumnoService service) : ControllerBase
{
    private readonly AlumnoService _service = service;

    [HttpGet("ObtenerTodos")]
    public async Task<IActionResult> ObtenerTodos()
    {
        return Ok(await _service.ObtenerTodos());
    }

    [HttpGet("ObtenerPorMatricula/{matricula}")]
    public async Task<IActionResult> ObtenerPorMatricula(int matricula)
    {
        return Ok(await _service.ObtenerPorMatricula(matricula));
    }

    [HttpPost("Crear")]
    public async Task<IActionResult> Crear([FromBody] CrearAlumnoDTO dto)
    {
        return Ok(await _service.Crear(dto));
    }

    [HttpPut("Actualizar/{idAlumno}")]
    public async Task<IActionResult> Actualizar(int idAlumno, [FromBody] ActualizarAlumnoDTO dto)
    {
        return Ok(await _service.Actualizar(idAlumno, dto));
    }

    [HttpDelete("Eliminar/{idAlumno}")]
    public async Task<IActionResult> Eliminar(int idAlumno)
    {
        return Ok(await _service.Eliminar(idAlumno));
    }

    [HttpGet("ObtenerPorId/{idAlumno:int}")]
    public async Task<IActionResult> ObtenerPorId(int idAlumno)
    {
        return Ok(await _service.ObtenerPorId(idAlumno));
    }
}