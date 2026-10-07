using FluentValidation;
using ProgramasFacpya.Api.Features.Alumnos;

namespace ProgramasFacpya.Api.Common;

public static class ValidationExtensions
{
    public static IServiceCollection AddFluentValidationConfig(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<AlumnoValidator>();
        return services;
    }
}