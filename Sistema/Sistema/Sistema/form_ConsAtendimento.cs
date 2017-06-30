using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Data de criação 016/02
// Data de modificação 16/02


namespace Sistema
{
    public partial class form_ConsAtendimento : Form
    {
        public int codigo = 0;

        public form_ConsAtendimento()
        {
            InitializeComponent();
        }

        private void form_ConsAtendimento_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            AtendimentoBLL bll = new AtendimentoBLL(conexao);
            dgv_ate.DataSource = bll.PesquisarTodosAtendimentos();

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_ate.DefaultCellStyle.Font = new Font("Verdana", 11);
            this.dgv_ate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_ate.DefaultCellStyle.BackColor = Color.White;
            
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbFiltrarAtendimento.Text == "Pesquisar Todos")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                dgv_ate.DataSource = bll.PesquisarTodosAtendimentos();
            }

            if (cbFiltrarAtendimento.Text == "Pesquisar por Cliente")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AtendimentoBLL bll = new AtendimentoBLL(conexao);
                ClienteBLL cbll = new ClienteBLL(conexao);
              //  dgv_ate.DataSource = bll.PesquisarNomeCliente(cli_nome);
            }
            
        }
        
        private void dgv_ate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_ate.Rows[e.RowIndex].Cells[0].Value);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbFiltrarAtendimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
