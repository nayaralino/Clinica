using System;
using System.Data.SqlClient;
using DTO;
using System.Data;
using DAL;

// Data de criação 21/10
// Data de modificação 14/02


namespace DAL
{
    public class ClienteDAL
    {
        private ConexaoDAL conexao;

        public ClienteDAL(ConexaoDAL cliDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = cliDalCon;
        }

        public void Incluir(ClienteDTO cliDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbCliente(cli_nome, cli_cpf, cli_telefone, cli_email, cli_celular, cli_logradouro, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_estado, cli_cadastro) values (@cli_nome, @cli_cpf, @cli_telefone, @cli_celular, @cli_email, @cli_logradouro, @cli_numero, @cli_complemento, @cli_bairro, @cli_cidade, @cli_estado, @cli_cadastro);select @@identity;";
                cmd.Parameters.AddWithValue("@cli_nome", cliDalCrud.Cli_nome);
                cmd.Parameters.AddWithValue("@cli_cpf", cliDalCrud.Cli_cpf);
                cmd.Parameters.AddWithValue("@cli_telefone", cliDalCrud.Cli_telefone);
                cmd.Parameters.AddWithValue("@cli_celular", cliDalCrud.Cli_celular);
                cmd.Parameters.AddWithValue("@cli_email", cliDalCrud.Cli_email);
                cmd.Parameters.AddWithValue("@cli_logradouro", cliDalCrud.Cli_logradouro);
                cmd.Parameters.AddWithValue("@cli_numero", cliDalCrud.Cli_numero);
                cmd.Parameters.AddWithValue("@cli_complemento", cliDalCrud.Cli_complemento);
                cmd.Parameters.AddWithValue("@cli_bairro", cliDalCrud.Cli_bairro);
                cmd.Parameters.AddWithValue("@cli_cidade", cliDalCrud.Cli_cidade);
                cmd.Parameters.AddWithValue("@cli_estado", cliDalCrud.Cli_estado);
                cmd.Parameters.AddWithValue("@cli_cadastro", cliDalCrud.Cli_cadastro);

                conexao.Conectar();

                cliDalCrud.Cli_id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Alterar(ClienteDTO cliDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbCliente set cli_nome = @cli_nome, cli_cpf = @cli_cpf, cli_telefone = @cli_telefone, cli_celular = @cli_celular, cli_email = @cli_email, cli_logradouro = @cli_logradouro, cli_numero = @cli_numero, cli_complemento = @cli_complemento, cli_bairro = @cli_bairro, cli_cidade = @cli_cidade, cli_estado = @cli_estado, cli_cadastro = @cli_cadastro where cli_id = @cli_id;";
                cmd.Parameters.AddWithValue("@cli_id", cliDalCrud.Cli_id);
                cmd.Parameters.AddWithValue("@cli_nome", cliDalCrud.Cli_nome);
                cmd.Parameters.AddWithValue("@cli_cpf", cliDalCrud.Cli_cpf);
                cmd.Parameters.AddWithValue("@cli_telefone", cliDalCrud.Cli_telefone);
                cmd.Parameters.AddWithValue("@cli_celular", cliDalCrud.Cli_celular);
                cmd.Parameters.AddWithValue("@cli_email", cliDalCrud.Cli_email);
                cmd.Parameters.AddWithValue("@cli_logradouro", cliDalCrud.Cli_logradouro);
                cmd.Parameters.AddWithValue("@cli_numero", cliDalCrud.Cli_numero);
                cmd.Parameters.AddWithValue("@cli_complemento", cliDalCrud.Cli_complemento);
                cmd.Parameters.AddWithValue("@cli_bairro", cliDalCrud.Cli_bairro);
                cmd.Parameters.AddWithValue("@cli_cidade", cliDalCrud.Cli_cidade);
                cmd.Parameters.AddWithValue("@cli_estado", cliDalCrud.Cli_estado);
                cmd.Parameters.AddWithValue("@cli_cadastro", cliDalCrud.Cli_cadastro);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum

                cliDalCrud.Cli_id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Excluir(int cli_id) //tipo + o campo do banco
        {
            try
            { 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbCliente where cli_id = @cli_id;";
            cmd.Parameters.AddWithValue("@cli_id", cli_id);
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

        public DataTable PesquisarNome(String cli_nome) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cli_id, c.cli_nome, c.cli_cpf, c.cli_telefone, c.cli_celular, c.cli_email, c.cli_logradouro, c.cli_numero, c.cli_complemento, c.cli_bairro, cc.cid_descriçao, ee.est_descriçao, c.cli_cadastro from tbCliente AS c inner join tbCidade AS cc  on cc.cid_id = c.cli_cidade inner join tbEstado AS ee on ee.est_id = c.cli_estado WHERE cli_nome like '%" + cli_nome + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarTodos() //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cli_id, c.cli_nome, c.cli_cpf, c.cli_telefone, c.cli_celular, c.cli_email, c.cli_logradouro, c.cli_numero, c.cli_complemento, c.cli_bairro, cc.cid_descriçao, ee.est_descriçao, c.cli_cadastro from tbCliente AS c inner join tbCidade AS cc  on cc.cid_id = c.cli_cidade inner join tbEstado AS ee on ee.est_id = c.cli_estado ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public DataTable PesquisarCPF(String cli_cpf) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.cli_id, c.cli_nome, c.cli_cpf, c.cli_telefone, c.cli_celular, c.cli_email, c.cli_logradouro, c.cli_numero, c.cli_complemento, c.cli_bairro, cc.cid_descriçao, ee.est_descriçao, c.cli_cadastro from tbCliente AS c inner join tbCidade AS cc  on cc.cid_id = c.cli_cidade inner join tbEstado AS ee on ee.est_id = c.cli_estado WHERE cli_cpf like '%" + cli_cpf + "%' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public ClienteDTO CarregaClienteDTO(int cli_id) //tipo + o campo do banco
        {
            ClienteDTO cli = new ClienteDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbCliente where cli_id = @cli_id;";
            cmd.Parameters.AddWithValue("@cli_id", cli_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cli.Cli_id = Convert.ToInt32(registro["cli_id"]);
                cli.Cli_nome = Convert.ToString(registro["cli_nome"]);

                cli.Cli_cpf = Convert.ToString(registro["cli_cpf"]);
                cli.Cli_telefone = Convert.ToString(registro["cli_telefone"]);
                cli.Cli_celular = Convert.ToString(registro["cli_celular"]);
                cli.Cli_email = Convert.ToString(registro["cli_email"]);
                cli.Cli_logradouro = Convert.ToString(registro["cli_logradouro"]);
                cli.Cli_numero = Convert.ToString(registro["cli_numero"]);
                cli.Cli_complemento = Convert.ToString(registro["cli_complemento"]);
                cli.Cli_bairro = Convert.ToString(registro["cli_bairro"]);
                cli.Cli_cidade = Convert.ToInt32(registro["cli_cidade"]);
                cli.Cli_estado = Convert.ToInt32(registro["cli_estado"]);
                cli.Cli_cadastro = Convert.ToDateTime(registro["cli_cadastro"]);

            }
            conexao.Desconectar();
            return cli;
        }//carrega_cliente

              
    }//class

}//namespace