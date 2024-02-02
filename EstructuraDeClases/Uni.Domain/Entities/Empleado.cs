using EstructuraDeClases.Uni.Domain.Core;


namespace EstructuraDeClases.Uni.Domain.Entities
{
    public abstract class Empleado : MiembrosDeLaComunidad
    {
        //ID específico de los empleados.
        public int? IdEmp { get; set; }
        //La profesión vendría siendo el empleo que ejerce el empleado dentro de la institución.
        public string Profesion {  get; set; }
        public decimal Sueldo {  get; set; }
    }
}
