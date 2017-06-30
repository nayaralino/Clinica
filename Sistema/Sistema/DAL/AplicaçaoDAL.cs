using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 17/03
// Data de alteração 17/03

namespace DAL
{ 
    public class AplicaçaoDAL
    {
        private ConexaoDAL conexao;

        public AplicaçaoDAL(ConexaoDAL apliDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = apliDalCon;
        }

        public void Incluir(AplicaçaoDTO apliDalCrud)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.Conexao,
                CommandText = "insert into tbAplicaçao(apl_descriçao) values (@apl_descriçao);select @@identity;"
            };
            cmd.Parameters.AddWithValue("@apl_descriçao", apliDalCrud.Apl_descriçao);
            conexao.Conectar();

            apliDalCrud.Apl_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(AplicaçaoDTO apliDalCrud)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.Conexao,
                CommandText = "update tbAplicaçao set apli_aplicaçao = @apl_descriçao where apl_id = @apl_id;"
            };
            cmd.Parameters.AddWithValue("@apl_id", apliDalCrud.Apl_id);
            cmd.Parameters.AddWithValue("@apl_descriçao", apliDalCrud.Apl_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int apl_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.Conexao,
                CommandText = "delete from tbAplicaçao where apli_id = @apl_id;"
            };
            cmd.Parameters.AddWithValue("@apl_id", apl_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String apl_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbAplicaçao where apl_descriçao like '%" + apl_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public AplicaçaoDTO CarregaAplicaçaoDTO(int apl_id) //tipo + o campo do banco
        {
            AplicaçaoDTO tpProtocolo = new AplicaçaoDTO();
            SqlCommand cmd = new SqlCommand()
            {
                Connection = conexao.Conexao,
                CommandText = "select * from tbAplicaçao where apl_id = @apl_id;"
            };
            cmd.Parameters.AddWithValue("@apl_id", apl_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tpProtocolo.Apl_id = Convert.ToInt32(registro["apl_id"]);
                tpProtocolo.Apl_descriçao = Convert.ToString(registro["apl_descriçao"]);
            }
            conexao.Desconectar();
            return tpProtocolo;
        }//carrega



    }//class

}//namespace