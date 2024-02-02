using EstructuraDeClases.Uni.Domain.Core;

namespace EstructuraDeClases.Uni.Domain.Entities
{
    public class Administrador : Docente
    {
        //Administración se refiere a que administra dicho docente .
        public string Administracion {  get; set; }
    }
}
