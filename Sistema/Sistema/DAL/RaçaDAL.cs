using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//revisão 13/01/2017 
// add func verifica se existe
// add insert e update o id

namespace DAL
{
    public class RaçaDAL
    {
        private ConexaoDAL conexao;

        public RaçaDAL(ConexaoDAL raçaDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = raçaDalCon;
        }

        public void Incluir(RaçaDTO raçaDalCrud)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "insert into tbRaça(raç_descriçao, raç_especie) values (@raç_descriçao, @raç_especie);select @@identity;";
                cmd.Parameters.AddWithValue("@raç_descriçao", raçaDalCrud.Raç_descriçao);
                cmd.Parameters.AddWithValue("@raç_especie", raçaDalCrud.Raç_especie);
                conexao.Conectar();
                raçaDalCrud.Raç_id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            
            catch (Exception erro)
            { 
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }//incluir

        public void Alterar(RaçaDTO raçaDalCrud)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "update tbRaça set raç_descriçao = @raç_descriçao , raç_especie = @raç_especie where raç_id = @raç_id;";
                cmd.Parameters.AddWithValue("@raç_id", raçaDalCrud.Raç_id);
                cmd.Parameters.AddWithValue("@raç_descriçao", raçaDalCrud.Raç_descriçao);
                cmd.Parameters.AddWithValue("@raç_especie", raçaDalCrud.Raç_especie);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); //não retorna parametro algum
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        


        }//alterar

        public void Excluir(int raç_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbRaça where raç_id = @raç_id;";
            cmd.Parameters.AddWithValue("@raç_id", raç_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String raç_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
           // SqlDataAdapter da = new SqlDataAdapter("Select * from tbRaça where raç_descriçao like '%' + raç_descriçao + '%'", conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select r.raç_id, r.raç_descriçao, r.raç_especie, e.esp_descriçao from tbRaça AS r inner join tbEspecie AS e on r.raç_especie = e.esp_id where r.raç_descriçao like '%' + r.raç_descriçao + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public RaçaDTO CarregaRaçaDTO(int raç_id) //tipo + o campo do banco
        {
            RaçaDTO raça = new RaçaDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbRaça where raç_id = @raç_id;";
            cmd.Parameters.AddWithValue("@raç_id", raç_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                raça.Raç_id = Convert.ToInt32(registro["raç_id"]);
                raça.Raç_descriçao = Convert.ToString(registro["raç_descriçao"]);
            }
            conexao.Desconectar();
            return raça;
        }//carrega_raça
               
    }//class

}//namespace

