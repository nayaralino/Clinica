using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema
{
    public partial class form_Menu : Form
    {
        public form_Menu()
        {
            InitializeComponent();
        }

        // VARIAVEIS + CONF PARA MOVER O FORM NA TELA
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void pnDados_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pnDados_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 50;
                mouseY = MousePosition.Y - 50;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pnDados_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_Menu_Load(object sender, EventArgs e)
        {            
            pnSecundario.Hide();                                                
        }
                
        // EFEITO DE SLIDE DO MENU PRINCIPAL
        private void btnSlidePrincipal_Click(object sender, EventArgs e)
        {
            if (pnPrincipal.Height == 780 & pnPrincipal.Width == 170)
            {
                pnPrincipal.Height = 780;
                pnPrincipal.Width = 37;

                btnSlidePrincipal.Left = 3;
            }
            else
            {
                pnPrincipal.Height = 780;
                pnPrincipal.Width = 170;

                btnSlidePrincipal.Left = 3;

            }
        }

        private void btnCadastroPrincipal_Click(object sender, EventArgs e)
        {
            pnPrincipal.Hide();
            pnSecundario.Show();
        }

        private void btnCadastroSecundario_Click(object sender, EventArgs e)
        {
            pnPrincipal.Show();
            pnSecundario.Hide();
        }

        private void btnSlideSecundario_Click(object sender, EventArgs e)
        {
            pnSecundario.Hide();
            pnPrincipal.Show();

            if (pnPrincipal.Height == 780 & pnPrincipal.Width == 170)
            {
                pnPrincipal.Height = 780;
                pnPrincipal.Width = 37;

                btnSlidePrincipal.Left = 3;
            }
            else
            {
                pnPrincipal.Height = 780;
                pnPrincipal.Width = 170;

                btnSlidePrincipal.Left = 3;

            }
        }

        // BOTÕES MINIMIZAR E FECHAR
        private void picFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // BOTÕES DE CONSULTA - MENU PRINCIPAL
        private void btnConsCliente_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_ConsCliente Form_Cad = new form_ConsCliente();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
             //   ct.BackColor = Color.Empty;
            }

        }

        private void btnConsAnimal_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_ConsAnimal Form_Cad = new form_ConsAnimal();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnConsMedico_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_ConsMedico Form_Cad = new form_ConsMedico();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_Consulta Form_Cad = new form_Consulta();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_Agenda Form_Cad = new form_Agenda();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form_CadAtendimento Form_Cad = new Form_CadAtendimento();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_Relatorios Form_Cad = new form_Relatorios();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_Dashboards Form_Cad = new form_Dashboards();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        // BOTÕES DE CADASTRO - MENU SECUNDARIO
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadCliente Form_Cad = new form_CadCliente();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadAnimal_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadAnimal Form_Cad = new form_CadAnimal();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadEspecie_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadAnimal_CadEspecie Form_Cad = new form_CadAnimal_CadEspecie();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadRaca_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadAnimal_CadRaça Form_Cad = new form_CadAnimal_CadRaça();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadVacina_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadVacina Form_Cad = new form_CadVacina();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadPatologia_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadExame_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            //form_CadExame Form_Cad = new form_CadExame();
      //      Form_Cad.MdiParent = this;
       //     Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadMedico_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadMedico Form_Cad = new form_CadMedico();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadEspecialidade_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadMedico_CadEspecialidade Form_Cad = new form_CadMedico_CadEspecialidade();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadUsuario Form_Cad = new form_CadUsuario();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnSecundario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadAdicionais_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            form_CadAdicional Form_Cad = new form_CadAdicional();
            Form_Cad.MdiParent = this;
            Form_Cad.Show();

            foreach (Control ct in this.Controls)
            {
                if (ct.GetType().Name == "MdiClient")
                    ct.BackColor = Color.FromName("WhiteSmoke");
                //   ct.BackColor = Color.Empty;
            }

        }

    }//class

}//namespace

