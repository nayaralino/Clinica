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
    public partial class form_ConsTipoExame : Form
    {
        public int codigo = 0;

        public form_ConsTipoExame()
        {
            InitializeComponent();
        }

        private void form_ConsTipoExame_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            TipoExameBLL bll = new TipoExameBLL(conexao);
            dgv_tipoe.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            TipoExameBLL bll = new TipoExameBLL(conexao);
            dgv_tipoe.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void dgv_tipoe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_tipoe.Rows[e.RowIndex].Cells[0].Value);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_tipoe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
