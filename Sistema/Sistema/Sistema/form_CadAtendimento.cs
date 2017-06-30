using BLL;
using DAL;
using DTO;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// Data de criação 016/02
// Data de modificação 18/03 - inclusão das funcionalidades do IC

namespace Sistema
{
    public partial class Form_CadAtendimento : Form
    {
        //     DateTime ate_data;
        //     DateTime ate_hora;
        //     exemplo dentro do load --- datalb.Text = "Data: " + ate_data.ToLongDateString() + "\nHora: " + ate_data.ToLongTimeString();

        public Form_CadAtendimento()
        {
            InitializeComponent();
        }

        public string operacao;

        private void Form_CadAtendimento_Load(object sender, EventArgs e)
        {
          
            pnInfo.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnPrescriçaoMedica.Hide();
            pnSuspeitaClinica.Hide();            
            pnVacina.Hide();
            pnDocumento.Hide();

            //      ate_data = DateTime.Now;
            //      datalb.Text = "Data: " + ate_data.ToShortDateString();

            //       ate_hora = DateTime.Now;
            //       lbhora.Text = "Hora: " + ate_hora.ToShortTimeString();


            //----------INICIA CONFIG BOTOES ---------------- //   
            this.AlterarBotoes(1);

            // ----------COMBOBOX's -----------------------------//
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            // cb medico
            MedicoBLL medbll = new MedicoBLL(conexao);
            ate_medicoComboBox.DataSource = medbll.Pesquisar("");
            ate_medicoComboBox.DisplayMember = "med_nome";
            ate_medicoComboBox.ValueMember = "med_id";
            // cb tipo atendimento
            TipoAtendimentoBLL tipbll = new TipoAtendimentoBLL(conexao);
            ate_tipoComboBox.DataSource = tipbll.Pesquisar("");
            ate_tipoComboBox.DisplayMember = "tpa_atendimento";
            ate_tipoComboBox.ValueMember = "tpa_id";
            // cb animal
            AnimalBLL anibll = new AnimalBLL(conexao);
            ate_animalComboBox.DataSource = anibll.PesquisarNomeAnimal("");
            ate_animalComboBox.DisplayMember = "ani_nome";
            ate_animalComboBox.ValueMember = "ani_id";

            // ----------COMBOBOX's Exame-----------------------------//
            // cb tipo exame
            TipoExameBLL exabll = new TipoExameBLL(conexao);
            exame_tipoComboBox.DataSource = exabll.Pesquisar("");
            exame_tipoComboBox.DisplayMember = "tpe_descriçao";
            exame_tipoComboBox.ValueMember = "tpe_id";

            // ----------COMBOBOX's Protocolo-----------------------------//
            // cb aplicação
            AplicaçaoBLL aplibll = new AplicaçaoBLL(conexao);
            prot_aplicaçaoComboBox.DataSource = aplibll.Pesquisar("");
            prot_aplicaçaoComboBox.DisplayMember = "apl_descriçao";
            prot_aplicaçaoComboBox.ValueMember = "apl_id";

            // cb tipo protocolo
            TipoProtocoloBLL protbll = new TipoProtocoloBLL(conexao);
            prot_tipoComboBox.DataSource = protbll.Pesquisar("");
            prot_tipoComboBox.DisplayMember = "tpp_descriçao";
            prot_tipoComboBox.ValueMember = "tpp_id";

            // ----------COMBOBOX's Vacina-----------------------------//
           
            // cb tipo vacina
            TipoVacinaBLL vaccbll = new TipoVacinaBLL(conexao);
            vac_tipoComboBox.DataSource = vaccbll.Pesquisar("");
            vac_tipoComboBox.DisplayMember = "tpv_descriçao";
            vac_tipoComboBox.ValueMember = "tpv_id";

            // cb tipo protocolo
            AplicaçaoBLL aplivbll = new AplicaçaoBLL(conexao);
            vac_aplicaçaoComboBox.DataSource = aplivbll.Pesquisar("");
            vac_aplicaçaoComboBox.DisplayMember = "apl_descriçao";
            vac_aplicaçaoComboBox.ValueMember = "apl_id";

            this.LimpaTela();
        }

        /// ///////////////////////////////////////////////////////////////////////////////////
        ///                                                                                 ///
        ///                         Cadastro do Atendimento                                 ///
        ///                                                                                 ///
        ///////////////////////////////////////////////////////////////////////////////////////

        public void AlterarBotoes(int op)
        {            
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir    */
            
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

        public void LimpaTela()
        {
            ate_idTextBox.Clear();
            ate_clienteTextBox.Clear();
            ate_clienteNomeTextBox.Clear();
            ate_anamneseTextBox.Clear();
            ate_tratamentoTextBox.Clear();
            ate_animalComboBox.SelectedIndex = -1;
            ate_medicoComboBox.SelectedIndex = -1;
            ate_tipoComboBox.SelectedIndex = -1;

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoes(2);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                ate_idTextBox.Text = ate.Ate_id.ToString();
                ate_clienteTextBox.Text = ate.Ate_cliente.ToString();

                ate_animalComboBox.SelectedValue = ate.Ate_animal;  // remover depois
                ate_medicoComboBox.SelectedValue = ate.Ate_medico;
                ate_tipoComboBox.SelectedValue = ate.Ate_tipo;
                ate_anamneseTextBox.Text = ate.Ate_anamnese;
                ate_tratamentoTextBox.Text = ate.Ate_tratamento;
                                
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                AtendimentoDTO ate = new AtendimentoDTO();

                ate.Ate_cliente = Convert.ToInt32(ate_clienteTextBox.Text);
                ate.Ate_animal = Convert.ToInt32(ate_animalComboBox.SelectedValue); // remover depois
                ate.Ate_medico = Convert.ToInt32(ate_medicoComboBox.SelectedValue);
                ate.Ate_tipo = Convert.ToInt32(ate_tipoComboBox.SelectedValue);
                ate.Ate_anamnese = ate_anamneseTextBox.Text;
                ate.Ate_tratamento = ate_tratamentoTextBox.Text;
              
                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);


                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(ate);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + ate.Ate_id.ToString());

                    //this.LimpaTela();

                    pnInfo.Show();

                }
                else
                {
                    ate.Ate_id = Convert.ToInt32(ate_idTextBox.Text);
                    bll.Alterar(ate);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + ate.Ate_id.ToString());

                }
                this.LimpaTela();
                this.AlterarBotoes(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.AlterarBotoes(2);
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
                    AtendimentoBLL bll = new AtendimentoBLL(conexao);

                    bll.Excluir(Convert.ToInt32(ate_idTextBox.Text));
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            this.AlterarBotoes(1);
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
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
                ate_clienteTextBox.Text = cli.Cli_id.ToString();
                ate_clienteNomeTextBox.Text = cli.Cli_nome.ToString();

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

        // BOTÕES MINIMIZAR E FECHAR
        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        
        ///////////////////////////////////////////////////////////////////////////////////////
        ///                                                                                 ///
        ///              Informações Complementares do Atendimento                          ///
        ///                                                                                 ///
        ///////////////////////////////////////////////////////////////////////////////////////

        // BOTÕES ABRIR OS PANELs
        private void btnExame_Click(object sender, EventArgs e)
        {
            pnExame.Show();

            pnProtocolo.Hide();
            pnSuspeitaClinica.Hide();
            pnPrescriçaoMedica.Hide();
            pnDocumento.Hide();                 
            pnVacina.Hide();
        }

        private void btnProtocolo_Click(object sender, EventArgs e)
        {
            pnProtocolo.Show();
            pnPrescriçaoMedica.Hide();
            pnExame.Hide();
            pnSuspeitaClinica.Hide();
            pnDocumento.Hide();
                   
            pnVacina.Hide();
        }

        private void picFecharInfo_Click(object sender, EventArgs e)
        {
            pnInfo.Hide();
        }

        private void btnMenuIC_Click(object sender, EventArgs e)
        {
            pnInfo.Show();
        }

        private void btnSuspeita_Click(object sender, EventArgs e)
        {
            pnSuspeitaClinica.Show();

            pnExame.Hide();
            pnProtocolo.Hide();
            pnPrescriçaoMedica.Hide();
            pnDocumento.Hide();

           pnVacina.Hide();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            pnDocumento.Show();

            pnExame.Hide();
            pnProtocolo.Hide();
            pnSuspeitaClinica.Hide();
            pnPrescriçaoMedica.Hide();
            pnVacina.Hide();
        }

        private void btnPrescriçao_Click(object sender, EventArgs e)
        {
            pnPrescriçaoMedica.Show();

            pnExame.Hide();
            pnProtocolo.Hide();
            pnSuspeitaClinica.Hide();
            pnDocumento.Hide();
            pnVacina.Hide();
        }


        private void btnVacina_Click(object sender, EventArgs e)
        {
            pnVacina.Show();

            pnPrescriçaoMedica.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnSuspeitaClinica.Hide();
            pnDocumento.Hide();
        }


        // Painel do Exame 

        public void alterarBotoesExame(int op)
        {
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir    */

            btnPesquisarEX.Enabled = false;
            btnNovoEX.Enabled = false;
            btnSalvarEX.Enabled = false;
            btnAlterarEX.Enabled = false;
            btnExcluirEX.Enabled = false;
            btnCancelarEX.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarEX.Enabled = true;
                btnNovoEX.Enabled = true;
                btnCancelarEX.Enabled = true;
            }

            if (op == 2) // salvar
            {

                btnSalvarEX.Enabled = true;
                btnCancelarEX.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {

                btnSalvarEX.Enabled = true;
                btnAlterarEX.Enabled = true;
                btnExcluirEX.Enabled = true;
                btnCancelarEX.Enabled = true;
            }

        }

        public void LimpaTelaExame()
        {
            exame_idTextBox.Clear();
            exame_atendimentoTextBox.Clear();
            exame_dtSolicitaçaoTextBox.Clear();
            exame_dtResultadoTextBox.Clear();
            exame_tipoComboBox.SelectedIndex = -1;
            exame_laboratorioTextBox.Clear();
            exame_resultadoTextBox.Clear();
        }

        private void btnNovoEX_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesExame(2);
        }

        private void btnSalvarEX_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ExameDTO exa = new ExameDTO();

                exa.Exame_atendimento = exame_atendimentoTextBox.Text;
                exa.Exame_dtSolicitaçao = exame_dtSolicitaçaoTextBox.Text;
                exa.Exame_dtResultado = exame_dtResultadoTextBox.Text;
                exa.Exame_laboratorio = exame_laboratorioTextBox.Text;
                exa.Exame_resultado = exame_resultadoTextBox.Text;
                exa.Exame_tipo = Convert.ToString(exame_tipoComboBox.SelectedValue);

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ExameBLL bll = new ExameBLL(conexao);


                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(exa);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + exa.Exame_id.ToString());

                    //this.LimpaTela();

                    pnInfo.Show();

                }
                else
                {
                    exa.Exame_id = Convert.ToInt32(exame_idTextBox.Text);
                    bll.Alterar(exa);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + exa.Exame_id.ToString());

                }
                this.LimpaTelaExame();
                this.alterarBotoesExame(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarEX_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.alterarBotoesExame(2);
        }

        private void btnCancelarEX_Click(object sender, EventArgs e)
        {
            LimpaTelaExame();
            this.alterarBotoesExame(1);
        }

        private void btnExcluirEX_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEX_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarATEX_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                exame_atendimentoTextBox.Text = ate.Ate_id.ToString();

                alterarBotoesExame(3);
            }
            else
            {
                this.LimpaTelaExame();
                this.alterarBotoesExame(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnPesquisarEX_Click(object sender, EventArgs e)
        {

        }


        // Painel do Protocolo 

        public void alterarBotoesPT(int op)
        {
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir    */

            btnPesquisarPT.Enabled = false;
            btnNovoPT.Enabled = false;
            btnSalvarPT.Enabled = false;
            btnAlterarPT.Enabled = false;
            btnExcluirPT.Enabled = false;
            btnCancelarPT.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarPT.Enabled = true;
                btnNovoPT.Enabled = true;
                btnCancelarPT.Enabled = true;
            }

            if (op == 2) // salvar
            {

                btnSalvarPT.Enabled = true;
                btnCancelarPT.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {

                btnSalvarPT.Enabled = true;
                btnAlterarPT.Enabled = true;
                btnExcluirPT.Enabled = true;
                btnCancelarPT.Enabled = true;
            }
        }

        public void LimpaTelaPT()
        {
            prot_idTextBox.Clear();
            prot_atendimentoTextBox.Clear();
            prot_tipoComboBox.SelectedIndex = -1;
            prot_aplicaçaoComboBox.SelectedIndex = -1;
            prot_dataTextBox.Clear();
            prot_intervaloTextBox.Clear();
        }

        private void btnPesquisarATPT_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                prot_atendimentoTextBox.Text = ate.Ate_id.ToString();

                alterarBotoesExame(3);
            }
            else
            {
                this.LimpaTelaExame();
                this.alterarBotoesExame(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnNovoPT_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesPT(2);
        }

        private void btnPesquisarPT_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarPT_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ProtocoloDTO prot = new ProtocoloDTO();

                prot.Prot_atendimento = Convert.ToInt32(prot_atendimentoTextBox.Text);
                prot.Prot_tipo = Convert.ToInt32(prot_tipoComboBox.SelectedValue);
                prot.Prot_aplicaçao = Convert.ToInt32(prot_tipoComboBox.SelectedValue);
                //        prot.Prot_data = prot_dataTextBox.Text;
                prot.Prot_data = prot_dataTextBox.Text;
                prot.Prot_intervalo = prot_intervaloTextBox.Text;

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ProtocoloBLL bll = new ProtocoloBLL(conexao);

                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(prot);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + prot.Prot_id.ToString());

                    pnInfo.Show();

                }
                else
                {
                    prot.Prot_id = Convert.ToInt32(prot_idTextBox.Text);
                    bll.Alterar(prot);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + prot.Prot_id.ToString());

                }
                this.LimpaTelaPT();
                this.alterarBotoesPT(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarPT_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.alterarBotoesPT(2);
        }

        private void btnExcluirPT_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarPT_Click(object sender, EventArgs e)
        {
            LimpaTelaPT();
            this.alterarBotoesPT(1);
        }


        // Painel da Prescrição Médica

        public void alterarBotoesPM(int op)
        {
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir    */

            btnPesquisarPM.Enabled = false;
            btnNovoPM.Enabled = false;
            btnSalvarPM.Enabled = false;
            btnAlterarPM.Enabled = false;
            btnExcluirPM.Enabled = false;
            btnCancelarPM.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarPM.Enabled = true;
                btnNovoPM.Enabled = true;
                btnCancelarPM.Enabled = true;
            }

            if (op == 2) // salvar
            {

                btnSalvarPM.Enabled = true;
                btnCancelarPM.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {

                btnSalvarPM.Enabled = true;
                btnAlterarPM.Enabled = true;
                btnExcluirPM.Enabled = true;
                btnCancelarPM.Enabled = true;
            }
        }

        public void LimpaTelaPM()
        {
            pre_idTextBox.Clear();
            pre_atendimentoTextBox.Clear();
            pre_prescriçaoTextBox.Clear();

        }

        private void btnPesquisarATPM_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                pre_atendimentoTextBox.Text = ate.Ate_id.ToString();

                alterarBotoesExame(3);
            }
            else
            {
                this.LimpaTelaExame();
                this.alterarBotoesExame(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnNovoPM_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesPM(2);
        }

        private void btnPesquisarPM_Click(object sender, EventArgs e)
        {

        }
                 
        private void btnSalvarPM_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                PrescriçaoDTO pres = new PrescriçaoDTO();

                pres.Pres_atendimento = Convert.ToInt32(pre_atendimentoTextBox.Text);
                pres.Pres_prescriçao = pre_prescriçaoTextBox.Text;

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                PrescriçaoBLL bll = new PrescriçaoBLL(conexao);

                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(pres);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + pres.Pres_id.ToString());

                    pnInfo.Show();

                }
                else
                {
                    pres.Pres_id = Convert.ToInt32(pre_idTextBox.Text);
                    bll.Alterar(pres);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + pres.Pres_id.ToString());

                }
                this.LimpaTelaPM();
                this.alterarBotoesPM(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarPM_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.alterarBotoesPM(2);
        }

        private void btnExcluirPM_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarPM_Click(object sender, EventArgs e)
        {
            LimpaTelaPM();
            this.alterarBotoesPM(1);
        }

        
        // Painel da Suspeita Clínica


        public void AlterarBotoesSU(int op)
        {
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir   */

            btnPesquisarSU.Enabled = false;
            btnNovoSU.Enabled = false;
            btnSalvarSU.Enabled = false;
            btnAlterarSU.Enabled = false;
            btnExcluirSU.Enabled = false;
            btnCancelarSU.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarSU.Enabled = true;
                btnNovoSU.Enabled = true;
                btnCancelarSU.Enabled = true;
            }

            if (op == 2) // salvar
            {

                btnSalvarSU.Enabled = true;
                btnCancelarSU.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {

                btnSalvarSU.Enabled = true;
                btnAlterarSU.Enabled = true;
                btnExcluirSU.Enabled = true;
                btnCancelarSU.Enabled = true;
            }
        }

        public void LimpaTelaSU()
        {
            sus_idTextBox.Clear();
            sus_atendimentoTextBox.Clear();
            sus_suspeitaTextBox.Clear();

        }

        private void btnPesquisarATSU_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                sus_atendimentoTextBox.Text = ate.Ate_id.ToString();

                AlterarBotoesSU(3);
            }
            else
            {
                this.LimpaTelaSU();
                this.AlterarBotoesSU(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void BtnNovoSU_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlterarBotoesSU(2);
        }

        private void BtnPesquisarSU_Click(object sender, EventArgs e)
        {

        }
         
        private void BtnSalvarSU_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                SuspeitaDTO sus = new SuspeitaDTO();

                sus.Sus_atendimento = Convert.ToInt32(sus_atendimentoTextBox.Text);
                sus.Sus_suspeita = sus_suspeitaTextBox.Text;

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                SuspeitaBLL bll = new SuspeitaBLL(conexao);

                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(sus);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + sus.Sus_id.ToString());

                    pnInfo.Show();

                }
                else
                {
                    sus.Sus_id = Convert.ToInt32(pre_idTextBox.Text);
                    bll.Alterar(sus);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + sus.Sus_id.ToString());

                }
                this.LimpaTelaPM();
                this.alterarBotoesPM(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlterarSU_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.AlterarBotoesSU(2);
        }

        private void BtnExcluirSU_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarSU_Click(object sender, EventArgs e)
        {
            LimpaTelaSU();
            this.AlterarBotoesSU(1);
        }


        // VACINA

        public void AlterarBotoesVA(int op)
        {
            /* 1 - inserir e localizar | 2 - salva | 3 - alterar e excluir   */

            btnPesquisarVA.Enabled = false;
            btnNovoVA.Enabled = false;
            btnSalvarVA.Enabled = false;
            btnAlterarVA.Enabled = false;
            btnExcluirVA.Enabled = false;
            btnCancelarVA.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarVA.Enabled = true;
                btnNovoVA.Enabled = true;
                btnCancelarVA.Enabled = true;
            }

            if (op == 2) // salvar
            {

                btnSalvarVA.Enabled = true;
                btnCancelarVA.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {

                btnSalvarVA.Enabled = true;
                btnAlterarVA.Enabled = true;
                btnExcluirVA.Enabled = true;
                btnCancelarVA.Enabled = true;
            }
        }

        public void LimpaTelaVA()
        {
            sus_idTextBox.Clear();
            sus_atendimentoTextBox.Clear();
            sus_suspeitaTextBox.Clear();

        }

        private void BtnPesquisarATVA_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAtendimento Form_Cad = new form_ConsAtendimento();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                AtendimentoDTO ate = bll.CarregaAtendimentoDTO(Form_Cad.codigo);

                ClienteBLL cbll = new ClienteBLL(conexao);

                //Verificar se OK
                vac_atendimentoTextBox.Text = ate.Ate_id.ToString();

                AlterarBotoesVA(3);
            }
            else
            {
                this.LimpaTelaVA();
                this.AlterarBotoesVA(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void BtnNovoVA_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";

            this.AlterarBotoesVA(2);
        }

        private void BtnPesquisarVA_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                VacinaDTO vac = new VacinaDTO(); // falta alterar dto, dal, bll

               // vac.Vac_atendimento = vac_atendimentoTextBox.Text;
             //   vac.Vac_atendimento = vac_atendimentoTextBox.Text;

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                VacinaBLL bll = new VacinaBLL(conexao);

                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(vac);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + vac.Vac_id.ToString());

                    pnInfo.Show();

                }
                else
                {
                    vac.Vac_id = Convert.ToInt32(pre_idTextBox.Text);
                    bll.Alterar(vac);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + vac.Vac_id.ToString());

                }
                this.LimpaTelaVA();
                this.AlterarBotoesVA(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnSalvarVA_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                VacinaDTO vac = new VacinaDTO()
                {
                    Vac_atendimento = vac_atendimentoTextBox.Text,
                    Vac_tipo = Convert.ToInt32(vac_tipoComboBox.Text),
                    Vac_aplicaçao = Convert.ToInt32(vac_aplicaçaoComboBox.Text),
                    Vac_data = vac_dataTextBox.Text,
                    Vac_intervalo = vac_intervaloTextBox.Text
                };

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                VacinaBLL bll = new VacinaBLL(conexao);

                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(vac);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + vac.Vac_id.ToString());

                    pnInfo.Show();

                }
                else
                {
                    vac.Vac_id = Convert.ToInt32(pre_idTextBox.Text);
                    bll.Alterar(vac);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + vac.Vac_id.ToString());

                }
                this.LimpaTelaVA();
                this.AlterarBotoesVA(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void BtnAlterarVA_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";

            this.AlterarBotoesVA(2);
        }

        private void BtnExcluirVA_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelarVA_Click(object sender, EventArgs e)
        {
            LimpaTelaVA();

            this.AlterarBotoesVA(1);
        }

        private void pnDocumento_Paint(object sender, PaintEventArgs e)
        {

        }
    } //class

}//namespace
