using AcessoBancoDados.Controladores;
using ListaContatos.Entidades;
using ListaContatos.Persistencia;

namespace ListaContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
        }

        private void buIncluir_Click_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            ControladorCadastroContato controlador = new ControladorCadastroContato();
            Contato contato = new Contato();
            contato.idContato = 1;
            contato.nome = "Fulano";
            contato.email = "fulano@gmail.com";
            contato.telefone = "21-1234-1234";
            controlador.incluir(contato);
        }

        private void buSelecionar_Click_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            ControladorCadastroContato controlador = new ControladorCadastroContato();
            Contato contato = new Contato();
            contato.idContato = 1; //Mais simples, mas tem soluções mais elaboradas
            controlador.selecionar(contato);
            MessageBox.Show("Contato: \n" +
            contato.nome + "\n" +
            contato.email + "\n" +
            contato.telefone);
        }

        private void buAlterar_Click_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            ControladorCadastroContato controlador = new ControladorCadastroContato();
            Contato contato = new Contato();
            contato.idContato = 1; //Mais simples assim, mas tem soluções mais elaboradas
            controlador.selecionar(contato);
            contato.nome = "Beltrano";
            contato.email = "beltrano@gmail.com";
            contato.telefone = "24-3456-7675";
            controlador.atualizar(contato);
        }

        private void buExcluir_Click_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            ControladorCadastroContato controlador = new ControladorCadastroContato();
            Contato contato = new Contato();
            contato.idContato = 1; //Mais simples assim, mas tem soluções mais elaboradas
            controlador.excluir(contato);
        }
    }
}