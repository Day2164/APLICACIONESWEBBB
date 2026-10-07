namespace ProgramasFacpya.Api.Features.Alumnos.Dominio.Dto;

public class AlumnoDTO
{
    public string Nombre { get; set; } = string.Empty;
    public string APaterno { get; set; } = string.Empty;
    public string AMaterno { get; set; } = string.Empty;
    public byte IdCarrera { get; set; }
}

public class CrearAlumnoDTO
{
    public string Nombre { get; set; } = string.Empty;
    public string APaterno { get; set; } = string.Empty;
    public string AMaterno { get; set; } = string.Empty;
    public byte IdCarrera { get; set; }
}

public class ActualizarAlumnoDTO
{
    public string Nombre { get; set; } = string.Empty;
    public string APaterno { get; set; } = string.Empty;
    public string AMaterno { get; set; } = string.Empty;
    public byte IdCarrera { get; set; }
    public bool IsActivo { get; set; } = true;
}