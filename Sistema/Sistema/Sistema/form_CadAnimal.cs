using System;
using System.Windows.Forms;
using DAL;
using BLL;
using DTO;

// Data de criação 09/02
// Data de modificação 09/02
// Status OK //

namespace Sistema
{
    public partial class form_CadAnimal : Form
    {
        public int codigo = 0;
        public int ani_cliente = 0;

        public form_CadAnimal()
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

        public void LimpaTela()
        {
            ani_idTextBox.Clear();
            ani_nomeTextBox.Clear();
            ani_sexoComboBox.SelectedIndex = -1;
            ani_raçaComboBox.SelectedIndex = -1;
            ani_especieComboBox.SelectedIndex = -1;
            ani_idadeTextBox.Clear();
            ani_pesoTextBox.Clear();
            ani_clienteTextBox.Clear();
            ani_clienteNomeTextBox.Clear();
        }
        
        //-------- LOAD DO FORM + INICIA CONFIG BOTOES --------------//
        private void form_CadAnimal_Load(object sender, EventArgs e)
        {
            //----------INICIA CONFIG BOTOES ---------------- //   
            this.alterarBotoes(1);
            

            // ----------COMBOBOX's -----------------------------//
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);

            // cb sexo
            SexoBLL sbll = new SexoBLL(conexao);
            ani_sexoComboBox.DataSource = sbll.Pesquisar("");
            ani_sexoComboBox.DisplayMember = "sex_descriçao";
            ani_sexoComboBox.ValueMember = "sex_id";

            //cb especie
            EspecieBLL ebll = new EspecieBLL(conexao);
            ani_especieComboBox.DataSource = ebll.Pesquisar("");
            ani_especieComboBox.DisplayMember = "esp_descriçao";
            ani_especieComboBox.ValueMember = "esp_id";

            //cb raça
            RaçaBLL rbll = new RaçaBLL(conexao);
            ani_raçaComboBox.DataSource = rbll.Pesquisar("");
            ani_raçaComboBox.DisplayMember = "raç_descriçao";
            ani_raçaComboBox.ValueMember = "raç_id";

            //cb status
            STAnimalBLL stabll = new STAnimalBLL(conexao);
            ani_statusComboBox.DataSource = stabll.Pesquisar("");
            ani_statusComboBox.DisplayMember = "sta_descriçao";
            ani_statusComboBox.ValueMember = "sta_id";

            this.LimpaTela();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            ani_cadastroDateTimePicker.Format = DateTimePickerFormat.Custom;
            ani_cadastroDateTimePicker.CustomFormat = "MMMM dd, yyyy - dddd";
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
                    AnimalBLL bll = new AnimalBLL(conexao);

                    bll.Excluir(Convert.ToInt32(ani_idTextBox.Text));
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
                AnimalDTO ani = new AnimalDTO();
                ani.Ani_nome = ani_nomeTextBox.Text;
                ani.Ani_sexo = Convert.ToInt32(ani_sexoComboBox.SelectedValue);
                ani.Ani_especie = Convert.ToInt32(ani_especieComboBox.SelectedValue);
                ani.Ani_raça = Convert.ToInt32(ani_raçaComboBox.SelectedValue);
                ani.Ani_peso = ani_pesoTextBox.Text;
                ani.Ani_idade = ani_idadeTextBox.Text;
                ani.Ani_cliente = Convert.ToInt32(ani_clienteTextBox.Text);
                ani.Ani_cadastro = ani_cadastroDateTimePicker.Value.Date;
                ani.Ani_status = Convert.ToInt32(ani_statusComboBox.SelectedValue);

                //obj para gravar dados no bd
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AnimalBLL bll = new AnimalBLL(conexao);


                if (this.operacao == "inserir") /// alterar salvar para inserir
                {

                    bll.Incluir(ani);

                    MessageBox.Show("Cadastrado com Sucesso: Código: " + ani.Ani_id.ToString());
                    
                }
                else
                {
                    ani.Ani_id = Convert.ToInt32(ani_idTextBox.Text);
                    bll.Alterar(ani);
                    MessageBox.Show("Cadastrado Alterado com Sucesso: Código: " + ani.Ani_id.ToString());

                }
                this.LimpaTela();
                this.alterarBotoes(1);

            } //try

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
            

            // ---------------CONFIG BOTOES -------------------------
            //minimizar
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //encerrar form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // abre o form dentro do form
            form_ConsAnimal Form_Cad = new form_ConsAnimal();
            Form_Cad.ShowInTaskbar = false;
            Form_Cad.StartPosition = FormStartPosition.CenterParent;
            Form_Cad.ShowDialog(ActiveForm);
            
            if (Form_Cad.codigo != 0)
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AnimalBLL bll = new AnimalBLL(conexao);
                AnimalDTO ani = bll.CarregaAnimalDTO(Form_Cad.codigo);
                ani_idTextBox.Text = ani.Ani_id.ToString(); // é isso mesmo aula 16
                ani_nomeTextBox.Text = ani.Ani_nome;
                ani_sexoComboBox.SelectedValue = ani.Ani_sexo;
                ani_especieComboBox.SelectedValue = ani.Ani_especie;
                ani_raçaComboBox.SelectedValue = ani.Ani_raça;
                ani_pesoTextBox.Text = ani.Ani_peso;
                ani_idadeTextBox.Text = ani.Ani_idade;
                ani_clienteTextBox.Text = ani.Ani_cliente.ToString();
                ani_cadastroDateTimePicker.Value = ani.Ani_cadastro;

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

        private void btnPesquisarClientee_Click(object sender, EventArgs e)
        {
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
                    ani_clienteTextBox.Text = cli.Cli_id.ToString();
                    ani_clienteNomeTextBox.Text = cli.Cli_nome.ToString();
                }
                else
                {
                    this.LimpaTela();
                    this.alterarBotoes(1);
                }

                //encerra form
                Form_Cad.Dispose();
            }
        }
    }// class

}// namespace
