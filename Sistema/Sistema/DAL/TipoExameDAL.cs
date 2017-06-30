using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 21/02
// Data de alteração 15/03 criei a nova estrutura

namespace DAL
{
    public class TipoExameDAL
    {
        private ConexaoDAL conexao;

        public TipoExameDAL(ConexaoDAL tpexaDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = tpexaDalCon;
        }

        public void Incluir(TipoExameDTO tpexaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbTPExame(tpe_descriçao) values (@tpe_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@tpe_descriçao", tpexaDalCrud.Tpe_descriçao);
            conexao.Conectar();

            tpexaDalCrud.Tpe_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(TipoExameDTO tpexaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbTPExame set tpe_descriçao = @tpe_descriçao where tpe_id = @tpe_id;";

            cmd.Parameters.AddWithValue("@tpe_id", tpexaDalCrud.Tpe_id);
            cmd.Parameters.AddWithValue("@tpe_descriçao", tpexaDalCrud.Tpe_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int tpe_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbTPExame where tpe_id = @tpe_id;";
            cmd.Parameters.AddWithValue("@tpe_id", tpe_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String tpe_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbTPExame where tpe_descriçao like '%" + tpe_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public TipoExameDTO CarregaTipoExameDTO(int tpe_id) //tipo + o campo do banco
        {
            TipoExameDTO tpexame = new TipoExameDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbTPExame where tpe_id = @tpe_id;";
            cmd.Parameters.AddWithValue("@tpe_id", tpe_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tpexame.Tpe_id = Convert.ToInt32(registro["tpe_id"]);
                tpexame.Tpe_descriçao = Convert.ToString(registro["tpe_descriçao"]);
            }
            conexao.Desconectar();
            return tpexame;
        }//carrega



    }//class

}//namespace

