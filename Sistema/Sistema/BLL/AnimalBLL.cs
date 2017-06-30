using DAL;
using System;
using System.Data;
using DTO;

// Data de criação 09/02
// Data de modificação 09/02


// OK

namespace BLL
{
    public class AnimalBLL
    {

        private ConexaoDAL conexao;

        public AnimalBLL(ConexaoDAL aniBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = aniBllCon;
        }

        public void Incluir(AnimalDTO aniBllCrud)
        { 
            if (aniBllCrud.Ani_nome.Trim().Length == 0) //verifica se foi informado o nome animal e ou se esta vazio
            {
                throw new Exception("O nome do animal é obrigatório");
            }
          
            aniBllCrud.Ani_nome = aniBllCrud.Ani_nome.ToUpper(); //coloca em maiusculo
            

            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.Incluir(aniBllCrud);

        }

        public void Alterar(AnimalDTO aniBllCrud)
        {
            if (aniBllCrud.Ani_nome.Trim().Length == 0) //verifica se foi informado o nome animal e ou se esta vazio
            {
                throw new Exception("O nome do animal é obrigatório");
            }

            aniBllCrud.Ani_nome = aniBllCrud.Ani_nome.ToUpper(); //coloca em maiusculo

            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.Alterar(aniBllCrud);
        }

        public void Excluir(int ani_id)
        {
            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.Excluir(ani_id);
        }

        public DataTable PesquisarNomeAnimal(String ani_nome)
        {
            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.PesquisarNomeAnimal(ani_nome);

            return dalObj.PesquisarNomeAnimal(ani_nome);
        }

        public DataTable PesquisarTodosAnimal()
        {
            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.PesquisarTodosAnimal();

            return dalObj.PesquisarTodosAnimal();
        }

       
        public AnimalDTO CarregaAnimalDTO(int ani_id)
        {
            AnimalDAL dalObj = new AnimalDAL(conexao);
            dalObj.CarregaAnimalDTO(ani_id);

            return dalObj.CarregaAnimalDTO(ani_id);
        }

    }//class 

}//namespace
