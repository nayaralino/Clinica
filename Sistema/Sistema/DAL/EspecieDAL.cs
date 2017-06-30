using System;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Windows.Forms;

// Data de revisão 07/02
// add func verifica se existe
// arrumei o erro de duplicidade ao gravar, estava errado no alterar

namespace DAL
{
    public class EspecieDAL //public
    {
        private ConexaoDAL conexao;

        public EspecieDAL(ConexaoDAL espDalCon) // Construtor que recebe como parametro uma conexão // Estava errado"acho"EspecieDAL
        {
            this.conexao = espDalCon;
        }

        public void Incluir(EspecieDTO espDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbEspecie(esp_descriçao) values (@esp_descriçao);select @@identity;";
        //  cmd.Parameters.AddWithValue("@esp_id", espDalCrud.Esp_id);
            cmd.Parameters.AddWithValue("@esp_descriçao", espDalCrud.Esp_descriçao);
            conexao.Conectar();
            espDalCrud.Esp_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(EspecieDTO espDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbEspecie set esp_descriçao = @esp_descriçao where esp_id = @esp_id;";

            cmd.Parameters.AddWithValue("@esp_id", espDalCrud.Esp_id);
            cmd.Parameters.AddWithValue("@esp_descriçao", espDalCrud.Esp_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int esp_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbEspecie where esp_id = @esp_id;";
            cmd.Parameters.AddWithValue("@esp_id", esp_id) ; 
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        
        public DataTable Pesquisar(String esp_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter ("Select * from tbEspecie where esp_descriçao like '%' + esp_descriçao + '%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;            
        }//pesquisar

        public EspecieDTO CarregaEspecieDTO(int esp_id) //tipo + o campo do banco
        {
            EspecieDTO esp = new EspecieDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbEspecie where esp_id = @esp_id;";
            cmd.Parameters.AddWithValue("@esp_id", esp_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();
                esp.Esp_id = Convert.ToInt32(registro["esp_id"]);
                esp.Esp_descriçao = Convert.ToString(registro["esp_descriçao"]);
             }
            conexao.Desconectar();
            return esp;
        }//carrega_especie



       


    }//class

}//namespace


