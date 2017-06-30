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
    public partial class form_ConsTipoProtocolo : Form
    {
        public int codigo = 0;
        public form_ConsTipoProtocolo()
        {
            InitializeComponent();
        }

        private void form_ConsTipoProtocolo_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            TipoProtocoloBLL bll = new TipoProtocoloBLL(conexao);
            dgv_prot.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            TipoProtocoloBLL bll = new TipoProtocoloBLL(conexao);
            dgv_prot.DataSource = bll.Pesquisar(txtValor.Text);
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_prot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_prot.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

       
    }
}
