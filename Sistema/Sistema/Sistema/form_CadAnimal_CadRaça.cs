using BLL;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

// FORM CADASTRAR RAÇA
// DATA DE MODIFICAÇÃO -> 07/02/17
       

namespace Sistema
{
    public partial class form_CadAnimal_CadRaça : Form
    {
        public int codigo = 0;

        public form_CadAnimal_CadRaça()
        {
            InitializeComponent();
        }
        public string operacao;
        
        //---------- CONFIG BOTOES - ON/ OFF ---------------- //
        public void alterarBotoes(int op)
        {
            /*  1 - inserir e localizar  | * 2 - salva | * 3 - alterar e excluir  */

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

        }

        // ------- LIMPAR A TELA ----------------------//
        public void LimpaTela()
        {
            raç_idTextBox.Clear();
            raç_descriçaoTextBox.Clear();
            raç_especieComboBox.SelectedIndex = -1;
        }
        
        //-------- LOAD DO FORM + INICIA CONFIG BOTOES --------------//
        private void form_CadAnimal_CadRaça_Load(object sender, EventArgs e)
        {
         
            //this.tbEspecieTableAdapter.Fill(this.dbSistemaDataSet.tbEspecie);

            //----------INICIA CONFIG BOTOES ---------------- //                            
            this.alterarBotoes(1);
            
            // IMPORTANTE !!! - sem isso não carrega os cbox
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            //cb especie
            EspecieBLL ebll = new EspecieBLL(conexao);
            raç_especieComboBox.DataSource = ebll.Pesquisar("");
            raç_especieComboBox.DisplayMember = "esp_descriçao";
            raç_especieComboBox.ValueMember = "esp_id";

            this.LimpaTela();
        }
        
        //---------- CONFIG BOTOES - NOVO  ---------------- //
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2); // altera status novo para habilitar salvar
        }
        
        //---------- CONFIG BOTOES - ALTERAR ---------------- //
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoes(2); // altera status novo para habilitar salvar
        }

        //---------- CONFIG BOTOES - EXCLUIR  ---------------- //
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    RaçaBLL bll = new RaçaBLL(conexao);

                    bll.Excluir(Convert.ToInt32(raç_idTextBox.Text));
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

        //---------- CONFIG BOTOES - CANCELAR  ---------------- //
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.alterarBotoes(1);
        }

        //---------- CONFIG BOTOES - SALVAR  ---------------- //
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //leitura dos dados
                    RaçaDTO raça = new RaçaDTO();
                    raça.Raç_descriçao = raç_descriçaoTextBox.Text;
                    raça.Raç_especie = Convert.ToInt32(raç_especieComboBox.SelectedValue);//11-02

                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    RaçaBLL bll = new RaçaBLL(conexao);

                    if (this.operacao == "inserir")
                    {

                        bll.Incluir(raça);

                        MessageBox.Show("Cadastrado com Sucesso: Código: " + raça.Raç_id.ToString());
                       // this.LimpaTela();
                    }
                    else // alterar 
                    {
                        raça.Raç_id = Convert.ToInt32(raç_idTextBox.Text);
                        bll.Alterar(raça);
                        MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + raça.Raç_id.ToString());
                    }
                    this.LimpaTela();
                    this.alterarBotoes(1);

                }//try
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }//salvar

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           // abre o form dentro do form
            form_ConsRaça Form_Cad = new form_ConsRaça();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                RaçaBLL bll = new RaçaBLL(conexao);
                RaçaDTO raça = bll.CarregaRaçaDTO(Form_Cad.codigo);
                raç_idTextBox.Text = raça.Raç_id.ToString();
                raç_descriçaoTextBox.Text = raça.Raç_descriçao;
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
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //minimizar
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //maximizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
  //          this.WindowState = FormWindowState.Maximized;
        }

        //encerrar form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }
    } //class

}//namespace
