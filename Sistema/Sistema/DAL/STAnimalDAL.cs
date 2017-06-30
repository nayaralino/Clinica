using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 30/06
// Data de modificação 30/06

namespace DAL
{
    public class STAnimalDAL
    {
        private ConexaoDAL conexao;

        public STAnimalDAL(ConexaoDAL staDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = staDalCon;
        }

        public void Incluir(STAnimalDTO staDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbSTAnimal(sta_descriçao) values (@sta_descriçao);select @@identity;";
            cmd.Parameters.AddWithValue("@sta_descriçao", staDalCrud.Sta_descriçao);
            conexao.Conectar();
            staDalCrud.Sta_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(STAnimalDTO staDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbSTAnimal set sta_descriçao = @sta_descriçao where sta_id = @sta_id;";

            cmd.Parameters.AddWithValue("@sta_id", staDalCrud.Sta_id);
            cmd.Parameters.AddWithValue("@sta_descriçao", staDalCrud.Sta_descriçao);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int sta_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbSTAnimal where sta_id = @sta_id;";
            cmd.Parameters.AddWithValue("@sta_id", sta_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String sta_descriçao) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbSTAnimal where sta_descriçao like '%" + sta_descriçao + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public STAnimalDTO CarregaSTAnimalDTO(int sta_id) //tipo + o campo do banco
        {
            STAnimalDTO car = new STAnimalDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbSTAnimal where sta_id = @sta_id;";
            cmd.Parameters.AddWithValue("@sta_id", sta_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                car.Sta_id = Convert.ToInt32(registro["sta_id"]);
                car.Sta_descriçao = Convert.ToString(registro["sta_descriçao"]);
            }
            conexao.Desconectar();
            return car;
        }//carrega






    }//class

}//namespace

