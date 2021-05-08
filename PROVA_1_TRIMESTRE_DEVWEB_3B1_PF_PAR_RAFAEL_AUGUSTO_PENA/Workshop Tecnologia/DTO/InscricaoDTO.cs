using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workshop_Tecnologia.DTO
{
    public class InscricaoDTO
    {
        private int id;
        private string nome, telefone, email, foto;

        public int Id { get => id; set => id = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Campo nome obrigatório");
                }
            }
            get { return this.nome; }
        }

        public string Telefone
        {
            set
            {
                if (value != string.Empty)
                {
                    this.telefone = value;
                }
                else
                {
                    throw new Exception("Campo telefone obrigatório");
                }
            }
            get { return this.telefone; }
        }

        public string Email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Campo email obrigatório");
                }
            }
            get { return this.email; }
        }
        public string Foto
        {
            set
            {
                if (value != string.Empty)
                {
                    this.foto = value;
                }
                else
                {
                    throw new Exception("Campo foto obrigatório");
                }
            }
            get { return this.foto; }
        }
    }
}