using System;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;
using System.Drawing;

namespace Sistema
{

    public partial class form_CadAnimal_CadEspecie : Form
    {
        public int codigo = 0;

        public form_CadAnimal_CadEspecie()
        {
            InitializeComponent();
        }
                
        public string operacao;

        //---------- CONFIG BOTOES - ON/ OFF ---------------- //
        public void alterarBotoes(int op)
        {
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

        }

        // ------- LIMPAR A TELA ----------------------//
        public void LimpaTela()
        {
            esp_idTextBox.Clear();
            esp_descriçaoTextBox.Clear();
        }

        //-------- LOAD DO FORM + INICIA CONFIG BOTOES --------------//
        private void form_CadAnimal_CadEspecie_Load(object sender, EventArgs e)
        {
            //this.tbEspecieTableAdapter.Fill(this.dbSistemaDataSet.tbEspecie);

            //----------INICIA CONFIG BOTOES ---------------- //                            
           
            this.alterarBotoes(1);

            this.LimpaTela();
                        
        }
        
        //---------- CONFIG BOTOES - NOVO  ---------------- //
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoes(2);
        }
        
        //---------- CONFIG BOTOES - ALTERAR  ---------------- //
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoes(2);
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
                    EspecieBLL bll = new EspecieBLL(conexao);

                    bll.Excluir(Convert.ToInt32(esp_idTextBox.Text));
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
            try
            {
                //leitura dos dados
                EspecieDTO esp = new EspecieDTO();
             //  esp.Esp_id = Convert.ToInt32(esp_idTextBox.Text); não pode esta ativo se nao aparece o erro de caracter
                esp.Esp_descriçao = esp_descriçaoTextBox.Text;// add 13/01 // se não tiver aparece erro de refeerencia

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                EspecieBLL bll = new EspecieBLL(conexao);


                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(esp);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + esp.Esp_id.ToString());
                    //this.LimpaTela();
                }
                else
                {
                    esp.Esp_id = Convert.ToInt32(esp_idTextBox.Text);
                    bll.Alterar(esp);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + esp.Esp_id.ToString());

                }
                this.LimpaTela();
                this.alterarBotoes(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
       
        //---------- CONFIG BOTOES - PESQUISAR  ---------------- //
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsEspecie Form_Cad = new form_ConsEspecie();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                EspecieBLL bll = new EspecieBLL(conexao);
                EspecieDTO esp = bll.CarregaEspecieDTO(Form_Cad.codigo);
                esp_idTextBox.Text = esp.Esp_id.ToString();
                esp_descriçaoTextBox.Text = esp.Esp_descriçao;
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

        private void pnDados_Paint(object sender, PaintEventArgs e)
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
        //    this.WindowState = FormWindowState.Maximized;
        }

        //encerrar form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_esp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }//class

}//namespace







