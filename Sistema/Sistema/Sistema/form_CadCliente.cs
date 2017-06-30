using System;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;
using System.Drawing;

namespace Sistema
{
    public partial class form_CadCliente : Form
    {
        public int codigo = 0;

        public form_CadCliente()
        {
            InitializeComponent();
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
            cli_idTextBox.Enabled = false;
            cli_nomeTextBox.Clear();
            cli_cpfTextBox.Clear();
            cli_telefoneTextBox.Clear();
            cli_celularTextBox.Clear();
            cli_logradouroTextBox.Clear();
            cli_numeroTextBox.Clear();
            cli_complementoTextBox.Clear();
            cli_bairroTextBox.Clear();
            cli_emailTextBox.Clear();
            cli_cidadeComboBox.SelectedIndex = -1;
            cli_estadoComboBox.SelectedIndex = -1;
        }


        private void form_CadCliente_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);

            this.LimpaTela();

            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);

            //cb cidade
            CidadeBLL cidbll = new CidadeBLL(conexao);
            cli_cidadeComboBox.DataSource = cidbll.Pesquisar("");
            cli_cidadeComboBox.DisplayMember = "cid_descriçao";
            cli_cidadeComboBox.ValueMember = "cid_id";

            //cb estado
            EstadoBLL estbll = new EstadoBLL(conexao);
            cli_estadoComboBox.DataSource = estbll.Pesquisar("");
            cli_estadoComboBox.DisplayMember = "est_descriçao";
            cli_estadoComboBox.ValueMember = "est_id";
                       
        }
        
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            cli_cadastroDateTimePicker.Format = DateTimePickerFormat.Custom;
            cli_cadastroDateTimePicker.CustomFormat = "MMMM dd, yyyy - dddd";
        }
        

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsCliente Form_Cad = new form_ConsCliente();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ClienteBLL bll = new ClienteBLL(conexao);
                ClienteDTO cli = bll.CarregaClienteDTO(Form_Cad.codigo);
                cli_idTextBox.Text = cli.Cli_id.ToString();
                cli_nomeTextBox.Text = cli.Cli_nome;
                cli_cpfTextBox.Text = cli.Cli_cpf;
                cli_telefoneTextBox.Text = cli.Cli_telefone;
                cli_celularTextBox.Text = cli.Cli_celular;
                cli_emailTextBox.Text = cli.Cli_email;
                cli_logradouroTextBox.Text = cli.Cli_logradouro;
                cli_numeroTextBox.Text = cli.Cli_numero;
                cli_complementoTextBox.Text = cli.Cli_complemento;
                cli_bairroTextBox.Text = cli.Cli_bairro.ToString();
                cli_cidadeComboBox.SelectedValue = cli.Cli_cidade;
                cli_estadoComboBox.SelectedValue = cli.Cli_estado;
                cli_cadastroDateTimePicker.Value = cli.Cli_cadastro;
                 
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
                    ClienteDTO cli = new ClienteDTO();
                
                    cli.Cli_nome = cli_nomeTextBox.Text;
                    cli.Cli_cpf = cli_cpfTextBox.Text;
                    cli.Cli_telefone = cli_telefoneTextBox.Text;
                    cli.Cli_celular = cli_celularTextBox.Text;
                    cli.Cli_email = cli_emailTextBox.Text;
                    cli.Cli_logradouro = cli_logradouroTextBox.Text;
                    cli.Cli_numero = cli_numeroTextBox.Text;
                    cli.Cli_complemento = cli_complementoTextBox.Text;
                    cli.Cli_bairro = cli_bairroTextBox.Text;
                    cli.Cli_cidade = Convert.ToInt32(cli_cidadeComboBox.SelectedValue);
                    cli.Cli_estado = Convert.ToInt32(cli_estadoComboBox.SelectedValue);
                    cli.Cli_cadastro = cli_cadastroDateTimePicker.Value.Date;
                   //cli_cadastroDateTimePicker.Value = cli.Cli_cadastro;
                   // cli.Cli_cadastro = Convert.ToDateTime(cli_cadastroDateTimePicker);


                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    ClienteBLL bll = new ClienteBLL(conexao);

                    if (this.operacao == "inserir")
                    {

                        bll.Incluir(cli);

                        MessageBox.Show("Cadastrado com Sucesso: Código: " + cli.Cli_id.ToString());
                    // this.LimpaTela

                    form_CadAnimal_CadBotao f = new form_CadAnimal_CadBotao();
                    f.ShowDialog();

                    f.Dispose();
                }
                else // alterar 
                    {
                        cli.Cli_id = Convert.ToInt32(cli_idTextBox.Text);
                        bll.Alterar(cli);
                        MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + cli.Cli_id.ToString());
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
                    ClienteBLL bll = new ClienteBLL(conexao);

                    bll.Excluir(Convert.ToInt32(cli_idTextBox.Text));
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
        
        private void picMaximizar_Click(object sender, EventArgs e)
        {
     //       this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
               
    }
    
}

