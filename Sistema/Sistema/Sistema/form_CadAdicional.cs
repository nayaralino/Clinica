using BLL;
using DAL;
using DTO;
using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class form_CadAdicional : Form
    {
        public int codigo = 0;
        public string operacao;

        public form_CadAdicional()
        {
            InitializeComponent();
        }

        private void form_CadAdicional_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbCidade' table. You can move, or remove it, as needed.
            this.tbCidadeTableAdapter.Fill(this.dbSistemaDataSet.tbCidade);
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbEspecialidade' table. You can move, or remove it, as needed.
            this.tbEspecialidadeTableAdapter.Fill(this.dbSistemaDataSet.tbEspecialidade);
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbTPVacina' table. You can move, or remove it, as needed.
            this.tbTPVacinaTableAdapter.Fill(this.dbSistemaDataSet.tbTPVacina);
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbCargo' table. You can move, or remove it, as needed.
            this.tbCargoTableAdapter.Fill(this.dbSistemaDataSet.tbCargo);
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbEstado' table. You can move, or remove it, as needed.
            this.tbEstadoTableAdapter.Fill(this.dbSistemaDataSet.tbEstado);
            pnExame.Hide();
            pnAplicaçao.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnVacina.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        // GERAL

        private void btnTipoExame_Click(object sender, EventArgs e)
        {
            pnExame.Show();

            pnAplicaçao.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnVacina.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnAplicaçao_Click(object sender, EventArgs e)
        {
            pnAplicaçao.Show();

            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnVacina.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnTipoProtocolo_Click(object sender, EventArgs e)
        {
            pnProtocolo.Show();

            pnExame.Hide();
            pnAplicaçao.Hide();
            pnAtendimento.Hide();
            pnVacina.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnTipoAtendimento_Click(object sender, EventArgs e)
        {
            pnAtendimento.Show();

            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnVacina.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnTipoVacina_Click(object sender, EventArgs e)
        {
            pnVacina.Show();

            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnEspecialidade.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();

        }

        private void btnEspecialidade_Click(object sender, EventArgs e)
        {
            pnEspecialidade.Show();

            pnVacina.Hide();
            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnCargo.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            pnCargo.Show();

            pnVacina.Hide();
            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnEspecialidade.Hide();
            pnCidade.Hide();
            pnEstado.Hide();
        }

        private void btnCidade_Click(object sender, EventArgs e)
        {
            pnCidade.Show();

            pnCargo.Hide();
            pnVacina.Hide();
            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnEspecialidade.Hide();
            pnEstado.Hide();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            pnEstado.Show();

            pnCargo.Hide();
            pnVacina.Hide();
            pnAplicaçao.Hide();
            pnExame.Hide();
            pnProtocolo.Hide();
            pnAtendimento.Hide();
            pnEspecialidade.Hide();
            pnCidade.Hide();
        }

        // EXAME

        public void alterarBotoesEX(int op)
        {
            /*  1 - inserir e localizar  | * 2 - salva | * 3 - alterar e excluir  */

            pnExame.Enabled = true;
            btnPesquisarTPE.Enabled = false;
            btnNovoTPE.Enabled = false;
            btnSalvarTPE.Enabled = false;
            btnAlterarTPE.Enabled = false;
            btnExcluirTPE.Enabled = false;
            btnCancelarTPE.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarTPE.Enabled = true;
                btnNovoTPE.Enabled = true;
                btnCancelarTPE.Enabled = true;
            }

            if (op == 2) // salvar
            {
                pnExame.Enabled = true;
                btnSalvarTPE.Enabled = true;
                btnCancelarTPE.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {
                btnSalvarTPE.Enabled = true;
                pnExame.Enabled = true;
                btnAlterarTPE.Enabled = true;
                btnExcluirTPE.Enabled = true;
                btnCancelarTPE.Enabled = true;
            }

        }

        public void LimpaTelaEX()
        {
            tpe_idTextBox.Clear();
            tpa_descriçaoTextBox.Clear();
        }
       
        private void btnNovoTPE_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesEX(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisarTPE_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsTipoExame Form_Cad = new form_ConsTipoExame()
            {
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent
            };
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoExameBLL bll = new TipoExameBLL(conexao);
                TipoExameDTO tip = bll.CarregaTipoExameDTO(Form_Cad.codigo);
                tpe_idTextBox.Text = tip.Tpe_id.ToString();
                tpa_descriçaoTextBox.Text = tip.Tpe_descriçao;
                alterarBotoesEX(3);
            }
            else
            {
                this.LimpaTelaEX();
                this.alterarBotoesEX(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnSalvarTPE_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                TipoExameDTO tip = new TipoExameDTO()
                {
                    Tpe_descriçao = tpa_descriçaoTextBox.Text
                };

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoExameBLL bll = new TipoExameBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(tip);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + tip.Tpe_id.ToString());
                    // this.LimpaTela();
                }
                else // alterar 
                {
                    tip.Tpe_id = Convert.ToInt32(tpe_idTextBox.Text);
                    bll.Alterar(tip);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + tip.Tpe_id.ToString());
                }
                this.LimpaTelaEX();
                this.alterarBotoesEX(1);

            }//try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarTPE_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoesEX(2); // altera status novo para habilitar salvar
        }

        private void btnExcluirTPE_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    TipoExameBLL bll = new TipoExameBLL(conexao);

                    bll.Excluir(Convert.ToInt32(tpe_idTextBox.Text));
                    this.LimpaTelaEX();
                    this.alterarBotoesEX(1);
                }
            }//try

            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.alterarBotoesEX(3);
            }
        }

        private void btnCancelarTPE_Click(object sender, EventArgs e)
        {
            LimpaTelaEX();
            this.alterarBotoesEX(1);
        }

        // APLICAÇAO

        public void alterarBotoesAP(int op)
        {
            /*  1 - inserir e localizar  | * 2 - salva | * 3 - alterar e excluir  */

            pnAplicaçao.Enabled = true;
            btnPesquisarAP.Enabled = false;
            btnNovoAP.Enabled = false;
            btnSalvarAP.Enabled = false;
            btnAlterarAP.Enabled = false;
            btnExcluirAP.Enabled = false;
            btnCancelarAP.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarAP.Enabled = true;
                btnNovoAP.Enabled = true;
                btnCancelarAP.Enabled = true;
            }

            if (op == 2) // salvar
            {
                pnAplicaçao.Enabled = true;
                btnSalvarAP.Enabled = true;
                btnCancelarAP.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {
                btnSalvarAP.Enabled = true;
                pnExame.Enabled = true;
                btnAlterarAP.Enabled = true;
                btnExcluirAP.Enabled = true;
                btnCancelarAP.Enabled = true;
            }

        }

        public void LimpaTelaAP()
        {
            apl_idTextBox.Clear();
            apl_descriçaoTextBox.Clear();
        }



        private void btnNovoAP_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesAP(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisarAP_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAP_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                AplicaçaoDTO apl = new AplicaçaoDTO()
                {
                    Apl_descriçao = apl_descriçaoTextBox.Text
                };

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AplicaçaoBLL bll = new AplicaçaoBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(apl);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + apl.Apl_id.ToString());
                    // this.LimpaTela();
                }
                else // alterar 
                {
                    apl.Apl_id = Convert.ToInt32(apl_idTextBox.Text);
                    bll.Alterar(apl);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + apl.Apl_id.ToString());
                }
                this.LimpaTelaAP();
                this.alterarBotoesAP(1);

            }//try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarAP_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoesAP(2); // altera status novo para habilitar salvar
        }

        private void btnExcluirAP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    AplicaçaoBLL bll = new AplicaçaoBLL(conexao);

                    bll.Excluir(Convert.ToInt32(tpe_idTextBox.Text));
                    this.LimpaTelaAP();
                    this.alterarBotoesAP(1);
                }
            }//try

            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.alterarBotoesAP(3);
            }
        }

        private void btnCancelarAP_Click(object sender, EventArgs e)
        {
            LimpaTelaAP();
            this.alterarBotoesAP(1);
        }

        // PROTOCOLO

        public void alterarBotoesPT(int op)
        {
            /*  1 - inserir e localizar  | * 2 - salva | * 3 - alterar e excluir  */

            pnProtocolo.Enabled = true;
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
                pnProtocolo.Enabled = true;
                btnSalvarPT.Enabled = true;
                btnCancelarPT.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {
                btnSalvarPT.Enabled = true;
                pnProtocolo.Enabled = true;
                btnAlterarPT.Enabled = true;
                btnExcluirPT.Enabled = true;
                btnCancelarPT.Enabled = true;
            }

        }

        // ------- LIMPAR A TELA ----------------------//
        public void LimpaTelaPT()
        {
            tpp_idTextBox.Clear();
            tpp_descriçaoTextBox.Clear();

        }
       
        private void btnNovoPT_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesPT(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisarPT_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsTipoProtocolo Form_Cad = new form_ConsTipoProtocolo()
            {
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent
            };
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoProtocoloBLL bll = new TipoProtocoloBLL(conexao);
                TipoProtocoloDTO tipop = bll.CarregaTipoProtocoloDTO(Form_Cad.codigo);
                tpp_idTextBox.Text = tipop.Tipop_id.ToString();
                tpp_descriçaoTextBox.Text = tipop.Tipop_descriçao;
                alterarBotoesPT(3);
            }
            else
            {
                this.LimpaTelaPT();
                this.alterarBotoesPT(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnSalvarPT_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                TipoProtocoloDTO tipop = new TipoProtocoloDTO()
                {
                    Tipop_descriçao = tpp_descriçaoTextBox.Text
                };

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoProtocoloBLL bll = new TipoProtocoloBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(tipop);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + tipop.Tipop_id.ToString());
                    // this.LimpaTela();
                }
                else // alterar 
                {
                    tipop.Tipop_id = Convert.ToInt32(tpp_idTextBox.Text);
                    bll.Alterar(tipop);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + tipop.Tipop_id.ToString());
                }
                this.LimpaTelaPT();
                this.alterarBotoesPT(1);

            }//try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarPT_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoesPT(2); // altera status novo para habilitar salvar
        }

        private void btnExcluirPT_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    TipoProtocoloBLL bll = new TipoProtocoloBLL(conexao);

                    bll.Excluir(Convert.ToInt32(tpp_idTextBox.Text));
                    this.LimpaTelaPT();
                    this.alterarBotoesPT(1);
                }
            }//try
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.alterarBotoesPT(3);
            }
        }

        private void btnCancelarPT_Click(object sender, EventArgs e)
        {
            LimpaTelaPT();
            this.alterarBotoesPT(1);
        }


        // TIPO ATENDIMENTO

        public void alterarBotoesAT(int op)
        {
            /*  1 - inserir e localizar  | * 2 - salva | * 3 - alterar e excluir  */

            pnAtendimento.Enabled = true;
            btnPesquisarAT.Enabled = false;
            btnNovoAT.Enabled = false;
            btnSalvarAT.Enabled = false;
            btnAlterarAT.Enabled = false;
            btnExcluirAT.Enabled = false;
            btnCancelarAT.Enabled = false;


            if (op == 1) // inserir - localizar
            {
                btnPesquisarAT.Enabled = true;
                btnNovoAT.Enabled = true;
                btnCancelarAT.Enabled = true;
            }

            if (op == 2) // salvar
            {
                pnAtendimento.Enabled = true;
                btnSalvarAT.Enabled = true;
                btnCancelarAT.Enabled = true;
            }

            if (op == 3) // alterar - excluir
            {
                btnSalvarAT.Enabled = true;
                pnAtendimento.Enabled = true;
                btnAlterarAT.Enabled = true;
                btnExcluirAT.Enabled = true;
                btnCancelarAT.Enabled = true;
            }

        }

        public void LimpaTelaAT()
        {
            tpa_idTextBox.Clear();
            tpa_descriçaoTextBox.Clear();
        }

        private void btnNovoAT_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alterarBotoesPT(2); // altera status novo para habilitar salvar
        }

        private void btnPesquisarAT_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsTipoAtendimento Form_Cad = new form_ConsTipoAtendimento()
            {
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent
            };
            Form_Cad.ShowDialog(ActiveForm);

            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoAtendimentoBLL bll = new TipoAtendimentoBLL(conexao);
            //    TipoAtendimentoDTO tpa = bll.CarregaTipoAtendimentoDTO(Form_Cad.codigo);
            //    tpp_idTextBox.Text = tpa.Tpa_id.ToString();
            //    tpp_descriçaoTextBox.Text = tpa.Tpa_atendimento;
                alterarBotoesAT(3);
            }
            else
            {
                this.LimpaTelaAT();
                this.alterarBotoesAT(1);
            }

            //encerra form
            Form_Cad.Dispose();
        }

        private void btnSalvarAT_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                TipoAtendimentoDTO tip = new TipoAtendimentoDTO()
                {
                    Tpa_atendimento = tpa_descriçaoTextBox.Text
                };

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                TipoAtendimentoBLL bll = new TipoAtendimentoBLL(conexao);

                if (this.operacao == "inserir")
                {

                    bll.Incluir(tip);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + tip.Tpa_id.ToString());
                     
                }
                else // alterar 
                {
                    tip.Tpa_id = Convert.ToInt32(tpp_idTextBox.Text);
                    bll.Alterar(tip);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + tip.Tpa_id.ToString());
                }
                this.LimpaTelaAT();
                this.alterarBotoesAT(1);

            }//try
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterarAT_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alterarBotoesAT(2); // altera status novo para habilitar salvar
        }

        private void btnExcluirAT_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //obj para gravar dados no bd
                    ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                    TipoAtendimentoBLL bll = new TipoAtendimentoBLL(conexao);

                    bll.Excluir(Convert.ToInt32(tpa_idTextBox.Text));
                    this.LimpaTelaAT();
                    this.alterarBotoesAT(1);
                }
            }//try
            catch
            {
                MessageBox.Show("Impossível excluir o registro.\n O registro está sendo utilizado em outro local.");
                this.alterarBotoesPT(3);
            }
        }

        private void btnCancelarAT_Click(object sender, EventArgs e)
        {
            LimpaTelaAT();
            this.alterarBotoesAT(1);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void est_descriçaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void est_descriçaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void est_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void est_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void pnCidade_Paint(object sender, PaintEventArgs e)
        {

        }

        private void car_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void pnCargo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void car_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void car_cargoLabel_Click(object sender, EventArgs e)
        {

        }

        private void car_cargoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

