using System;
using DAL;
using DTO;
using System.Data;

// Data de criação 21/03
// Data de alteração 21/03

namespace BLL
{
    public class TipoVacinaBLL
    {
        private ConexaoDAL conexao;

        public TipoVacinaBLL(ConexaoDAL vacBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = vacBllCon;
        }

        public void Incluir(TipoVacinaDTO vacBllCrud)
        {
            if (vacBllCrud.Tpv_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de vacina é obrigatória");
            }


            TipoVacinaDAL dalObj = new TipoVacinaDAL(conexao);
            dalObj.Incluir(vacBllCrud);

        }

        public void Alterar(TipoVacinaDTO vacBllCrud)
        {
            if (vacBllCrud.Tpv_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de vacina é obrigatória");
            }

            TipoVacinaDAL dalObj = new TipoVacinaDAL(conexao);
            dalObj.Alterar(vacBllCrud);
        }

        public void Excluir(int Tpv_id)
        {
            TipoVacinaDAL dalObj = new TipoVacinaDAL(conexao);
            dalObj.Excluir(Tpv_id);
        }

        public DataTable Pesquisar(String Tpv_descriçao)
        {
            TipoVacinaDAL dalObj = new TipoVacinaDAL(conexao);
            dalObj.Pesquisar(Tpv_descriçao);

            return dalObj.Pesquisar(Tpv_descriçao);
        }

        public TipoVacinaDTO CarregaTipoVacinaDTO(int Tpv_id)
        {
            TipoVacinaDAL dalObj = new TipoVacinaDAL(conexao);
            dalObj.CarregaTipoVacinaDTO(Tpv_id);

            return dalObj.CarregaTipoVacinaDTO(Tpv_id);
        }

    }//class 

}//namespace
