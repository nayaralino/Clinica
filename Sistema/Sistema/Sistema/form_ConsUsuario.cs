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
    public partial class form_ConsUsuario : Form
    {
        public int codigo = 0;

        public form_ConsUsuario()
        {
            InitializeComponent();
        }

        private void form_ConsUsuario_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            UsuarioBLL bll = new UsuarioBLL(conexao);
            dgv_usr.DataSource = bll.PesquisarTodos();

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_usr.DefaultCellStyle.Font = new Font("Verdana", 11);
            this.dgv_usr.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_usr.DefaultCellStyle.BackColor = Color.White;

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbFiltrarUsuario.Text == "Pesquisar por Nome")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                UsuarioBLL bll = new UsuarioBLL(conexao);
                dgv_usr.DataSource = bll.PesquisarNome(txtValor.Text);
            }

            if (cbFiltrarUsuario.Text == "Pesquisar Todos")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                UsuarioBLL bll = new UsuarioBLL(conexao);
                dgv_usr.DataSource = bll.PesquisarTodos();
            }

            if (cbFiltrarUsuario.Text == "Pesquisar por CPF")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                UsuarioBLL bll = new UsuarioBLL(conexao);
                dgv_usr.DataSource = bll.PesquisarCPF(txtValor.Text);
            }
        }

        private void dgv_usr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_usr.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
