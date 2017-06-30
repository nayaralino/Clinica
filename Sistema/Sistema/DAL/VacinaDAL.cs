using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 21/02
// Data de alteração 21/02
// Data de alteração 21/03 alterei de vac para tpv

namespace DAL
{
    public class VacinaDAL
    {
        private ConexaoDAL conexao;

        public VacinaDAL(ConexaoDAL vacDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = vacDalCon;
        }

        public void Incluir(VacinaDTO vacDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbVacina(vac_atendimento, vac_tipo, vac_aplicaçao, vac_data, vac_intervalo) values (@vac_atendimento, @vac_tipo, @vac_aplicaçao, @vac_data, @vac_intervalo);select @@identity;";
            cmd.Parameters.AddWithValue("@vac_atendimento", vacDalCrud.Vac_atendimento);
            cmd.Parameters.AddWithValue("@vac_tipo", vacDalCrud.Vac_tipo);
            cmd.Parameters.AddWithValue("@vac_aplicaçao", vacDalCrud.Vac_aplicaçao);
            cmd.Parameters.AddWithValue("@vac_data", vacDalCrud.Vac_data);
            cmd.Parameters.AddWithValue("@vac_intervalo", vacDalCrud.Vac_intervalo);

            conexao.Conectar();

            vacDalCrud.Vac_id = Convert.ToInt32(cmd.ExecuteScalar());

            conexao.Desconectar();
        }//incluir

        public void Alterar(VacinaDTO vacDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbVacina set vac_atendimento = @vac_atendimento, vac_tipo = @vac_tipo, vac_aplicaçao = @vac_aplicaçao, vac_data = @vac_data, vac_intervalo = @vac_intervalo where vac_id = @vac_id;";

            cmd.Parameters.AddWithValue("@vac_id", vacDalCrud.Vac_id);
            cmd.Parameters.AddWithValue("@vac_atendimento", vacDalCrud.Vac_atendimento);
            cmd.Parameters.AddWithValue("@vac_tipo", vacDalCrud.Vac_tipo);
            cmd.Parameters.AddWithValue("@vac_aplicaçao", vacDalCrud.Vac_aplicaçao);
            cmd.Parameters.AddWithValue("@vac_data", vacDalCrud.Vac_data);
            cmd.Parameters.AddWithValue("@vac_intervalo", vacDalCrud.Vac_intervalo);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int vac_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbVacina where vac_id = @vac_id;";
            cmd.Parameters.AddWithValue("@vac_id", vac_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String vac_atendimento) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbVacina where vac_atendimento like '%" + vac_atendimento + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public VacinaDTO CarregaVacinaDTO(int vac_id) //tipo + o campo do banco
        {
            VacinaDTO vac = new VacinaDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbVacina where vac_id = @vac_id;";
            cmd.Parameters.AddWithValue("@vac_id", vac_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                vac.Vac_id = Convert.ToInt32(registro["vac_id"]);
                vac.Vac_atendimento = Convert.ToString(registro["vac_atendimento"]);
                vac.Vac_tipo = Convert.ToInt32(registro["vac_tipo"]);
                vac.Vac_aplicaçao = Convert.ToInt32(registro["vac_aplicaçao"]);
                vac.Vac_data = Convert.ToString(registro["vac_data"]);
                vac.Vac_intervalo = Convert.ToString(registro["vac_intervalo"]);
                
            }
            conexao.Desconectar();
            return vac;
        }//carrega



    }//class

}//namespace
