using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 30/06
// Data de modificação 30/06

namespace BLL
{
    public class STAnimalBLL
    {
        private ConexaoDAL conexao;

        public STAnimalBLL(ConexaoDAL staBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = staBllCon;
        }

        public void Incluir(STAnimalDTO staBllCrud)
        {
            if (staBllCrud.Sta_descriçao.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O status é obrigatório");
            }


            STAnimalDAL dalObj = new STAnimalDAL(conexao);
            dalObj.Incluir(staBllCrud);

        }

        public void Alterar(STAnimalDTO staBllCrud)
        {
            if (staBllCrud.Sta_descriçao.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O status é obrigatório");
            }

            STAnimalDAL dalObj = new STAnimalDAL(conexao);
            dalObj.Alterar(staBllCrud);
        }

        public void Excluir(int sta_id)
        {
            STAnimalDAL dalObj = new STAnimalDAL(conexao);
            dalObj.Excluir(sta_id);
        }

        public DataTable Pesquisar(String sta_descriçao)
        {
            STAnimalDAL dalObj = new STAnimalDAL(conexao);
            dalObj.Pesquisar(sta_descriçao);

            return dalObj.Pesquisar(sta_descriçao);
        }

        public STAnimalDTO CarregaSTAnimalDTO(int sta_id)
        {
            STAnimalDAL dalObj = new STAnimalDAL(conexao);
            dalObj.CarregaSTAnimalDTO(sta_id);

            return dalObj.CarregaSTAnimalDTO(sta_id);
        }

    }//class 

}//namespace
