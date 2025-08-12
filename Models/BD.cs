using  Microsoft.Data.SqlcClient;
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
    public static Registrar(Usuario usu){
        Usuario aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "INSERT INTO Usuario (username, password, nombre, apellido, foto, fechaLastLogIn) VALUES (@username, @password, @nombre, @apellido, @foto, @fechaLastLogIn)";
            aux = connection.QueryFirstOrDefault<Usuario>(query, new {usu});

        }
    }
}