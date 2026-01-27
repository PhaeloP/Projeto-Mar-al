using MySql.Data.MySqlClient;

namespace projeto_mar_al.INFRA.Providers
{
    public class MySqlConnectionFactory
    {
        //TODO: sua connectionstring
        private const string ConnectionString = "";  //modelo: Server=localhost;Database=nomeBanco;User=root;Password=123;
        public MySqlConnection CreateConnection()
        {

            return new MySqlConnection(ConnectionString);
        }
    }
}
