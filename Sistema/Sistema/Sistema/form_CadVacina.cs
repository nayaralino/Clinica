using BLL;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

// Data de criação 21/02
// Data de alteração 21/02

namespace Sistema
{
    public partial class form_CadVacina : Form
    {
        public form_CadVacina()
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
            vac_idTextBox.Clear();
            vac_vacinaTextBox.Clear();

        }

        private void form_CadVacina_Load(object sender, EventArgs e)
        {
            this.alterarBotoes(1);

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
            form_ConsVacina Form_Cad = new form_ConsVacina();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                VacinaBLL bll = new VacinaBLL(conexao);
                VacinaDTO vac = bll.CarregaVacinaDTO(Form_Cad.codigo);
                vac_idTextBox.Text = vac.Vac_id.ToString();
             //   vac_vacinaTextBox.Text = vac.Vac_;
                
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
                VacinaDTO vac = new VacinaDTO();  

             //   vac.Vac_vacina = vac_vacinaTextBox.Text;
                

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                VacinaBLL bll = new VacinaBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(vac);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + vac.Vac_id.ToString());
                    // this.LimpaTela();
                }
                else // alterar 
                {
                    vac.Vac_id = Convert.ToInt32(vac_idTextBox.Text);
                    bll.Alterar(vac);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + vac.Vac_id.ToString());
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
                    VacinaBLL bll = new VacinaBLL(conexao);

                    bll.Excluir(Convert.ToInt32(vac_idTextBox.Text));
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
