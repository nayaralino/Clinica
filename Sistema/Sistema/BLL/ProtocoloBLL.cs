using DAL;
using DTO;
using System;
using System.Data;
// Data de criação 17/03
// Data de alteração 17/03

namespace BLL
{
    public class ProtocoloBLL
    {
        private ConexaoDAL conexao;

        public ProtocoloBLL(ConexaoDAL protBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = protBllCon;
        }

        public void Incluir(ProtocoloDTO protBllCrud)
        {
       /*     if (protBllCrud.Prot_tipo.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de exame é obrigatório");
            }
        /*/
            ProtocoloDAL dalObj = new ProtocoloDAL(conexao);
            dalObj.Incluir(protBllCrud);

        }

        public void Alterar(ProtocoloDTO protBllCrud)
        {
            /*     if (protBllCrud.Prot_tipo.Trim().Length == 0) //verifica se foi informado 
              {
                  throw new Exception("O tipo de exame é obrigatório");
              }
          /*/

            ProtocoloDAL dalObj = new ProtocoloDAL(conexao);
            dalObj.Alterar(protBllCrud);
        }

        public void Excluir(int prot_id)
        {
            ProtocoloDAL dalObj = new ProtocoloDAL(conexao);
            dalObj.Excluir(prot_id);
        }

        public DataTable Pesquisar(String prot_tipo)
        {
            ProtocoloDAL dalObj = new ProtocoloDAL(conexao);
            dalObj.Pesquisar(prot_tipo);

            return dalObj.Pesquisar(prot_tipo);
        }

        public ProtocoloDTO CarregaProtocoloDTO(int prot_id)
        {
            ProtocoloDAL dalObj = new ProtocoloDAL(conexao);
            dalObj.CarregaProtocoloDTO(prot_id);

            return dalObj.CarregaProtocoloDTO(prot_id);
        }

    }//class 

}//namespace

