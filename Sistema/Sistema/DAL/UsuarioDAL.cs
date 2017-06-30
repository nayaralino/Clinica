using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// revisão 29/10

namespace DAL
{
    public class UsuarioDAL
    {
            
    private ConexaoDAL conexao;

        public UsuarioDAL(ConexaoDAL usrDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = usrDalCon;
        }

        public void Incluir(UsuarioDTO usrDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbUsuario(usr_nome, usr_cpf, usr_telefone, usr_celular, usr_logradouro, usr_numero, usr_complemento, usr_bairro, usr_cidade, usr_estado, usr_cargo, usr_usuario, usr_senha, usr_confirmarSenha, usr_email) values (@usr_nome, @usr_cpf, @usr_telefone, @usr_celular, @usr_logradouro, @usr_numero, @usr_complemento, @usr_bairro, @usr_cidade, @usr_estado, @usr_cargo, @usr_usuario, @usr_senha, @usr_confirmarSenha, @usr_email);select @@identity;";
                cmd.Parameters.AddWithValue("@usr_nome", usrDalCrud.Usr_nome);
                cmd.Parameters.AddWithValue("@usr_cpf", usrDalCrud.Usr_cpf);
                cmd.Parameters.AddWithValue("@usr_telefone", usrDalCrud.Usr_telefone);
                cmd.Parameters.AddWithValue("@usr_celular", usrDalCrud.Usr_celular);
                cmd.Parameters.AddWithValue("@usr_logradouro", usrDalCrud.Usr_logradouro);
                cmd.Parameters.AddWithValue("@usr_numero", usrDalCrud.Usr_numero);
                cmd.Parameters.AddWithValue("@usr_complemento", usrDalCrud.Usr_complemento);
                cmd.Parameters.AddWithValue("@usr_bairro", usrDalCrud.Usr_bairro);
                cmd.Parameters.AddWithValue("@usr_cidade", usrDalCrud.Usr_cidade);
                cmd.Parameters.AddWithValue("@usr_estado", usrDalCrud.Usr_estado);
                cmd.Parameters.AddWithValue("@usr_cargo", usrDalCrud.Usr_cargo);
                cmd.Parameters.AddWithValue("@usr_usuario", usrDalCrud.Usr_usuario);
                cmd.Parameters.AddWithValue("@usr_senha", usrDalCrud.Usr_senha);
                cmd.Parameters.AddWithValue("@usr_confirmarSenha", usrDalCrud.Usr_confirmarSenha);
                cmd.Parameters.AddWithValue("@usr_email", usrDalCrud.Usr_email);
                                
                conexao.Conectar();
                usrDalCrud.Usr_id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }//incluir

        public void Alterar(UsuarioDTO usrDalCrud)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbUsuario set usr_nome = @usr_nome, usr_cpf = @usr_cpf, "
                    + "usr_telefone = @usr_telefone, usr_celular = @usr_celular, usr_logradouro = @usr_logradouro, "
                    + "usr_numero = @usr_numero, usr_complemento = @usr_complemento, usr_bairro = @usr_bairro, "
                    + "usr_cidade = @usr_cidade, usr_estado = @usr_estado, usr_cargo = @usr_cargo, usr_usuario = @usr_usuario, "
                    + "usr_senha = @usr_senha, usr_confirmarSenha = @usr_confirmarSenha, usr_email = @usr_email where usr_id = @usr_id;";

                cmd.Parameters.AddWithValue("@usr_id", usrDalCrud.Usr_id);
                cmd.Parameters.AddWithValue("@usr_nome", usrDalCrud.Usr_nome);
                cmd.Parameters.AddWithValue("@usr_cpf", usrDalCrud.Usr_cpf);
                cmd.Parameters.AddWithValue("@usr_telefone", usrDalCrud.Usr_telefone);
                cmd.Parameters.AddWithValue("@usr_celular", usrDalCrud.Usr_celular);
                cmd.Parameters.AddWithValue("@usr_logradouro", usrDalCrud.Usr_logradouro);
                cmd.Parameters.AddWithValue("@usr_numero", usrDalCrud.Usr_numero);
                cmd.Parameters.AddWithValue("@usr_complemento", usrDalCrud.Usr_complemento);
                cmd.Parameters.AddWithValue("@usr_bairro", usrDalCrud.Usr_bairro);
                cmd.Parameters.AddWithValue("@usr_cidade", usrDalCrud.Usr_cidade);
                cmd.Parameters.AddWithValue("@usr_estado", usrDalCrud.Usr_estado);
                cmd.Parameters.AddWithValue("@usr_cargo", usrDalCrud.Usr_cargo);
                cmd.Parameters.AddWithValue("@usr_usuario", usrDalCrud.Usr_usuario);
                cmd.Parameters.AddWithValue("@usr_senha", usrDalCrud.Usr_senha);
                cmd.Parameters.AddWithValue("@usr_confirmarSenha", usrDalCrud.Usr_confirmarSenha);
                cmd.Parameters.AddWithValue("@usr_email", usrDalCrud.Usr_email);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

        }//alterar

        public void Excluir(int usr_id) //tipo + o campo do banco
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "delete from tbUsuario where usr_id = @usr_id;";
                cmd.Parameters.AddWithValue("@usr_id", usr_id);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }//excluir

        public DataTable PesquisarNome(String usr_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbUsuario where usr_nome like '%" + usr_nome + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

     /*   public DataTable PesquisarNome(String cli_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cli_id, c.cli_nome, c.cli_cpf, c.cli_telefone, c.cli_celular, c.cli_email, c.cli_logradouro, c.cli_numero, c.cli_bairro, cc.cid_cidade, ee.est_estado from tbCliente AS c inner join tbCidade AS cc  on cc.cid_id = c.cli_cidade inner join tbEstado AS ee on ee.est_id = c.cli_estado WHERE cli_nome like '%" + cli_nome + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar
        /*/
        public DataTable PesquisarTodos() //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbUsuario", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarCPF(String usr_cpf) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbUsuario WHERE usr_cpf like '%" + usr_cpf + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar


        public UsuarioDTO CarregaUsuarioDTO(int usr_id) //tipo + o campo do banco
        {
            UsuarioDTO usr = new UsuarioDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbUsuario where usr_id = @usr_id;";
            cmd.Parameters.AddWithValue("@usr_id", usr_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                usr.Usr_id = Convert.ToInt32(registro["Usr_id"]);
                usr.Usr_nome = Convert.ToString(registro["usr_nome"]);
                usr.Usr_cpf = Convert.ToString(registro["usr_cpf"]);
                usr.Usr_telefone = Convert.ToString(registro["usr_telefone"]);
                usr.Usr_celular = Convert.ToString(registro["usr_celular"]);
                usr.Usr_logradouro = Convert.ToString(registro["usr_logradouro"]);
                usr.Usr_numero = Convert.ToString(registro["usr_numero"]);
                usr.Usr_complemento = Convert.ToString(registro["usr_complemento"]);
                usr.Usr_bairro = Convert.ToString(registro["usr_bairro"]);
                usr.Usr_cidade = Convert.ToInt32(registro["usr_cidade"]);
                usr.Usr_estado = Convert.ToInt32(registro["usr_estado"]);
                usr.Usr_cargo = Convert.ToInt32(registro["usr_cargo"]);
                usr.Usr_usuario = Convert.ToString(registro["usr_usuario"]);
                usr.Usr_senha = Convert.ToString(registro["usr_senha"]);
                usr.Usr_confirmarSenha = Convert.ToString(registro["usr_confirmarSenha"]);
                usr.Usr_email = Convert.ToString(registro["usr_email"]);
                
            }
            conexao.Desconectar();
            return usr;
        }//carrega

      
    }//class

}//namespace