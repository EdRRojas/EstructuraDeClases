using EstructuraDeClases.Uni.Domain.Core;

namespace EstructuraDeClases.Uni.Domain.Entities
{
    public class Administrativo : Empleado
    {
        //Se refiere al trabajo que ejerce el empleado en la empresa. 
        public string Puesto {  get; set; }
        public string Departamento {  get; set; }
    }
}
