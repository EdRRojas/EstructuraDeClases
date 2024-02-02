using EstructuraDeClases.Uni.Domain.Core;

namespace EstructuraDeClases.Uni.Domain.Entities
{
    public abstract class Docente : Empleado
    {
        public string Departamento {  get; set; }       

    }
}
