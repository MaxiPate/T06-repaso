using Newtonsoft.Json;
public class Tarea
{
    [JsonProperty]
    public string Titulo {get; private set;}
    [JsonProperty]
    public string Descripcion {get; private set;}
    [JsonProperty]
    public DateTime Fecha {get; private set;}
    [JsonProperty]
    public bool Finalizada {get; private set;}

    public Tarea(string Titulo, string Descripcion, DateTime Fecha, bool Finalizada){
        this.Titulo=Titulo;
        this.Descripcion=Descripcion;
        this.Fecha=Fecha;
        this.Finalizada=Finalizada;
    }
}
