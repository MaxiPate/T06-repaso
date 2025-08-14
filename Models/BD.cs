using  Microsoft.Data.SqlClient;
using Dapper;
public static class BD{
    private static string _connectionString = @"Server=localhost; DataBase=Presentacion; Integrated Security=True; TrustServerCertificate=True;";
    public static int Login(string username, string password){
        int aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Usuario WHERE password = @password AND username = @username";
            aux = connection.QueryFirstOrDefault<int>(query, new {username, password});

        }
        return aux;
    }
    public static Usuario VerificarUsuario(int username){
        Usuario aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Usuario WHERE username = @username";
            aux = connection.QueryFirstOrDefault<Usuario>(query, new {username});

        }
        return aux;
    }
    public static Usuario Registrar(Usuario usu){
        Usuario aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "INSERT INTO Usuario (username, password, nombre, apellido, foto, fechaLastLogIn) VALUES (@username, @password, @nombre, @apellido, @foto, @fechaLastLogIn)";
            aux = connection.QueryFirstOrDefault<Usuario>(query, new {usu});

        }
        return aux;
    }
    public static Tarea AgregarTarea(Tarea tarea){
        Tarea aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "INSERT INTO Usuario (Titulo, Descripcion, Fecha, Finalizada) VALUES (@Titulo, @Descripcion, @Fecha, @Finalizada)";
            aux = connection.QueryFirstOrDefault<Tarea>(query, new {tarea});

        }
        return aux;
    }
    public static void ModificarTarea(Tarea tarea){
        Tarea aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "UPDATE Tarea SET Titulo = @Titulo, Descripcion = @Descripcion, Fecha = @Fecha, Finalizada = @Finalizada WHERE id = @id";
            aux = connection.QueryFirstOrDefault<Tarea>(query, new {tarea});

        }
    }
        
    public static void FinalizarTarea(int id){
        
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "UPDATE Tarea SET finalizada = 1 WHERE id = @id";
            connection.Execute(query, new{id});

        }
        
    }
    public static Tarea VerTarea(int id){
        Tarea aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Tarea WHERE id = @id";
            aux = connection.QueryFirstOrDefault<Tarea>(query, new {id});

        }
        return aux;
    }
    public static List<Tarea> VerTareas(int id_Usuario){
        List<Tarea> aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Tarea";
            aux = connection.Query<Tarea>(query, new {id_Usuario}).ToList();

        }
        return aux;
    }
    
    


}