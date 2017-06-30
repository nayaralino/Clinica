using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 21/02
// Data de alteração 15/03 criei nova estrutura


namespace BLL
{
    public class TipoExameBLL
    {
        private ConexaoDAL conexao;

        public TipoExameBLL(ConexaoDAL tpexaBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = tpexaBllCon;
        }

        public void Incluir(TipoExameDTO tpexaBllCrud)
        {
            if (tpexaBllCrud.Tpe_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de exame é obrigatório");
            }
            
            TipoExameDAL dalObj = new TipoExameDAL(conexao);
            dalObj.Incluir(tpexaBllCrud);

        }

        public void Alterar(TipoExameDTO tpexaBllCrud)
        {
            if (tpexaBllCrud.Tpe_descriçao.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo do exame é obrigatório");
            }

            TipoExameDAL dalObj = new TipoExameDAL(conexao);
            dalObj.Alterar(tpexaBllCrud);
        }

        public void Excluir(int tpe_id)
        {
            TipoExameDAL dalObj = new TipoExameDAL(conexao);
            dalObj.Excluir(tpe_id);
        }

        public DataTable Pesquisar(String tpe_descriçao)
        {
            TipoExameDAL dalObj = new TipoExameDAL(conexao);
            dalObj.Pesquisar(tpe_descriçao);

            return dalObj.Pesquisar(tpe_descriçao);
        }

        public TipoExameDTO CarregaTipoExameDTO(int tpe_id)
        {
            TipoExameDAL dalObj = new TipoExameDAL(conexao);
            dalObj.CarregaTipoExameDTO(tpe_id);

            return dalObj.CarregaTipoExameDTO(tpe_id);
        }

    }//class 

}//namespace

