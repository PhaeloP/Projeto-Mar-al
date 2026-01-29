using MySql.Data.MySqlClient;

namespace projeto_mar_al.INFRA.Providers
{
    public class MySqlConnectionFactory
    {
        //TODO: sua connectionstring
        private readonly string _connectionString ="Server=localhost;Port=3306;Database=projeto_mar_al;Uid=root;Pwd=1020;";

        public MySqlConnection CreateConnection()
        {

            return new MySqlConnection(_connectionString);
        }
    }
}
