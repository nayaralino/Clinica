using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class CidadeDAL
    {
        private ConexaoDAL conexao;

        public CidadeDAL(ConexaoDAL cidDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = cidDalCon;
        }

        public void Incluir(CidadeDTO cidDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbCidade (cid_descriçao) values (@cid_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@cid_descriçao", cidDalCrud.Cid_cidade);
            conexao.Conectar();
            cidDalCrud.Cid_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(CidadeDTO cidDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbCidade set cid_descriçao = @cid_descriçao where cid_id = @cid_id;";

            cmd.Parameters.AddWithValue("@cid_id", cidDalCrud.Cid_id);
            cmd.Parameters.AddWithValue("@cid_descriçao", cidDalCrud.Cid_cidade);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int cid_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbCidade where cid_id = @cid_id;";
            cmd.Parameters.AddWithValue("@cid_id", cid_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String cid_cidade) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbCidade where cid_descriçao like '%' + cid_descriçao + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public CidadeDTO CarregaCidadeDTO(int cid_id) //tipo + o campo do banco
        {
            CidadeDTO cid = new CidadeDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbCidade where cid_id = @cid_id;";
            cmd.Parameters.AddWithValue("@cid_id", cid_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cid.Cid_id = Convert.ToInt32(registro["cid_id"]);
                cid.Cid_cidade = Convert.ToString(registro["cid_descriçao"]);
            }
            conexao.Desconectar();
            return cid;
        }//carrega
        
    }//class

}//namespace