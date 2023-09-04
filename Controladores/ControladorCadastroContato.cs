using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ListaContatos.Persistencia;
using ListaContatos.Entidades;
using MySql.Data.MySqlClient;
using ListaContatos.Controladores;

namespace AcessoBancoDados.Controladores
{
    public class ControladorCadastroContato : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM CONTATO WHERE ID_CONTATO = @ID_CONTATO";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO CONTATO VALUES(@ID_CONTATO, @NOME, @EMAIL, @TELEFONE)";
        }

        protected override string criarComandoAtualizacao()
        {
            return " UPDATE CONTATO " +
            " SET NOME = @NOME, " +
            " EMAIL = @EMAIL, " +
            " TELEFONE = @TELEFONE " +
            " WHERE ID_CONTATO = @ID_CONTATO";

        }

        protected override string criarComandoExclusao()
        {
            return "DELETE FROM CONTATO WHERE ID_CONTATO = @ID_CONTATO";
        }

        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Contato.ATRIBUTO_ID_CONTATO, MySqlDbType.Int32);
            comando.Parameters.Add(Contato.ATRIBUTO_NOME, MySqlDbType.String);
            comando.Parameters.Add(Contato.ATRIBUTO_EMAIL, MySqlDbType.String);
            comando.Parameters.Add(Contato.ATRIBUTO_TELEFONE, MySqlDbType.String);
        }
        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Contato.ATRIBUTO_ID_CONTATO, MySqlDbType.Int32);
        }
    }
}
