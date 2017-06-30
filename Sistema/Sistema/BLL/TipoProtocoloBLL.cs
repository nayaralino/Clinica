using DAL;
using DTO;
using System;
using System.Data;

// Data de criação 17/03
// Data de alteração 17/03

namespace BLL
{
    public class TipoProtocoloBLL
    {
        private ConexaoDAL conexao;

        public TipoProtocoloBLL(ConexaoDAL tpprotBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = tpprotBllCon;
        }

        public void Incluir(TipoProtocoloDTO tpprotBllCrud)
        {
            if (tpprotBllCrud.Tipop_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de protocolo é obrigatório");
            }

            TipoProtocoloDAL dalObj = new TipoProtocoloDAL(conexao);
            dalObj.Incluir(tpprotBllCrud);

        }

        public void Alterar(TipoProtocoloDTO tpprotBllCrud)
        {
            if (tpprotBllCrud.Tipop_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo do protocolo é obrigatório");
            }

            TipoProtocoloDAL dalObj = new TipoProtocoloDAL(conexao);
            dalObj.Alterar(tpprotBllCrud);
        }

        public void Excluir(int tipop_id)
        {
            TipoProtocoloDAL dalObj = new TipoProtocoloDAL(conexao);
            dalObj.Excluir(tipop_id);
        }

        public DataTable Pesquisar(String tipop_descriçao)
        {
            TipoProtocoloDAL dalObj = new TipoProtocoloDAL(conexao);
            dalObj.Pesquisar(tipop_descriçao);

            return dalObj.Pesquisar(tipop_descriçao);
        }

        public TipoProtocoloDTO CarregaTipoProtocoloDTO(int tipop_id)
        {
            TipoProtocoloDAL dalObj = new TipoProtocoloDAL(conexao);
            dalObj.CarregaTipoProtocoloDTO(tipop_id);

            return dalObj.CarregaTipoProtocoloDTO(tipop_id);
        }

    }//class 

}//namespace

