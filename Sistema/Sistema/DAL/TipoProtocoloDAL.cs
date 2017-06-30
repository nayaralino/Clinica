using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 17/03
// Data de alteração 17/03

namespace DAL
{
    public class TipoProtocoloDAL
    {
        private ConexaoDAL conexao;

        public TipoProtocoloDAL(ConexaoDAL tpexaDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = tpexaDalCon;
        }

        public void Incluir(TipoProtocoloDTO tpexaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbTPProtocolo(tpp_descriçao) values (@tpp_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@tpp_descriçao", tpexaDalCrud.Tipop_descriçao);
            conexao.Conectar();

            tpexaDalCrud.Tipop_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(TipoProtocoloDTO tpexaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbTPProtocolo set tpp_descriçao = @tpp_descriçao where tpp_id = @tpp_id;";

            cmd.Parameters.AddWithValue("@tpp_id", tpexaDalCrud.Tipop_id);
            cmd.Parameters.AddWithValue("@tpp_descriçao", tpexaDalCrud.Tipop_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int tpp_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbTPProtocolo where tpp_id = @tpp_id;";
            cmd.Parameters.AddWithValue("@tpp_id", tpp_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String tpp_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbTPProtocolo where tpp_descriçao like '%" + tpp_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public TipoProtocoloDTO CarregaTipoProtocoloDTO(int tpp_id) //tipo + o campo do banco
        {
            TipoProtocoloDTO tpProtocolo = new TipoProtocoloDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbTPProtocolo where tpp_id = @tpp_id;";
            cmd.Parameters.AddWithValue("@tpp_id", tpp_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tpProtocolo.Tipop_id = Convert.ToInt32(registro["tpp_id"]);
                tpProtocolo.Tipop_descriçao = Convert.ToString(registro["tpp_descriçao"]);
            }
            conexao.Desconectar();
            return tpProtocolo;
        }//carrega



    }//class

}//namespace


