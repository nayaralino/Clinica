using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

// Data de criação 11/02
// Data de alteração 11/02

namespace Sistema
{
    public partial class form_ConsMedico : Form
    {
        public int codigo = 0;

        public form_ConsMedico()
        {
            InitializeComponent();
        }


        private void form_ConsMedico_Load(object sender, EventArgs e)
        {
            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_med.DefaultCellStyle.Font = new Font("Verdana", 10);
            this.dgv_med.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_med.DefaultCellStyle.BackColor = Color.White;

            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            MedicoBLL bll = new MedicoBLL(conexao);
            dgv_med.DataSource = bll.Pesquisar(txtValor.Text);
            
            
            //------  DEFINE DGV CABEÇALHO----- // 
            //Altera o cabeçalho da coluna
            dgv_med.Columns[0].HeaderText = "Código";
            //Altera a largura da coluna
            dgv_med.Columns[0].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[1].HeaderText = "Nome";
            //Altera a largura da coluna
            dgv_med.Columns[1].Width = 150;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[2].HeaderText = "CRMV";
            //Altera a largura da coluna
            dgv_med.Columns[2].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[3].HeaderText = "Especialidade";
            //Altera a largura da coluna
            dgv_med.Columns[3].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[4].HeaderText = "Endereço";
            //Altera a largura da coluna
            dgv_med.Columns[4].Width = 130;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[5].HeaderText = "Numero";
            //Altera a largura da coluna
            dgv_med.Columns[5].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[6].HeaderText = "Complemento";
            //Altera a largura da coluna
            dgv_med.Columns[6].Width = 80;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[7].HeaderText = "Bairro";
            //Altera a largura da coluna
            dgv_med.Columns[7].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[8].HeaderText = "Cidade";
            //Altera a largura da coluna
            dgv_med.Columns[8].Width = 80;

            //Altera o cabeçalho da coluna
            dgv_med.Columns[9].HeaderText = "Estado";
            //Altera a largura da coluna
            dgv_med.Columns[9].Width = 80;

        }

        //------CONFIG DE EXIBIÇÃO DO DGV ------//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbFiltrarMedico.Text == "Pesquisar Todos")
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                MedicoBLL bll = new MedicoBLL(conexao);
                dgv_med.DataSource = bll.Pesquisar(txtValor.Text);
            }

            if (cbFiltrarMedico.Text == "Pesquisar por nome do Médico")
            {
                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                MedicoBLL bll = new MedicoBLL(conexao);
                dgv_med.DataSource = bll.Pesquisar(txtValor.Text);
            }

        }

        // ------- COPIA O CONTEUDO DO DGV E JOGA NO CADASTRO -----//
        private void dgv_med_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_med.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }


        // ----------CONFIG DOS BOTOES -----------------------------//
                               
        private void dgv_med_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_med.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_med_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}


