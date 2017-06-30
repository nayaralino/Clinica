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
    public class ExameBLL
    {
        private ConexaoDAL conexao;

        public ExameBLL(ConexaoDAL exaBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = exaBllCon;
        }

        public void Incluir(ExameDTO exaBllCrud)
        {
      /*      if (exaBllCrud.Exame_tipoExame.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O tipo de exame é obrigatório");
            }

    /*/
            ExameDAL dalObj = new ExameDAL(conexao);
            dalObj.Incluir(exaBllCrud);

        }

        public void Alterar(ExameDTO exaBllCrud)
        {
            /*      if (exaBllCrud.Exame_tipoExame.Trim().Length == 0) //verifica se foi informado 
             {
                 throw new Exception("O tipo de exame é obrigatório");
             }

     /*/
            ExameDAL dalObj = new ExameDAL(conexao);
            dalObj.Alterar(exaBllCrud);
        }

        public void Excluir(int exame_id)
        {
            ExameDAL dalObj = new ExameDAL(conexao);
            dalObj.Excluir(exame_id);
        }

        public DataTable Pesquisar(String exame_tipoExame)
        {
            ExameDAL dalObj = new ExameDAL(conexao);
            dalObj.Pesquisar(exame_tipoExame);

            return dalObj.Pesquisar(exame_tipoExame);
        }

        public ExameDTO CarregaExameDTO(int exa_id)
        {
            ExameDAL dalObj = new ExameDAL(conexao);
            dalObj.CarregaExameDTO(exa_id);

            return dalObj.CarregaExameDTO(exa_id);
        }

    }//class 

}//namespace
