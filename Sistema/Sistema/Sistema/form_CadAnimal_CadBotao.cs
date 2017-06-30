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
    public partial class form_CadAnimal_CadBotao : Form
    {
        public form_CadAnimal_CadBotao()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.Close();
            form_CadAnimal f = new form_CadAnimal();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
