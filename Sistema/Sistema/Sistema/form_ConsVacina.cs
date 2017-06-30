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
    public partial class form_ConsVacina : Form
    {
        public int codigo = 0;
        public form_ConsVacina()
        {
            InitializeComponent();
        }


        private void form_ConsVacina_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            VacinaBLL bll = new VacinaBLL(conexao);
            dgv_vac.DataSource = bll.Pesquisar(txtValor.Text);

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_vac.DefaultCellStyle.Font = new Font("Verdana", 11);
            this.dgv_vac.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_vac.DefaultCellStyle.BackColor = Color.White;

        }

        private void dgv_vac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            VacinaBLL bll = new VacinaBLL(conexao);
            dgv_vac.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_vac_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_vac.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void piccMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void piccFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
