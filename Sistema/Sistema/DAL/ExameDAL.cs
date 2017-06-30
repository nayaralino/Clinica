using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 21/02
// Data de alteração 15/03 criei a nova estrutura

namespace DAL
{
    public class ExameDAL
    {
        private ConexaoDAL conexao;

        public ExameDAL(ConexaoDAL exaDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = exaDalCon;
        }

        public void Incluir(ExameDTO exaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into TBEXAME(exa_atendimento, exa_dtSolicitaçao, exa_dtResultado, exa_tipo, exa_laboratorio, exa_resultado) values (@exa_atendimento , @exa_dtSolicitaçao, @exa_dtResultado, @exa_tipo, @exa_laboratorio, @exa_resultado);select @@identity;";
            cmd.Parameters.AddWithValue("@exa_atendimento", exaDalCrud.Exame_atendimento);
            cmd.Parameters.AddWithValue("@exa_dtSolicitaçao", exaDalCrud.Exame_dtSolicitaçao);
            cmd.Parameters.AddWithValue("@exa_dtResultado", exaDalCrud.Exame_dtResultado);
            cmd.Parameters.AddWithValue("@exa_tipo", exaDalCrud.Exame_tipo);
            cmd.Parameters.AddWithValue("@exa_laboratorio", exaDalCrud.Exame_laboratorio);
            cmd.Parameters.AddWithValue("@exa_resultado", exaDalCrud.Exame_resultado);
            
            conexao.Conectar();

            exaDalCrud.Exame_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(ExameDTO exaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update TBEXAME set exa_atendimento = @exa_atendimento, exa_atendimento = @exa_atendimento, exa_dtSolicitaçao = @exa_dtSolicitaçao, exa_dtResultado = @exa_dtResultado, exa_tipo = @exa_tipo, exa_laboratorio = @exa_laboratorio, exa_resultado = @exa_resultado where exa_id = @exa_id;";

            cmd.Parameters.AddWithValue("@exa_id", exaDalCrud.Exame_id);
            cmd.Parameters.AddWithValue("@exa_atendimento", exaDalCrud.Exame_atendimento);
            cmd.Parameters.AddWithValue("@exa_dtSolicitaçao", exaDalCrud.Exame_dtSolicitaçao);
            cmd.Parameters.AddWithValue("@exa_dtResultado", exaDalCrud.Exame_dtResultado);
            cmd.Parameters.AddWithValue("@exa_tipo", exaDalCrud.Exame_tipo);
            cmd.Parameters.AddWithValue("@exa_laboratorio", exaDalCrud.Exame_laboratorio);
            cmd.Parameters.AddWithValue("@exa_resultado", exaDalCrud.Exame_resultado);
            
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int exa_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from TBEXAME where exa_id = @exa_id;";
            cmd.Parameters.AddWithValue("@exa_id", exa_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(string exa_tipo) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBEXAME where exa_tipo like '%" + exa_tipo + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public ExameDTO CarregaExameDTO(int exa_id) //tipo + o campo do banco
        {
            ExameDTO exa = new ExameDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from TBEXAME where exa_id = @exa_id;";
            cmd.Parameters.AddWithValue("@exa_id", exa_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                exa.Exame_id = Convert.ToInt32(registro["exa_id"]);
                exa.Exame_atendimento = Convert.ToString(registro["exa_atendimento"]);
                exa.Exame_dtSolicitaçao = Convert.ToString(registro["exa_dtSolicitaçao"]);
                exa.Exame_dtResultado = Convert.ToString(registro["exa_dtResultado"]);
                exa.Exame_tipo = Convert.ToString(registro["exa_tipo"]);
                exa.Exame_laboratorio = Convert.ToString(registro["exa_laboratorio"]);
                exa.Exame_resultado = Convert.ToString(registro["exa_resultado"]);
                
            }
            conexao.Desconectar();
            return exa;
        }//carrega
                
    }//class

}//namespace

