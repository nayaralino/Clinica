using DAL;
using System;
using System.Data;
using DTO;

// Data de criação 09/02
// Data de modificação 09/02

namespace BLL
{
    public class EspecialidadeBLL
    {
        private ConexaoDAL conexao;

        public EspecialidadeBLL(ConexaoDAL especBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = especBllCon;
        }

        public void Incluir(EspecialidadeDTO especBllCrud)
        {
            if (especBllCrud.Espec_especialidade.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("A especialidade é obrigatória");
            }


            EspecialidadeDAL dalObj = new EspecialidadeDAL(conexao);
            dalObj.Incluir(especBllCrud);

        }

        public void Alterar(EspecialidadeDTO especBllCrud)
        {
            if (especBllCrud.Espec_especialidade.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("A especialidade é obrigatória");
            }

            EspecialidadeDAL dalObj = new EspecialidadeDAL(conexao);
            dalObj.Alterar(especBllCrud);
        }

        public void Excluir(int espec_id)
        {
            EspecialidadeDAL dalObj = new EspecialidadeDAL(conexao);
            dalObj.Excluir(espec_id);
        }

        public DataTable Pesquisar(String espec_id)
        {
            EspecialidadeDAL dalObj = new EspecialidadeDAL(conexao);
            dalObj.Pesquisar(espec_id);

            return dalObj.Pesquisar(espec_id);
        }

        public EspecialidadeDTO CarregaEspecialidadeDTO(int espec_id)
        {
            EspecialidadeDAL dalObj = new EspecialidadeDAL(conexao);
            dalObj.CarregaEspecialidadeDTO(espec_id);

            return dalObj.CarregaEspecialidadeDTO(espec_id);
        }

    }//class 

}//namespace
