using projeto_mar_al.DOMAIN.Interfaces;
using projeto_mar_al.INFRA.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_mar_al.DOMAIN.Entidadedes;
using MySql.Data.MySqlClient;

namespace projeto_mar_al.INFRA.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MySqlConnectionFactory _connectionFactory;
        public ClienteRepository(MySqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public Cliente? SelectDadosDoCliente(string id)
        {
            using var conexao = _connectionFactory.CreateConnection();
            conexao.Open();
            string cmdText = "SELECT * FROM clientes WHERE id = " + id; //TODO: troque de concatenação para interpolação modelo: $"SELECT * FROM clientes WHERE id = {id}"
            var cmd = new MySqlCommand(cmdText, conexao);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Cliente()
                    {
                        id = reader.GetString("id"), //TODO: tipos incorreto, string e int, e nomes devem ser o mesmso da classe Cliente
                        endereco = reader.GetString("nome"),
                        
                    };
                }

                return new Cliente(); //TODO: DESAFIO SUPREMO: troca esse cliente vazio quando nao acha nada, para uma menssagem escrito "Not Found"
                
            }
        }

    }
}
