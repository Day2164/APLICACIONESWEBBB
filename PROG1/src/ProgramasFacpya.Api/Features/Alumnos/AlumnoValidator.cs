using FluentValidation;
using ProgramasFacpya.Api.Features.Alumnos.Dominio.Dto;

namespace ProgramasFacpya.Api.Features.Alumnos;

public class AlumnoValidator : AbstractValidator<CrearAlumnoDTO>
{
    public AlumnoValidator()
    {
        RuleFor(x => x.Nombre)
            .NotEmpty()
            .WithMessage("El nombre es obligatorio.");

        RuleFor(x => x.IdCarrera)
            .GreaterThan((byte)0)
            .WithMessage("La carrera es obligatoria.");
    }
}

public class ActualizarAlumnoValidator : AbstractValidator<ActualizarAlumnoDTO>
{
    public ActualizarAlumnoValidator()
    {
        RuleFor(x => x.Nombre)
            .NotEmpty()
            .WithMessage("El nombre es obligatorio.");

        RuleFor(x => x.IdCarrera)
            .GreaterThan((byte)0)
            .WithMessage("La carrera es obligatoria.");
    }
}