using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class EstadoBLL
    {

        private ConexaoDAL conexao;

        public EstadoBLL(ConexaoDAL estBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = estBllCon;
        }

        public void Incluir(EstadoDTO estBllCrud)
        {
            if (estBllCrud.Est_estado.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O nome do estado é obrigatório");
            }


            EstadoDAL dalObj = new EstadoDAL(conexao);
            dalObj.Incluir(estBllCrud);

        }

        public void Alterar(EstadoDTO estBllCrud)
        {
            if (estBllCrud.Est_estado.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O nome do estado é obrigatório");
            }

            EstadoDAL dalObj = new EstadoDAL(conexao);
            dalObj.Alterar(estBllCrud);
        }

        public void Excluir(int est_id)
        {
            EstadoDAL dalObj = new EstadoDAL(conexao);
            dalObj.Excluir(est_id);
        }

        public DataTable Pesquisar(String est_estado)
        {
            EstadoDAL dalObj = new EstadoDAL(conexao);
            dalObj.Pesquisar(est_estado);

            return dalObj.Pesquisar(est_estado);
        }

        public EstadoDTO CarregaEstadoDTO(int est_id)
        {
            EstadoDAL dalObj = new EstadoDAL(conexao);
            dalObj.CarregaEstadoDTO(est_id);

            return dalObj.CarregaEstadoDTO(est_id);
        }

    }//class 

}//namespace
