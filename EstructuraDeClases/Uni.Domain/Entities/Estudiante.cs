using EstructuraDeClases.Uni.Domain.Core;

namespace EstructuraDeClases.Uni.Domain.Entities
{
    public class Estudiante : MiembrosDeLaComunidad
    {
        //ID específico del estudiante.
        public int? IdAlumn { get; set; }
        public string? Carrera {  get; set; }
        public string Materias { get; set; }
    }
}
