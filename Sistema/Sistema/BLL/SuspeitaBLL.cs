using DAL;
using DTO;
using System;
using System.Data;

// Data de criação 17/03
// Data de alteração 17/03

namespace BLL
{
    public class SuspeitaBLL
    {
        private ConexaoDAL conexao;

        public SuspeitaBLL(ConexaoDAL susBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = susBllCon;
        }

        public void Incluir(SuspeitaDTO susBllCrud)
        {
            if (susBllCrud.Sus_suspeita.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de suspeita é obrigatório");
            }

            SuspeitaDAL dalObj = new SuspeitaDAL(conexao);
            dalObj.Incluir(susBllCrud);

        }

        public void Alterar(SuspeitaDTO susBllCrud)
        {
            if (susBllCrud.Sus_suspeita.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de suspeita é obrigatório");
            }

            SuspeitaDAL dalObj = new SuspeitaDAL(conexao);
            dalObj.Alterar(susBllCrud);
        }

        public void Excluir(int sus_id)
        {
            SuspeitaDAL dalObj = new SuspeitaDAL(conexao);
            dalObj.Excluir(sus_id);
        }

        public DataTable Pesquisar(String sus_suspeita)
        {
            SuspeitaDAL dalObj = new SuspeitaDAL(conexao);
            dalObj.Pesquisar(sus_suspeita);

            return dalObj.Pesquisar(sus_suspeita);
        }

        public SuspeitaDTO CarregaSuspeitaDTO(int sus_id)
        {
            SuspeitaDAL dalObj = new SuspeitaDAL(conexao);
            dalObj.CarregaSuspeitaDTO(sus_id);

            return dalObj.CarregaSuspeitaDTO(sus_id);
        }

    }//class 

}//namespace