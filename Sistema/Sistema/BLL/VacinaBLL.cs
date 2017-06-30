using System;
using DAL;
using DTO;
using System.Data;

// Data de criação 21/02
// Data de alteração 21/03 alterei conforme o banco

namespace BLL
{
    public class VacinaBLL
    {
        private ConexaoDAL conexao;

        public VacinaBLL(ConexaoDAL vacBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = vacBllCon;
        }

        public void Incluir(VacinaDTO vacBllCrud)
        {
       /*     if (vacBllCrud.Vac_tipo.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("A vacina é obrigatória");
            }
        */

            VacinaDAL dalObj = new VacinaDAL(conexao);
            dalObj.Incluir(vacBllCrud);

        }

        public void Alterar(VacinaDTO vacBllCrud)
        {
            /*     if (vacBllCrud.Vac_tipo.Trim().Length == 0) //verifica se foi informado 
             {
                 throw new Exception("A vacina é obrigatória");
             }
         */

            VacinaDAL dalObj = new VacinaDAL(conexao);
            dalObj.Alterar(vacBllCrud);
        }

        public void Excluir(int vac_id)
        {
            VacinaDAL dalObj = new VacinaDAL(conexao);
            dalObj.Excluir(vac_id);
        }

        public DataTable Pesquisar(String vac_tipo)
        {
            VacinaDAL dalObj = new VacinaDAL(conexao);
            dalObj.Pesquisar(vac_tipo);

            return dalObj.Pesquisar(vac_tipo);
        }

        public VacinaDTO CarregaVacinaDTO(int vac_id)
        {
            VacinaDAL dalObj = new VacinaDAL(conexao);
            dalObj.CarregaVacinaDTO(vac_id);

            return dalObj.CarregaVacinaDTO(vac_id);
        }

    }//class 

}//namespace
