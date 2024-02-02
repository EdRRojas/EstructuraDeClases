namespace EstructuraDeClases.Uni.Domain.Core
{
    public abstract class MiembrosDeLaComunidad
    {
        public string? Nombre { get; set; }
        public string Correo {  get; set; }
        public bool? Estatus { get; set; } //El estatus se utilizaría para saber si el miembro sigue siendo
                                           //miembro o no de la comunidad.
        /*Decidí no poner el ID en la clase base ya que quería que se diferenciaran que el ID del alumno
         es distinto al ID de un empleado.*/
    }
}
