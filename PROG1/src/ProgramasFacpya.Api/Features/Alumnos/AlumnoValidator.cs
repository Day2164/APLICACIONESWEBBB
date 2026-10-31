using FluentValidation;
using ProgramasFacpya.Api.Features.Alumnos.Dominio.Dto;

namespace ProgramasFacpya.Api.Features.Alumnos;

public class AlumnoValidator : AbstractValidator<AlumnoDTO>
{
    public AlumnoValidator()
    {
        RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre es obligatorio.")
            .Must(TenerMinimoTresLetras).WithMessage("El nombre debe tener al menos 3 caracteres.")
            .Must(SoloLetras).WithMessage("El nombre solo puede contener letras.")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres.");

        RuleFor(x => x.APaterno)
            .NotEmpty().WithMessage("El apellido paterno es obligatorio.")
            .Must(TenerMinimoTresLetras).WithMessage("El apellido paterno debe tener al menos 3 caracteres.")
            .Must(SoloLetras).WithMessage("El apellido paterno solo puede contener letras.")
            .MaximumLength(80).WithMessage("El apellido paterno no puede tener más de 50 caracteres.");

        RuleFor(x => x.AMaterno)
            .NotEmpty().WithMessage("El apellido materno es obligatorio.")
            .Must(TenerMinimoTresLetras).WithMessage("El apellido materno debe tener al menos 3 caracteres.")
            .Must(SoloLetras).WithMessage("El apellido materno solo puede contener letras.")
            .MaximumLength(80).WithMessage("El apellido materno no puede tener más de 50 caracteres.");

        RuleFor(x => x.IdCarrera)
            .GreaterThan((byte)0).WithMessage("La carrera es requerida.");
    }
    
    private static bool TenerMinimoTresLetras(string texto)=> 
        texto.Replace(" ", "").Length >= 3;

    //permite espacios para nombres compuestos(ejemplo: Juan Carlos)
    private static bool SoloLetras(string texto)=>
        texto.Replace(" ", "").All(char.IsLetter);
}

