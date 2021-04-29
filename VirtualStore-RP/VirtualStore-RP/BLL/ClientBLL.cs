using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using VirtualStore_RP.DTO;

namespace VirtualStore_RP.BLL
{
    public class ClientBLL
    {
        private MySqlDAL connection = new MySqlDAL();

        public void Insert(ClientDTO client)
        {
            string sql = string.Format($@"INSERT INTO client VALUES(NULL, '{client.Name}', '{client.Cpf}', '{client.Phone}', '{client.Email}', '{client.Password}');");
            connection.ExecutionSQL(sql);
        }

        public void Delete(int id)
        {
            string sql = string.Format($@"DELETE FROM client WHERE id = '{id}';");
            connection.ExecutionSQL(sql);
        }

        public void Update(ClientDTO client)
        {
            string sql = string.Format($@"UPDATE client SET name='{client.Name}', cpf='{client.Cpf}', phone='{client.Phone}', email='{client.Email}', password='{client.Password}';");
            connection.ExecutionSQL(sql);
        }

        public DataTable ConsultID(int id)
        {
            string sql = string.Format($@"SELECT * FROM client WHERE id = '{id}';");
            return connection.QueryExecution(sql);
        }

        public DataTable SearchClient(string conditional)
        {
            string sql = string.Format($@"SELECT c.name, c.cpf, c.phone, c.email, a.street, a.number, a.neighborhood, a.city, a.cep FROM client as c, address as a WHERE a.client_id = c.id and '{conditional}' ORDER BY c.id;");
            return connection.QueryExecution(sql);
        }
    }
}