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
    public partial class form_ConsCliente : Form
    {
        public int codigo = 0;

        public form_ConsCliente()
        {
            InitializeComponent();
        }

        private void form_ConsCliente_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            ClienteBLL bll = new ClienteBLL(conexao);
            dgv_cli.DataSource = bll.PesquisarTodos();

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_cli.DefaultCellStyle.Font = new Font("Verdana", 10);
            this.dgv_cli.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_cli.DefaultCellStyle.BackColor = Color.White;

            
            
            //------  DEFINE DGV CABEÇALHO----- 
            //Altera o cabeçalho da coluna
            dgv_cli.Columns[0].HeaderText = "Código";
            //Altera a largura da coluna
         //   dgv_cli.Columns[0].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[1].HeaderText = "Nome";
            //Altera a largura da coluna
       //     dgv_cli.Columns[1].Width = 130;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[2].HeaderText = "CPF";
            //Altera a largura da coluna
     //       dgv_cli.Columns[2].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[3].HeaderText = "Telefone";
            //Altera a largura da coluna
      //      dgv_cli.Columns[3].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[4].HeaderText = "Celular";
            //Altera a largura da coluna
      //      dgv_cli.Columns[4].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[5].HeaderText = "Email";
            //Altera a largura da coluna
      //      dgv_cli.Columns[5].Width = 130;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[6].HeaderText = "Logradouro";
            //Altera a largura da coluna
     //       dgv_cli.Columns[6].Width = 130;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[7].HeaderText = "Numero";
            //Altera a largura da coluna
     //       dgv_cli.Columns[7].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[8].HeaderText = "Complemento";
            //Altera a largura da coluna
     //       dgv_cli.Columns[8].Width = 80;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[9].HeaderText = "Bairro";
            //Altera a largura da coluna
     //       dgv_cli.Columns[9].Width = 100;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[10].HeaderText = "Cidade";
            //Altera a largura da coluna
    //        dgv_cli.Columns[10].Width = 80;

            //Altera o cabeçalho da coluna
            dgv_cli.Columns[11].HeaderText = "Estado";
            //Altera a largura da coluna
    //        dgv_cli.Columns[11].Width = 50;
              
        }

        //------CONFIG DE EXIBIÇÃO DO DGV ------//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbFiltrar.Text == "Pesquisar por Nome")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ClienteBLL bll = new ClienteBLL(conexao);
                dgv_cli.DataSource = bll.PesquisarNome(txtValor.Text);
            }

            if (cbFiltrar.Text == "Pesquisar Todos")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ClienteBLL bll = new ClienteBLL(conexao);
                dgv_cli.DataSource = bll.PesquisarTodos();
            }

            if (cbFiltrar.Text == "Pesquisar por CPF")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                ClienteBLL bll = new ClienteBLL(conexao);
                dgv_cli.DataSource = bll.PesquisarCPF(txtValor.Text);
            }

        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_cli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_cli.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimirCliente_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;
            form_RelCliente Form_Cad = new form_RelCliente();
           // Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }
        }

        private void dgv_cli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
