using System.Data;
using MySql;
using MySql.Data.MySqlClient;

public class Conexao
{
    private string _servidor = "localhost";

    private string _porta = "3306";

    private string _usuario = "root";

    private string _senha = "root";

    private string _bancoDadosNome = "auto_premium_bd";

    private MySqlConnection connection;

    private MySqlCommand command;

    public Conexao()
    {
        try
        {
            connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta};user={_usuario};password={_senha};");
            connection.Open();
        }
        catch (Exception e)
        {

            throw e;
        }
    }
    public MySqlCommand Comando(string comando)
    {
        try
        {
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = comando;

            return command;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}