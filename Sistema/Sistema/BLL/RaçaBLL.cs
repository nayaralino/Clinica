using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//revisão 22/10
// os campos com validação obrigatória - nome 

namespace BLL
{
    public class RaçaBLL
    {
        private ConexaoDAL conexao;

        public RaçaBLL(ConexaoDAL raçBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = raçBllCon;
        }

        public void Incluir(RaçaDTO raçBllCrud)
        {
            if (raçBllCrud.Raç_descriçao.Trim().Length == 0) //verifica se foi informado uma raça e ou se esta vazio
            {
                throw new Exception("O nome da raça é obrigatório");
            }
            raçBllCrud.Raç_descriçao = raçBllCrud.Raç_descriçao.ToUpper(); //coloca em maiusculo

            RaçaDAL dalObj = new RaçaDAL(conexao);
            dalObj.Incluir(raçBllCrud);

        }

        public void Alterar(RaçaDTO raçBllCrud)
        {
            if (raçBllCrud.Raç_id <= 0)
            {
                throw new Exception("O código da raça é obrigatório"); //verifica se foi informado um codigo ou se esta vazio
            }

            if (raçBllCrud.Raç_descriçao.Trim().Length == 0) //verifica se foi informado uma raça e ou se esta vazio
            {
                throw new Exception("O nome da raça é obrigatório");
            }
            raçBllCrud.Raç_descriçao = raçBllCrud.Raç_descriçao.ToUpper(); //coloca em maiusculo

            RaçaDAL dalObj = new RaçaDAL(conexao);
            dalObj.Alterar(raçBllCrud);
        }

        public void Excluir(int raç_id)
        {
            RaçaDAL dalObj = new RaçaDAL(conexao);
            dalObj.Excluir(raç_id);
        }

        public DataTable Pesquisar(String raç_descriçao)
        {
            RaçaDAL dalObj = new RaçaDAL(conexao);
            dalObj.Pesquisar(raç_descriçao);

            return dalObj.Pesquisar(raç_descriçao);
        }

        public RaçaDTO CarregaRaçaDTO(int raç_id)
        {
            RaçaDAL dalObj = new RaçaDAL(conexao);
            dalObj.CarregaRaçaDTO(raç_id);

            return dalObj.CarregaRaçaDTO(raç_id);
        }

    }//class 

}//namespace

