using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Workshop_Tecnologia.DAL;
using Workshop_Tecnologia.DTO;

namespace Workshop_Tecnologia.BLL
{
    public class InscricaoBLL
    {
        private MysqlDAL connection = new MysqlDAL();
        public void Insert(InscricaoDTO inscricao)
        {
            string sql = string.Format($@"INSERT INTO inscricao VALUES(NULL, '{inscricao.Nome}', '{inscricao.Telefone}', '{inscricao.Email}', '{inscricao.Foto}');");
            connection.ExecutarSQL(sql);
        }
        public void Update(InscricaoDTO inscricao)
        {
            string sql = string.Format($@"UPDATE inscricao SET nome = '{inscricao.Nome}', telefone = '{inscricao.Telefone}', email ='{inscricao.Email}', foto ='{inscricao.Foto}' WHERE id = '{inscricao.Id}';");
            connection.ExecutarSQL(sql);
        }

        public DataTable getInscricao()
        {
            string sql = string.Format($@"SELECT * FROM inscricao;");
            DataTable dt = connection.ExecutarConsulta(sql);
            return dt;
        }
    }
}