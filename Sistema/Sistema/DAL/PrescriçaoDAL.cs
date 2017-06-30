using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 17/03
// Data de alteração 17/03

namespace DAL
{
    public class PrescriçaoDAL
    {
        private ConexaoDAL conexao;

        public PrescriçaoDAL(ConexaoDAL presDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = presDalCon;
        }

        public void Incluir(PrescriçaoDTO presDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbPrescriçao(pre_descriçao, pre_atendimento) values (@pre_descriçao, @pre_atendimento);select @@identity;";
            cmd.Parameters.AddWithValue("@pre_descriçao", presDalCrud.Pres_prescriçao);
            cmd.Parameters.AddWithValue("@pre_atendimento", presDalCrud.Pres_atendimento);
            conexao.Conectar();

            presDalCrud.Pres_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(PrescriçaoDTO presDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbPrescriçao set pre_descriçao = @pre_descriçao where pre_id = @pre_id;";

            cmd.Parameters.AddWithValue("@pre_id", presDalCrud.Pres_id);
            cmd.Parameters.AddWithValue("@pre_descriçao", presDalCrud.Pres_prescriçao);
            cmd.Parameters.AddWithValue("@pre_atendimento", presDalCrud.Pres_atendimento);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int pre_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbPrescriçao where pre_id = @pre_id;";
            cmd.Parameters.AddWithValue("@pre_id", pre_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String pre_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbPrescriçao where pre_descriçao like '%" + pre_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public PrescriçaoDTO CarregaPrescriçaoDTO(int pre_id) //tipo + o campo do banco
        {
            PrescriçaoDTO tpProtocolo = new PrescriçaoDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbPrescriçao where pre_id = @pre_id;";
            cmd.Parameters.AddWithValue("@pre_id", pre_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                tpProtocolo.Pres_id = Convert.ToInt32(registro["pre_id"]);
                tpProtocolo.Pres_prescriçao = Convert.ToString(registro["pre_descriçao"]);
                tpProtocolo.Pres_atendimento = Convert.ToInt32(registro["pre_atendimento"]); // parei aqui
            }
            conexao.Desconectar();
            return tpProtocolo;
        }//carrega



    }//class

}//namespace