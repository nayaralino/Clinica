using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;



namespace Sistema
{
    public partial class form_RelCliente : Form
    {
        public form_RelCliente()
        {
            InitializeComponent();
        }

        private void form_RelCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSistemaDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.dbSistemaDataSet.tbCliente);

            this.reportCliente.RefreshReport();
        }
    }
}
