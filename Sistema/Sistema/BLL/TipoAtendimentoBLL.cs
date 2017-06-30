using DAL;
using DTO;
using System;
using System.Data;

// Data de criação 19/02
// Data de modificação 18/03 - tpate para tipoa

namespace BLL
{
    public class TipoAtendimentoBLL
    {
        private ConexaoDAL conexao;

        public TipoAtendimentoBLL(ConexaoDAL tipoaBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = tipoaBllCon;
        }

        public void Incluir(TipoAtendimentoDTO tipoaBllCrud)
        {
            if (tipoaBllCrud.Tpa_atendimento.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de atendimento é obrigatório");
            }


            TipoAtendimentoDAL dalObj = new TipoAtendimentoDAL(conexao);
            dalObj.Incluir(tipoaBllCrud);

        }

        public void Alterar(TipoAtendimentoDTO tipoaBllCrud)
        {
            if (tipoaBllCrud.Tpa_atendimento.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de atendimento é obrigatório");
            }

            TipoAtendimentoDAL dalObj = new TipoAtendimentoDAL(conexao);
            dalObj.Alterar(tipoaBllCrud);
        }

        public void Excluir(int tpa_id)
        {
            TipoAtendimentoDAL dalObj = new TipoAtendimentoDAL(conexao);
            dalObj.Excluir(tpa_id);
        }

        public DataTable Pesquisar(String tpa_atendimento)
        {
            TipoAtendimentoDAL dalObj = new TipoAtendimentoDAL(conexao);
            dalObj.Pesquisar(tpa_atendimento);

            return dalObj.Pesquisar(tpa_atendimento);
        }

        public TipoAtendimentoDTO CarregaTipoDTO(int tpa_id)
        {
            TipoAtendimentoDAL dalObj = new TipoAtendimentoDAL(conexao);
            dalObj.CarregaTipoDTO(tpa_id);

            return dalObj.CarregaTipoDTO(tpa_id);
        }

    }//class 

}//namespace
