using System;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class EspecialidadeDAL //public
    {
        private ConexaoDAL conexao;

        public EspecialidadeDAL(ConexaoDAL especDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = especDalCon;
        }

        public void Incluir(EspecialidadeDTO especDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbEspecialidade(espec_descriçao) values (@espec_descriçao);select @@identity;";           
            cmd.Parameters.AddWithValue("@espec_descriçao", especDalCrud.Espec_especialidade);
            conexao.Conectar();
            especDalCrud.Espec_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(EspecialidadeDTO especDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbEspecialidade set espec_descriçao = @espec_descriçao where espec_id = @espec_id;";

            cmd.Parameters.AddWithValue("@espec_id", especDalCrud.Espec_id);
            cmd.Parameters.AddWithValue("@espec_descriçao", especDalCrud.Espec_especialidade);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int espec_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbEspecialidade where espec_id = @espec_id;";
            cmd.Parameters.AddWithValue("@espec_id", espec_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir


        public DataTable Pesquisar(String espec_especialidade) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbEspecialidade where espec_descriçao like '%' + espec_descriçao + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public EspecialidadeDTO CarregaEspecialidadeDTO(int espec_id) //tipo + o campo do banco
        {
            EspecialidadeDTO espec = new EspecialidadeDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbEspecialidade where espec_id = @espec_id;";
            cmd.Parameters.AddWithValue("@espec_id", espec_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                espec.Espec_id = Convert.ToInt32(registro["espec_id"]);
                espec.Espec_especialidade = Convert.ToString(registro["espec_descriçao"]);
            }
            conexao.Desconectar();
            return espec;
        }

       



    }//class

}//namespace

