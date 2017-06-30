using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; //Classe Responsável pela Conexão com o SQL Server

// Data de alteração 24-02

namespace Sistema
{
    public partial class formLogin : Form
    {        
        public formLogin()
        {
            InitializeComponent();
        }
               
        
        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        // exit
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String de Conexão com o Banco
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbSistemaConnectionString); //dbSistema nome do banco ;)

            try
            {
                //Verificar ser os campos estão preenchidos
                if ((txtUsuario.Text != "") && (txtSenha.Text != ""))
                {
                    //Responsavel pelo Comando Sql
                    SqlCommand comm = new SqlCommand("Select * From dbo.tbUsuario Where usr_usuario = @usr_usuario and " +
                    "usr_senha = @usr_senha", conn);

                    //Parametizar os codigos
                    comm.Parameters.Add("@usr_usuario",
                    SqlDbType.VarChar).Value = txtUsuario.Text;
                    comm.Parameters.Add("@usr_senha", SqlDbType.VarChar).Value
                    = txtSenha.Text;

                    //Abre a conexão
                    conn.Open();
                    SqlDataReader reader = null;

                    //lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    //Se tiver coisa pra lê faça:
                    if (reader.Read())
                    {

                        //Declara a variavel que recebe o formulario  formTelaPrinciapal
                        form_Menu p = new form_Menu();

                        //Esconde o formulario Tela de Login
                        this.Hide();

                        //Mostrar o formulario frmTelaPrinciapl
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas",
                        "Aviso de Segurança",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os Campos são obrigatórios",
                    "Aviso de Segurança",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Gerar a exceção
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Finalizar tarefa
                conn.Close();
            }
        }
    }// class

}// namespace
