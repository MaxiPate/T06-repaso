using Newtonsoft.Json;

public class Usuario 
{
     [JsonProperty]
    public int id{get; private set;}
     [JsonProperty]
    public string username{get; private set;}
     [JsonProperty]
    public string password{get; private set;}
     [JsonProperty]
    public string nombre{get; private set;}
     [JsonProperty]
    public string apellido{get; private set;}
     [JsonProperty]
    public string foto{get; private set;}
     [JsonProperty]
    public DateTime fechaLastLogIn{get; private set;}

    public Usuario(string username, string password, string nombre, string apellido, string foto, DateTime fechaLastLogIn){
        this.username=username;
        this.password=password;
        this.nombre=nombre;
        this.apellido=apellido;
        this.foto=foto;
        this.fechaLastLogIn=fechaLastLogIn;
    }
}