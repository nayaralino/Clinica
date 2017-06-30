using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Data de criação 09/02
// Data de modificação 09/02

namespace DAL
{
    public class EstadoDAL
    {
        private ConexaoDAL conexao;

        public EstadoDAL(ConexaoDAL estDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = estDalCon;
        }

        public void Incluir(EstadoDTO estDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbEstado(est_descriçao) values (@est_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@est_descriçao", estDalCrud.Est_estado);
            conexao.Conectar();
            estDalCrud.Est_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(EstadoDTO estDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbEstado set est_descriçao = @est_descriçao where est_id = @est_id;";

            cmd.Parameters.AddWithValue("@est_id", estDalCrud.Est_id);
            cmd.Parameters.AddWithValue("@esp_descriçao", estDalCrud.Est_estado);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int est_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbEstado where est_id = @est_id;";
            cmd.Parameters.AddWithValue("@est_id", est_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String est_estado) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbEstado where est_descriçao like '%' + est_descriçao + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public EstadoDTO CarregaEstadoDTO(int est_id) //tipo + o campo do banco
        {
            EstadoDTO est = new EstadoDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbEstado where est_id = @est_id;";
            cmd.Parameters.AddWithValue("@est_id", est_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                est.Est_id = Convert.ToInt32(registro["est_id"]);
                est.Est_estado = Convert.ToString(registro["est_descriçao"]);
            }
            conexao.Desconectar();
            return est;
        }//carrega






    }//class

}//namespace