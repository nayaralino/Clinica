using DAL;
using DTO;
using System;
using System.Data;

// Data de criação 17/03
// Data de alteração 17/03

namespace BLL
{
    public class PrescriçaoBLL
    {
        private ConexaoDAL conexao;

        public PrescriçaoBLL(ConexaoDAL presBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = presBllCon;
        }

        public void Incluir(PrescriçaoDTO presBllCrud)
        {
            if (presBllCrud.Pres_prescriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de prescrição é obrigatório");
            }

            PrescriçaoDAL dalObj = new PrescriçaoDAL(conexao);
            dalObj.Incluir(presBllCrud);

        }

        public void Alterar(PrescriçaoDTO presBllCrud)
        {
            if (presBllCrud.Pres_prescriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de prescrição é obrigatório");
            }

            PrescriçaoDAL dalObj = new PrescriçaoDAL(conexao);
            dalObj.Alterar(presBllCrud);
        }

        public void Excluir(int pres_id)
        {
            PrescriçaoDAL dalObj = new PrescriçaoDAL(conexao);
            dalObj.Excluir(pres_id);
        }

        public DataTable Pesquisar(String pres_prescriçao)
        {
            PrescriçaoDAL dalObj = new PrescriçaoDAL(conexao);
            dalObj.Pesquisar(pres_prescriçao);

            return dalObj.Pesquisar(pres_prescriçao);
        }

        public PrescriçaoDTO CarregaPrescriçaoDTO(int pres_id)
        {
            PrescriçaoDAL dalObj = new PrescriçaoDAL(conexao);
            dalObj.CarregaPrescriçaoDTO(pres_id);

            return dalObj.CarregaPrescriçaoDTO(pres_id);
        }

    }//class 

}//namespace