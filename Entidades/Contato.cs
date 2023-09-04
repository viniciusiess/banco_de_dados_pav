using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ListaContatos.Entidades
{
    public class Contato : Entidade
    {
        public const string ATRIBUTO_ID_CONTATO = "ID_CONTATO";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_EMAIL = "EMAIL";
        public const string ATRIBUTO_TELEFONE = "TELEFONE";

        public int idContato { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTATO].Value = idContato;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_EMAIL].Value = email;
            comando.Parameters[ATRIBUTO_TELEFONE].Value = telefone;
        }
        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTATO].Value = idContato;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idContato = int.Parse(leitorDados[ATRIBUTO_ID_CONTATO].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            email = leitorDados[ATRIBUTO_EMAIL].ToString();
            telefone = leitorDados[ATRIBUTO_TELEFONE].ToString();
        }
    }
}
