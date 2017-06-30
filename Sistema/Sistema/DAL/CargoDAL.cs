using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

// Data de criação 18/02
// Data de modificação 18/02

namespace DAL
{
    public class CargoDAL
    {
        private ConexaoDAL conexao;

        public CargoDAL(ConexaoDAL carDalCon) // Construtor que recebe como parametro uma conexão 
        {
            this.conexao = carDalCon;
        }

        public void Incluir(CargoDTO carDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "insert into tbCargo(car_cargo) values (@car_cargo);select @@identity;";
            cmd.Parameters.AddWithValue("@car_cargo", carDalCrud.Car_cargo);
            conexao.Conectar();
            carDalCrud.Car_id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }//incluir

        public void Alterar(CargoDTO carDalCrud)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "update tbCargo set car_cargo = @car_cargo where car_id = @car_id;";

            cmd.Parameters.AddWithValue("@car_id", carDalCrud.Car_id);
            cmd.Parameters.AddWithValue("@car_cargo", carDalCrud.Car_cargo);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//alterar

        public void Excluir(int car_id) //tipo + o campo do banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "delete from tbCargo where car_id = @car_id;";
            cmd.Parameters.AddWithValue("@car_id", car_id);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); //não retorna parametro algum
            conexao.Desconectar();
        }//excluir

        public DataTable Pesquisar(String car_cargo) //tipo + o campo do banco
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbCargo where car_cargo like '%" + car_cargo + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }//pesquisar

        public CargoDTO CarregaCargoDTO(int car_id) //tipo + o campo do banco
        {
            CargoDTO car = new CargoDTO();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.Conexao;
            cmd.CommandText = "select * from tbCargo where car_id = @car_id;";
            cmd.Parameters.AddWithValue("@car_id", car_id);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                car.Car_id = Convert.ToInt32(registro["car_id"]);
                car.Car_cargo = Convert.ToString(registro["car_cargo"]);
            }
            conexao.Desconectar();
            return car;
        }//carrega






    }//class

}//namespace

