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
    public partial class form_Relatorios : Form
    {
        public form_Relatorios()
        {
            InitializeComponent();
        }

        private void form_Relatorios_Load(object sender, EventArgs e)
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
    }
}
