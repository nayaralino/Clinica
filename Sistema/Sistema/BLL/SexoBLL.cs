using DAL;
using System;
using System.Data;
using DTO;


// Data de criação 09/02
// Data de modificação 09/02

// OK

namespace BLL
{
    public class SexoBLL
    {

        private ConexaoDAL conexao;

        public SexoBLL(ConexaoDAL sexoBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = sexoBllCon;
        }

        public void Incluir(SexoDTO sexoBllCrud)
        {
            if (sexoBllCrud.Sexo_nome.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O sexo é obrigatório");
            }


            SexoDAL dalObj = new SexoDAL(conexao);
            dalObj.Incluir(sexoBllCrud);

        }

        public void Alterar(SexoDTO sexoBllCrud)
        {
            if (sexoBllCrud.Sexo_nome.Trim().Length == 0) //verifica se foi informado o sexo
            {
                throw new Exception("O sexo é obrigatório");
            }

            SexoDAL dalObj = new SexoDAL(conexao);
            dalObj.Alterar(sexoBllCrud);
        }

        public void Excluir(int sexo_id)
        {
            SexoDAL dalObj = new SexoDAL(conexao);
            dalObj.Excluir(sexo_id);
        }

        public DataTable Pesquisar(String sexo_nome)
        {
            SexoDAL dalObj = new SexoDAL(conexao);
            dalObj.Pesquisar(sexo_nome);

            return dalObj.Pesquisar(sexo_nome);
        }

        public SexoDTO CarregaSexoDTO(int sexo_id)
        {
            SexoDAL dalObj = new SexoDAL(conexao);
            dalObj.CarregaSexoDTO(sexo_id);

            return dalObj.CarregaSexoDTO(sexo_id);
        }

    }//class 

}//namespace
