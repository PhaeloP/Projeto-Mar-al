using MySql.Data.MySqlClient;
using projeto_mar_al.DOMAIN;
using projeto_mar_al.DOMAIN.Entidades;
using projeto_mar_al.DOMAIN.Interfaces;
using projeto_mar_al.INFRA.Providers;
using projeto_mar_al.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string cmdText = "SELECT id, nome, email, idade, senha FROM clientes WHERE id = @id";

            using var cmd = new MySqlCommand(cmdText, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Cliente
            {
                id = Convert.ToInt32(reader["id"]),
                nome = reader["nome"]?.ToString(),
                email = reader["email"]?.ToString(),
                idade = Convert.ToInt32(reader["idade"]),
                senha = reader["senha"]?.ToString()
            };

            }
    }
}
