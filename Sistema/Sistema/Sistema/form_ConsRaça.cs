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

namespace Sistema
{
    public partial class form_ConsRaça : Form
    {
        public int codigo = 0;

        public form_ConsRaça()
        {
            InitializeComponent();
        }

        private void form_ConsRaça_Load(object sender, EventArgs e)
        {

            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            RaçaBLL bll = new RaçaBLL(conexao);
            dgv_raça.DataSource = bll.Pesquisar(txtValor.Text);

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_raça.DefaultCellStyle.Font = new Font("Verdana", 11);
            this.dgv_raça.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_raça.DefaultCellStyle.BackColor = Color.White;

            //------  DEFINE DGV CABEÇALHO----- //
            //Altera o cabeçalho da coluna
            dgv_raça.Columns[0].HeaderText = "Código";
            //Altera a largura da coluna
            dgv_raça.Columns[0].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_raça.Columns[1].HeaderText = "Raça";
            //Altera a largura da coluna
            dgv_raça.Columns[1].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_raça.Columns[2].HeaderText = "Cód. Espécie";
            //Altera a largura da coluna
            dgv_raça.Columns[2].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_raça.Columns[3].HeaderText = "Espécie";
            //Altera a largura da coluna
            dgv_raça.Columns[3].Width = 100;

        }

        //------CONFIG DE EXIBIÇÃO DO DGV ------//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            RaçaBLL bll = new RaçaBLL(conexao);
            dgv_raça.DataSource = bll.Pesquisar(txtValor.Text);
        }

        // ------- COPIA O CONTEUDO DO DGV E JOGA NO CADASTRO -----//
        private void dgv_raça_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_raça.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        // ----------CONFIG DOS BOTOES -----------------------------//

        //minimizar
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //maximizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
     //       this.WindowState = FormWindowState.Maximized;
        }

        //encerrar form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//class

}// namespace
