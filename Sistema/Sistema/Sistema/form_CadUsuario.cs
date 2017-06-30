using System;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

// Data de criação 17/02
// Data de alteração 17/02

namespace Sistema
{
    public partial class form_CadUsuario : Form
    {
        public int codigo = 0;

        public form_CadUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSistemaDataSet);

        }

        public string operacao;

        // operações com os botoes 

        public void alterarBotoes(int op)
        {
            /*
            * 1 - inserir e localizar
            * 2 - inserir e alterar
            * 3 - excluir e alterar
            */

            /*

           * 1 - inserir e localizar
           * 2 - salva
           * 3 - alterar e excluir 

           */
            pnDados.Enabled = true;
            btnPesquisar.Enabled = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisar.Enabled = true;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 2) // salvar
            {
                pnDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {
                btnSalvar.Enabled = true;
                pnDados.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }//alteraBotoes

        public void LimpaTela()
        {
            usr_idTextBox.Clear();
            usr_nomeTextBox.Clear();
            usr_cpfTextBox.Clear();
            usr_telefoneTextBox.Clear();
            usr_celularTextBox.Clear();
            usr_logradouroTextBox.Clear();
            usr_numeroTextBox.Clear();
            usr_complementoTextBox.Clear();
            usr_bairroTextBox.Clear();
            usr_usuarioTextBox.Clear();
            usr_senhaTextBox.Clear();
            usr_confirmarSenhaTextBox.Clear();
            usr_emailTextBox.Clear();
            usr_cidadeComboBox.SelectedIndex = -1;
            usr_cargoComboBox.SelectedIndex = -1;
            usr_estadoComboBox.SelectedIndex = -1;
        }


        private void form_CadUsuario_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);
            
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            //cb cidade
            CidadeBLL cidbll = new CidadeBLL(conexao);
            usr_cidadeComboBox.DataSource = cidbll.Pesquisar("");
            usr_cidadeComboBox.DisplayMember = "cid_descriçao";
            usr_cidadeComboBox.ValueMember = "cid_id";
            //cb estado
            EstadoBLL estbll = new EstadoBLL(conexao);
            usr_estadoComboBox.DataSource = estbll.Pesquisar("");
            usr_estadoComboBox.DisplayMember = "est_descriçao";
            usr_estadoComboBox.ValueMember = "est_id";
            //cb cargo
            CargoBLL carbll = new CargoBLL(conexao);
            usr_cargoComboBox.DataSource = carbll.Pesquisar("");
            usr_cargoComboBox.DisplayMember = "car_cargo";
            usr_cargoComboBox.ValueMember = "car_id";

            this.LimpaTela();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsUsuario Form_Cad = new form_ConsUsuario();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                UsuarioBLL bll = new UsuarioBLL(conexao);
                UsuarioDTO usr = bll.CarregaUsuarioDTO(Form_Cad.codigo);
                usr_idTextBox.Text = usr.Usr_id.ToString();
                usr_nomeTextBox.Text = usr.Usr_nome;
                usr_cpfTextBox.Text = usr.Usr_cpf;
                usr_telefoneTextBox.Text = usr.Usr_telefone;
                usr_celularTextBox.Text = usr.Usr_celular;
                usr_logradouroTextBox.Text = usr.Usr_logradouro;
                usr_numeroTextBox.Text = usr.Usr_numero;
                usr_complementoTextBox.Text = usr.Usr_complemento;
                usr_bairroTextBox.Text = usr.Usr_bairro;
                usr_cidadeComboBox.SelectedValue = usr.Usr_cidade;
                usr_estadoComboBox.SelectedValue = usr.Usr_estado;
                usr_cargoComboBox.SelectedValue = usr.Usr_estado;
                usr_usuarioTextBox.Text = usr.Usr_usuario;
                usr_senhaTextBox.Text = usr.Usr_senha;
                usr_confirmarSenhaTextBox.Text = usr.Usr_confirmarSenha;
                usr_emailTextBox.Text = usr.Usr_email;

                alterarBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alterarBotoes(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                UsuarioDTO usr = new UsuarioDTO();

                usr.Usr_nome = usr_nomeTextBox.Text;
                usr.Usr_cpf = usr_cpfTextBox.Text;
                usr.Usr_telefone = usr_telefoneTextBox.Text;
                usr.Usr_celular = usr_celularTextBox.Text;
                usr.Usr_logradouro = usr_logradouroTextBox.Text;
                usr.Usr_numero = usr_numeroTextBox.Text;
                usr.Usr_complemento = usr_complementoTextBox.Text;
                usr.Usr_bairro = usr_bairroTextBox.Text;
                usr.Usr_cidade = Convert.ToInt32(usr_cidadeComboBox.SelectedValue);
                usr.Usr_estado = Convert.ToInt32(usr_estadoComboBox.SelectedValue);
                usr.Usr_cargo = Convert.ToInt32(usr_cargoComboBox.SelectedValue);
                usr.Usr_usuario = usr_usuarioTextBox.Text;
                usr.Usr_senha = usr_senhaTextBox.Text;
                usr.Usr_confirmarSenha = usr_confirmarSenhaTextBox.Text;
                usr.Usr_email = usr_emailTextBox.Text;

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                UsuarioBLL bll = new UsuarioBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(usr);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + usr.Usr_id.ToString());
                    // this.LimpaTela();
                }
                else // alterar 
                {
                    usr.Usr_id = Convert.ToInt32(usr_idTextBox.Text);
                    bll.Alterar(usr);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + usr.Usr_id.ToString());
                }
                this.LimpaTela();
                this.alterarBotoes(1);

            }//try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoes(2); // altera status novo para habilitar salvar

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    UsuarioBLL bll = new UsuarioBLL(conexao);

                    bll.Excluir(Convert.ToInt32(usr_idTextBox.Text));
                    this.LimpaTela();
                    this.alterarBotoes(1);
                }
            }//try
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.alterarBotoes(3);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterarBotoes(1);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
