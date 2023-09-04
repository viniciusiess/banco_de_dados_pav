using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ListaContatos.Persistencia
{
    internal class BancoDados
    {
        private int porta = 3307;
        private string servidor = "localhost";
        private string nomeBancoDados = "bd_contato";
        private MySqlConnection conexao;
        private MySqlTransaction transacao;
        private static BancoDados instancia = null;

        private string criarStringConexao(string usuario, string senha)
        {
            return "server = "+servidor+
                    ";port = "+porta.ToString()+
                    ";user id = "+usuario+
                    ";database = "+nomeBancoDados+
                    ";password = "+senha;
        }

        public void conectar(string usuario, string senha)
        {
            try
            {
                if (conexao == null || conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao = new MySqlConnection(criarStringConexao(usuario, senha));
                    conexao.Open();
                    MessageBox.Show("Conexão realizada com sucesso");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void conectar()
        {
            conectar("root", "usbw");
        }

        public void desconectar()
        {
            if(conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }

        public static BancoDados obterInstancia()
        {
            if(instancia == null)
            {
                instancia = new BancoDados();
            }
            return instancia;
        }

        public MySqlConnection obterConexao()
        {
            return conexao;
        }

        public void iniciarTransacao()
        {
            transacao = conexao.BeginTransaction();
        }

        public void confirmarTransacao()
        {
            if(transacao != null)
            {
                transacao.Commit();
                transacao.Dispose();
            }
        }

        public void cancelarTransacao()
        {
            if(transacao != null)
            {
                transacao.Dispose();
            }
        }
    }
}
