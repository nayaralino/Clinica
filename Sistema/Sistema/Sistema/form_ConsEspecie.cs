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
    public partial class form_ConsEspecie : Form
    {
        public int codigo = 0;

        public form_ConsEspecie()
        {
            InitializeComponent();
        }

        private void tbEspecieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbEspecieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSistemaDataSet);

        }

        private void form_ConsEspecie_Load(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            EspecieBLL bll = new EspecieBLL(conexao);
            dgv_esp.DataSource = bll.Pesquisar(txtValor.Text);

            //------CONFIG DO PESQUISAR ------//
            btnPesquisar_Click(sender, e);
            
            //------  DEFINE DGV COR TEXTO E FUNDO----- //
            this.dgv_esp.DefaultCellStyle.Font = new Font("Verdana", 11);
            this.dgv_esp.DefaultCellStyle.ForeColor = Color.Black;
            this.dgv_esp.DefaultCellStyle.BackColor = Color.White;
        }
        //------CONFIG DE EXIBIÇÃO DO DGV ------//
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDAL conexao = new ConexaoDAL(DadosConexaoDAL.StringDeConexão);
            EspecieBLL bll = new EspecieBLL(conexao);
            dgv_esp.DataSource = bll.Pesquisar(txtValor.Text);
        }
        // ------- COPIA O CONTEUDO DO DGV E JOGA NO CADASTRO -----//
        private void dgv_esp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_esp.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        //minimizar
        private void pictureBox5_Click(object sender, EventArgs e)
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

