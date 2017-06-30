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
    public partial class form_CadMedico_CadEspecialidade : Form
    {
        public form_CadMedico_CadEspecialidade()
        {
            InitializeComponent();
        }

        private void form_CadMedico_CadEspecialidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbEspecialidade' table. You can move, or remove it, as needed.
          //  this.tbEspecialidadeTableAdapter.Fill(this.dbSistemaDataSet.tbEspecialidade);

        }

        private void tbEspecialidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbEspecialidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbSistemaDataSet);

        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
