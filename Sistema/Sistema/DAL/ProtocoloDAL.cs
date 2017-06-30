using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 17/03
// Data de alteração 17/03

namespace DAL
{
    public class ProtocoloDAL
    {
        private ConexaoDAL conexao;

        public ProtocoloDAL(ConexaoDAL protDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = protDalCon;
        }

        public void Incluir(ProtocoloDTO protDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbProtocolo(pro_atendimento, pro_tipo, pro_aplicaçao, pro_data, pro_intervalo) values (@pro_atendimento, @pro_tipo, @pro_aplicaçao, @pro_data, @pro_intervalo);select @@identity;";
            cmd.Parameters.AddWithValue("@pro_atendimento", protDalCrud.Prot_atendimento);
            cmd.Parameters.AddWithValue("@pro_tipo", protDalCrud.Prot_tipo);
            cmd.Parameters.AddWithValue("@pro_aplicaçao", protDalCrud.Prot_aplicaçao);          
            cmd.Parameters.AddWithValue("@pro_data", protDalCrud.Prot_data);
            cmd.Parameters.AddWithValue("@pro_intervalo", protDalCrud.Prot_intervalo);

            conexao.Conectar();

            protDalCrud.Prot_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(ProtocoloDTO protDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbProtocolo set pro_atendimento = @pro_atendimento, pro_tipo = @pro_tipo, pro_aplicaçao = @pro_aplicaçao, pro_data = @pro_data, pro_intervalo = @pro_intervalo where pro_id = @pro_id;";

            cmd.Parameters.AddWithValue("@pro_id", protDalCrud.Prot_id);
            cmd.Parameters.AddWithValue("@pro_atendimento", protDalCrud.Prot_atendimento);
            cmd.Parameters.AddWithValue("@pro_tipo", protDalCrud.Prot_tipo);
            cmd.Parameters.AddWithValue("@pro_aplicaçao", protDalCrud.Prot_aplicaçao);
            cmd.Parameters.AddWithValue("@pro_data", protDalCrud.Prot_data);
            cmd.Parameters.AddWithValue("@pro_intervalo", protDalCrud.Prot_intervalo);

            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int pro_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbProtocolo where pro_id = @pro_id;";
            cmd.Parameters.AddWithValue("@pro_id", pro_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(string pro_tipo) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbProtocolo where pro_tipo like '%" + pro_tipo + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public ProtocoloDTO CarregaProtocoloDTO(int pro_id) //tipo + o campo do banco
        {
            ProtocoloDTO prot = new ProtocoloDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbProtocolo where pro_id = @pro_id;";
            cmd.Parameters.AddWithValue("@pro_id", pro_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                prot.Prot_id = Convert.ToInt32(registro["pro_id"]);
                prot.Prot_atendimento = Convert.ToInt32(registro["pro_atendimento"]);
                prot.Prot_tipo = Convert.ToInt32(registro["pro_tipo"]);
                prot.Prot_aplicaçao = Convert.ToInt32(registro["pro_aplicaçao"]);
                prot.Prot_data = Convert.ToString(registro["pro_data"]);
                prot.Prot_intervalo = Convert.ToString(registro["pro_intervalo"]);
                
            }
            conexao.Desconectar();
            return prot;
        }//carrega

    }//class

}//namespace

