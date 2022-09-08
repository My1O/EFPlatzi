namespace EFPlatzi.Models;

public class Tarea
{
    public Guid TareaId{set;get;}

    public Guid CategoriaId{set;get;}

    public string Titulo{set;get;}

    public string Descripcion {set;get;}

    public Prioridad prioridadTarea{set;get;}

    public DateTime FechaCreacion{set;get;}

    public virtual ICollection<Tarea> Tareas{set;get;}

    public virtual Categoria Categoria{set;get;}
}
public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }