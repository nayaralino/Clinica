using System;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

// Data de criação 13/02
// Data de modificação 14/02


namespace Sistema
{
    public partial class form_CadMedico : Form
    {
        public int codigo = 0;

        public form_CadMedico()
        {
            InitializeComponent();
        }

        public string operacao;

        //---------- CONFIG BOTOES - ON/ OFF ---------------- //
        public void AlterarBotoes(int op)
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
            med_idTextBox.Clear();
            med_nomeTextBox.Clear();
            med_crmvTextBox.Clear();
            med_logradouroTextBox.Clear();
            med_numeroTextBox.Clear();
            med_complementoTextBox.Clear();
            med_bairroTextBox.Clear();
            med_cidadeComboBox.SelectedIndex = -1;
            med_estadoComboBox.SelectedIndex = -1;
            med_especialidadeComboBox.SelectedIndex = -1;
        }

        //-------- LOAD DO FORM + INICIA CONFIG BOTOES --------------//
        private void Form_CadMedico_Load(object sender, EventArgs e)
        {
           //----------INICIA CONFIG BOTOES ---------------- //                            

            this.AlterarBotoes(1);

            this.LimpaTela();

            // IMPORTANTE !!! - sem isso não carrega os cbox /// !!!!!!!!!!!!!! Tem q criar os blls, dtos, dal para cada item se n n mostra
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            //cb cidade
            CidadeBLL cidbll = new CidadeBLL(conexao);
            med_cidadeComboBox.DataSource = cidbll.Pesquisar("");
            med_cidadeComboBox.DisplayMember = "cid_descriçao"; 
            med_cidadeComboBox.ValueMember = "cid_id";
            //cb estado
            EstadoBLL estbll = new EstadoBLL(conexao);
            med_estadoComboBox.DataSource = estbll.Pesquisar("");
            med_estadoComboBox.DisplayMember = "est_descriçao";
            med_estadoComboBox.ValueMember = "est_id";
            //cb estado
            EspecialidadeBLL especbll = new EspecialidadeBLL(conexao);
            med_especialidadeComboBox.DataSource = especbll.Pesquisar("");
            med_especialidadeComboBox.DisplayMember = "espec_descriçao";
            med_especialidadeComboBox.ValueMember = "espec_id";



        }

        //---------- CONFIG BOTOES - NOVO  ---------------- //
        private void BtnNovo_Click(object sender, EventArgs e)
        {        
            this.operacao = "inserir";
            this.AlterarBotoes(2); // altera status novo para habilitar salvar
        }

        //---------- CONFIG BOTOES - ALTERAR  ---------------- //
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlterarBotoes(2); // altera status novo para habilitar salvar
        }

        //---------- CONFIG BOTOES - EXCLUIR  ---------------- //
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    MedicoBLL bll = new MedicoBLL(conexao);

                    bll.Excluir(Convert.ToInt32(med_idTextBox.Text));
                    this.LimpaTela();
                    this.AlterarBotoes(1);
                }
            }//try
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.AlterarBotoes(3);


            }
        }

        //---------- CONFIG BOTOES - CANCELAR  ---------------- //
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.AlterarBotoes(1);
        }

        //---------- CONFIG BOTOES - SALVAR  ---------------- //
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //leitura dos dados
                    MedicoDTO med = new MedicoDTO()
                    {
                        Med_nome = med_nomeTextBox.Text,
                        Med_crmv = med_crmvTextBox.Text,
                        Med_especialidade = Convert.ToInt32(med_especialidadeComboBox.SelectedValue),
                        Med_logradouro = med_logradouroTextBox.Text,// to string? ok
                        Med_numero = med_numeroTextBox.Text,// to string? ok
                        Med_complemento = med_complementoTextBox.Text,// to string? ok
                        Med_bairro = med_bairroTextBox.Text,// to string? ok
                        Med_cidade = Convert.ToInt32(med_cidadeComboBox.SelectedValue),
                        Med_estado = Convert.ToInt32(med_estadoComboBox.SelectedValue)
                    };


                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    MedicoBLL bll = new MedicoBLL(conexao);

                    if (this.operacao == "inserir")
                    {

                        bll.Incluir(med);

                        MessageBox.Show("Cadastrado com Sucesso: Código: " + med.Med_id.ToString());
                        // this.LimpaTela();
                    }
                    else // alterar 
                    {
                        med.Med_id = Convert.ToInt32(med_idTextBox.Text);
                        bll.Alterar(med);
                        MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + med.Med_id.ToString());
                    }
                    this.LimpaTela();
                    this.AlterarBotoes(1);

                }//try
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        //---------- CONFIG BOTOES - PESQUISAR  ---------------- //
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsMedico Form_Cad = new form_ConsMedico()
            {
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent
            };
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                MedicoBLL bll = new MedicoBLL(conexao);
                MedicoDTO med = bll.CarregaMedicoDTO(Form_Cad.codigo);
                med_idTextBox.Text = med.Med_id.ToString();
                med_nomeTextBox.Text = med.Med_nome;
                med_crmvTextBox.Text = med.Med_crmv;
                med_especialidadeComboBox.SelectedValue = med.Med_especialidade;
                med_logradouroTextBox.Text = med.Med_logradouro;
                med_numeroTextBox.Text = med.Med_numero;
                med_complementoTextBox.Text = med.Med_complemento;
                med_bairroTextBox.Text = med.Med_bairro.ToString();
                med_cidadeComboBox.SelectedValue = med.Med_cidade;
                med_estadoComboBox.SelectedValue = med.Med_estado;
                
                AlterarBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.AlterarBotoes(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        
        private void PicMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMaximizar_Click(object sender, EventArgs e)
        {
    //        this.WindowState = FormWindowState.Maximized;
        }

        private void PicFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
