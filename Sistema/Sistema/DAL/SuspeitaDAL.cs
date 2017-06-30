using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 17/03
// Data de alteração 17/03

namespace DAL
{
    public class SuspeitaDAL
    {
        private ConexaoDAL conexao;

        public SuspeitaDAL(ConexaoDAL susDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = susDalCon;
        }

        public void Incluir(SuspeitaDTO susDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbSuspeita(sus_descriçao, sus_atendimento) values (@sus_descriçao, @sus_atendimento);select @@identity;";
            cmd.Parameters.AddWithValue("@sus_descriçao", susDalCrud.Sus_suspeita);
            cmd.Parameters.AddWithValue("@sus_atendimento", susDalCrud.Sus_atendimento);
            
            conexao.Conectar();

            susDalCrud.Sus_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(SuspeitaDTO susDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbSuspeita set sus_descriçao = @sus_descriçao where sus_id = @sus_id;";

            cmd.Parameters.AddWithValue("@sus_id", susDalCrud.Sus_id);
            cmd.Parameters.AddWithValue("@sus_descriçao", susDalCrud.Sus_suspeita);
            cmd.Parameters.AddWithValue("@sus_atendimento", susDalCrud.Sus_atendimento);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int sus_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbSuspeita where sus_id = @sus_id;";
            cmd.Parameters.AddWithValue("@sus_id", sus_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String sus_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbSuspeita where sus_descriçao like '%" + sus_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public SuspeitaDTO CarregaSuspeitaDTO(int sus_id) //tipo + o campo do banco
        {
            SuspeitaDTO tpProtocolo = new SuspeitaDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbSuspeita where sus_id = @sus_id;";
            cmd.Parameters.AddWithValue("@sus_id", sus_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tpProtocolo.Sus_id = Convert.ToInt32(registro["sus_id"]);
                tpProtocolo.Sus_suspeita = Convert.ToString(registro["sus_descriçao"]);
                tpProtocolo.Sus_atendimento = Convert.ToInt32(registro["sus_atendimento"]); // parei aqui
            }
            conexao.Desconectar();
            return tpProtocolo;
        }//carrega



    }//class

}//namespace