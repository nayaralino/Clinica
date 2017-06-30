using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 18/02
// Data de modificação 18/02

namespace BLL
{
    public class CargoBLL
    {
        private ConexaoDAL conexao;

        public CargoBLL(ConexaoDAL carBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = carBllCon;
        }

        public void Incluir(CargoDTO carBllCrud)
        {
            if (carBllCrud.Car_cargo.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O cargo é obrigatório");
            }


            CargoDAL dalObj = new CargoDAL(conexao);
            dalObj.Incluir(carBllCrud);

        }

        public void Alterar(CargoDTO carBllCrud)
        {
            if (carBllCrud.Car_cargo.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O cargo é obrigatório");
            }

            CargoDAL dalObj = new CargoDAL(conexao);
            dalObj.Alterar(carBllCrud);
        }

        public void Excluir(int car_id)
        {
            CargoDAL dalObj = new CargoDAL(conexao);
            dalObj.Excluir(car_id);
        }

        public DataTable Pesquisar(String car_cargo)
        {
            CargoDAL dalObj = new CargoDAL(conexao);
            dalObj.Pesquisar(car_cargo);

            return dalObj.Pesquisar(car_cargo);
        }

        public CargoDTO CarregaCargoDTO(int car_id)
        {
            CargoDAL dalObj = new CargoDAL(conexao);
            dalObj.CarregaCargoDTO(car_id);

            return dalObj.CarregaCargoDTO(car_id);
        }

    }//class 

}//namespace
