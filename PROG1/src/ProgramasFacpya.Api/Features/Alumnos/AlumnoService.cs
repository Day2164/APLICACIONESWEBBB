using FluentValidation;
using ProgramasFacpya.Api.Common;
using ProgramasFacpya.Api.Data;
using ProgramasFacpya.Api.Features.Alumnos.Dominio.Dto;
using ProgramasFacpya.Api.Features.Alumnos.Dominio.Entidad;

namespace ProgramasFacpya.Api.Features.Alumnos;

public class AlumnoService
{
    private readonly DbContext _db;
    private readonly IValidator<CrearAlumnoDTO> _crearValidator;
    private readonly IValidator<ActualizarAlumnoDTO> _actualizarValidator;

    public AlumnoService(
        DbContext db,
        IValidator<CrearAlumnoDTO> crearValidator,
        IValidator<ActualizarAlumnoDTO> actualizarValidator)
    {
        _db = db;
        _crearValidator = crearValidator;
        _actualizarValidator = actualizarValidator;
    }

    public async Task<ApiResponse<IEnumerable<Alumno>>> ObtenerTodos()
    {
        await Task.CompletedTask;

        var alumnos = new List<Alumno>
        {
            new()
            {
                Matricula = 1,
                Nombre = "Ejemplo",
                APaterno = "Pérez",
                AMaterno = "López",
                IdCarrera = 1,
                IsActivo = true,
                Carrera = "Ingeniería"
            }
        };

        return ApiResponse<IEnumerable<Alumno>>.Ok(alumnos);
    }

    public async Task<ApiResponse<Alumno>> ObtenerPorMatricula(int matricula)
    {
        await Task.CompletedTask;

        if (matricula <= 0)
            return ApiResponse<Alumno>.Error("La matrícula no es válida");

        return ApiResponse<Alumno>.Ok(new Alumno
        {
            Matricula = matricula,
            Nombre = "Ejemplo",
            APaterno = "Pérez",
            AMaterno = "López",
            IdCarrera = 1,
            IsActivo = true,
            Carrera = "Ingeniería"
        });
    }

    public async Task<ApiResponse<Alumno>> Crear(CrearAlumnoDTO dto)
    {
        var validacion = await _crearValidator.ValidateAsync(dto);
        if (!validacion.IsValid)
            return ApiResponse<Alumno>.Error(validacion.Errors.First().ErrorMessage);

        return ApiResponse<Alumno>.Ok(new Alumno
        {
            Matricula = 1,
            Nombre = dto.Nombre,
            APaterno = dto.APaterno,
            AMaterno = dto.AMaterno,
            IdCarrera = dto.IdCarrera,
            IsActivo = true,
            Carrera = "Ingeniería"
        });
    }

    public async Task<ApiResponse<string>> Actualizar(int matricula, ActualizarAlumnoDTO dto)
    {
        var validacion = await _actualizarValidator.ValidateAsync(dto);
        if (!validacion.IsValid)
            return ApiResponse<string>.Error(validacion.Errors.First().ErrorMessage);

        return ApiResponse<string>.Ok(string.Empty);
    }

    public async Task<ApiResponse<string>> Eliminar(int matricula)
    {
        await Task.CompletedTask;

        if (matricula <= 0)
            return ApiResponse<string>.Error("La matrícula no es válida");

        return ApiResponse<string>.Ok(string.Empty);
    }
}