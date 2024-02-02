using EstructuraDeClases.Uni.Domain.Core;

namespace EstructuraDeClases.Uni.Domain.Entities
{
    public class ExAlumno : MiembrosDeLaComunidad
    {
        //ID específico de los estudiantes.
        public int? IdAlum {  get; set; }
        public string Carrera { get; set; }
        //Representa si el estudiante esta gruado o no.
        public bool? Graduado { get; set; }
    }
}
