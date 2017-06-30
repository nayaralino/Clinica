using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 21/03
// Data de alteração 21/03 alterei de vac para tpv

namespace DAL
{
    public class TipoVacinaDAL
    {
        private ConexaoDAL conexao;

        public TipoVacinaDAL(ConexaoDAL tpvDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = tpvDalCon;
        }

        public void Incluir(TipoVacinaDTO tpvDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbTPVacina(tpv_descriçao) values (@tpv_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@tpv_descriçao", tpvDalCrud.Tpv_descriçao);
            conexao.Conectar();

            tpvDalCrud.Tpv_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(TipoVacinaDTO tpvDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbTPVacina set tpv_descriçao = @tpv_descriçao where tpv_id = @tpv_id;";

            cmd.Parameters.AddWithValue("@tpv_id", tpvDalCrud.Tpv_id);
            cmd.Parameters.AddWithValue("@tpv_descriçao", tpvDalCrud.Tpv_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int tpv_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbTPVacina where tpv_id = @tpv_id;";
            cmd.Parameters.AddWithValue("@tpv_id", tpv_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String tpv_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbTPVacina where tpv_descriçao like '%" + tpv_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public TipoVacinaDTO CarregaTipoVacinaDTO(int tpv_id) //tipo + o campo do banco
        {
            TipoVacinaDTO vac = new TipoVacinaDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbTPVacina where tpv_id = @tpv_id;";
            cmd.Parameters.AddWithValue("@tpv_id", tpv_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                vac.Tpv_id = Convert.ToInt32(registro["tpv_id"]);
                vac.Tpv_descriçao = Convert.ToString(registro["tpv_descriçao"]);
            }
            conexao.Desconectar();
            return vac;
        }//carrega



    }//class

}//namespace

