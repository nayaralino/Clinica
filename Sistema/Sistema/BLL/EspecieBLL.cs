using DAL;
using System;
using System.Data;
using DTO;

// revisao 22/10
// os campos com validação obrigatória - nome 

namespace BLL
{
    public class EspecieBLL
    {
        private ConexaoDAL conexao;
        
        public EspecieBLL (ConexaoDAL espBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = espBllCon;
        }

        public void Incluir(EspecieDTO espBllCrud)
        {
            if(espBllCrud.Esp_descriçao.Trim().Length == 0) //verifica se foi informado uma especie ou se esta vazio
            {
                throw new Exception("O nome da especie é obrigatório");
            }
            espBllCrud.Esp_descriçao = espBllCrud.Esp_descriçao.ToUpper(); //coloca em maiusculo

            EspecieDAL dalObj = new EspecieDAL(conexao);
            dalObj.Incluir(espBllCrud);

        }

        public void Alterar(EspecieDTO espBllCrud)
        {
            if(espBllCrud.Esp_id<=0) 
            {
                throw new Exception("O código da especie é obrigatório");//verifica se foi informado um codigo ou se esta vazio
            }

            if (espBllCrud.Esp_descriçao.Trim().Length == 0) //verifica se foi informado uma especie ou se esta vazio
            {
                throw new Exception("O nome da especie é obrigatório");
            }
            espBllCrud.Esp_descriçao = espBllCrud.Esp_descriçao.ToUpper(); //coloca em maiusculo

            EspecieDAL dalObj = new EspecieDAL(conexao);
            dalObj.Alterar(espBllCrud);
        }

        public void Excluir(int esp_id)
        {
            EspecieDAL dalObj = new EspecieDAL(conexao);
            dalObj.Excluir(esp_id);
        }

//
        public DataTable Pesquisar(String esp_descriçao)
        {
            EspecieDAL dalObj = new EspecieDAL(conexao);
            dalObj.Pesquisar(esp_descriçao);

            return dalObj.Pesquisar(esp_descriçao);
        }

        public EspecieDTO CarregaEspecieDTO(int esp_id)
        {
            EspecieDAL dalObj = new EspecieDAL(conexao);
            dalObj.CarregaEspecieDTO(esp_id);

            return dalObj.CarregaEspecieDTO(esp_id);
        }

     
        

    }//class 

}//namespace
