using DAL;
using DTO;
using System;
using System.Data;

// Data de criação 17/03
// Data de alteração 17/03

namespace BLL
{
    public class AplicaçaoBLL
    {

        private ConexaoDAL conexao;

        public AplicaçaoBLL(ConexaoDAL apliBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = apliBllCon;
        }

        public void Incluir(AplicaçaoDTO apliBllCrud)
        {
            if (apliBllCrud.Apl_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de aplicaçao é obrigatório");
            }

            AplicaçaoDAL dalObj = new AplicaçaoDAL(conexao);
            dalObj.Incluir(apliBllCrud);

        }

        public void Alterar(AplicaçaoDTO apliBllCrud)
        {
            if (apliBllCrud.Apl_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de aplicaçao é obrigatório");
            }

            AplicaçaoDAL dalObj = new AplicaçaoDAL(conexao);
            dalObj.Alterar(apliBllCrud);
        }

        public void Excluir(int apl_id)
        {
            AplicaçaoDAL dalObj = new AplicaçaoDAL(conexao);
            dalObj.Excluir(apl_id);
        }

        public DataTable Pesquisar(String apl_descriçao)
        {
            AplicaçaoDAL dalObj = new AplicaçaoDAL(conexao);
            dalObj.Pesquisar(apl_descriçao);

            return dalObj.Pesquisar(apl_descriçao);
        }

        public AplicaçaoDTO CarregaAplicaçaoDTO(int apl_id)
        {
            AplicaçaoDAL dalObj = new AplicaçaoDAL(conexao);
            dalObj.CarregaAplicaçaoDTO(apl_id);

            return dalObj.CarregaAplicaçaoDTO(apl_id);
        }

    }//class 

}//namespace

