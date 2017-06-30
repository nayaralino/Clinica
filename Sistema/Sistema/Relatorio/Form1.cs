using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRel_Click(object sender, EventArgs e)
        {
            form_RelClientes form = new form_RelClientes();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
