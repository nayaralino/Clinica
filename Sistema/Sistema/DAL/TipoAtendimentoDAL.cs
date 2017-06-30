using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 19/02
// Data de modificação 18/03 tpate para tipoa

namespace DAL
{
    public class TipoAtendimentoDAL
    {
        private ConexaoDAL conexao;

        public TipoAtendimentoDAL(ConexaoDAL tipoaDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = tipoaDalCon;
        }

        public void Incluir(TipoAtendimentoDTO tipoaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbTPATENDIMENTO(tpa_atendimento) values (@tpa_atendimento);select @@identity;";
            cmd.Parameters.AddWithValue("@tpa_atendimento", tipoaDalCrud.Tpa_atendimento);
            conexao.Conectar();

            tipoaDalCrud.Tpa_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(TipoAtendimentoDTO tipoaDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbTPATENDIMENTO set tpa_atendimento = @tpa_atendimento where tpa_id = @tpa_id;";

            cmd.Parameters.AddWithValue("@tpa_id", tipoaDalCrud.Tpa_id);
            cmd.Parameters.AddWithValue("@tpa_atendimento", tipoaDalCrud.Tpa_atendimento);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int tpa_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbTPATENDIMENTO where tpa_id = @tpa_id;";
            cmd.Parameters.AddWithValue("@tpa_id", tpa_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String tpa_atendimento) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbTPATENDIMENTO where tpa_atendimento like '%" + tpa_atendimento + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public TipoAtendimentoDTO CarregaTipoDTO(int tpa_id) //tipo + o campo do banco
        {
            TipoAtendimentoDTO tip = new TipoAtendimentoDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbTPATENDIMENTO where tpa_id = @tpa_id;";
            cmd.Parameters.AddWithValue("@tpa_id", tpa_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tip.Tpa_id = Convert.ToInt32(registro["tpa_id"]);
                tip.Tpa_atendimento = Convert.ToString(registro["tpa_atendimento"]);
            }
            conexao.Desconectar();
            return tip;
        }//carrega



    }//class

}//namespace


