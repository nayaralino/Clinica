using BLL;
using DAL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema
{
    public partial class form_ConsAnimal : Form
    {
        public int codigo = 0;

        public form_ConsAnimal()
        {
            InitializeComponent();
        }        

        private void form_ConsAnimal_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            AnimalBLL bll = new AnimalBLL(conexao);
            dgv_ani.DataSource = bll.PesquisarTodosAnimal();

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);

            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_ani.DefaultCellStyle.Font = new Font("Verdana", 10);
            this.dgv_ani.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_ani.DefaultCellStyle.BackColor = Color.White;
            
                     
            //------  DEFINE DGV CABEÇALHO----- //
            //Altera o cabeçalho da coluna
            dgv_ani.Columns[0].HeaderText = "ID";
            //Altera a largura da coluna
        //    dgv_ani.Columns[0].Width = 50;
                                    
            //Altera o cabeçalho da coluna
            dgv_ani.Columns[1].HeaderText = "Cliente";
            //Altera a largura da coluna
         //   dgv_ani.Columns[1].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_ani.Columns[2].HeaderText = "Animal";
            //Altera a largura da coluna
        //    dgv_ani.Columns[2].Width = 70;

            //Altera o cabeçalho da coluna
            dgv_ani.Columns[3].HeaderText = "Sexo";
            //Altera a largura da coluna
         //   dgv_ani.Columns[3].Width = 50;

            //Altera o cabeçalho da coluna
            dgv_ani.Columns[4].HeaderText = "Espécie";
            //Altera a largura da coluna
         //   dgv_ani.Columns[4].Width = 50;
                        
            //Altera o cabeçalho da coluna
            dgv_ani.Columns[5].HeaderText = "Raça";
            //Altera a largura da coluna
          //  dgv_ani.Columns[5].Width = 20;
            
        }

        //------CONFIG DE EXIBIÇÃO DO DGV ------//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbFiltrarAnimal.Text == "Pesquisar por Nome do Animal")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AnimalBLL bll = new AnimalBLL(conexao);
                dgv_ani.DataSource = bll.PesquisarNomeAnimal(txtValor.Text);
            }

            if (cbFiltrarAnimal.Text == "Pesquisar Todos Animais")
            {

                ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
                AnimalBLL bll = new AnimalBLL(conexao);
                dgv_ani.DataSource = bll.PesquisarTodosAnimal();
            }
        }

        // ------- COPIA O CONTEUDO DO DGV E JOGA NO CADASTRO -----//
        private void dgv_ani_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_ani.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //minimizar
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        //encerrar form

    }

}
