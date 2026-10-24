using System.ComponentModel.DataAnnotations;

namespace AquaSerena.Models;

public class Reserva
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo electrónico es obligatorio")]
    public string Correo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha de asistencia es obligatoria")]
    public string Fecha { get; set; } = string.Empty;

    [Required(ErrorMessage = "Selecciona una actividad")]
    public string Actividad { get; set; } = string.Empty;
}
