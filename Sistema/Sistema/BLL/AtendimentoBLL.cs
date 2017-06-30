using DAL;
using DTO;
using System;
using System.Data;

namespace BLL
{
    public class AtendimentoBLL
    {

        private ConexaoDAL conexao;

        public AtendimentoBLL(ConexaoDAL ateBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = ateBllCon;
        }

        public void Incluir(AtendimentoDTO ateBllCrud)
        {/*
            if (ateBllCrud.Ate_id.Trim().Length == 0) //verifica se foi informado 
            {
                throw new Exception("O nome da cidade é obrigatório");
            }
            /*/

            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.Incluir(ateBllCrud);

        }

        public void Alterar(AtendimentoDTO ateBllCrud)
        {
            /*
             if (ateBllCrud.Ate_id.Trim().Length == 0) //verifica se foi informado 
             {
                 throw new Exception("O nome da cidade é obrigatório");
             }
             /*/

            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.Alterar(ateBllCrud);
        }

        public void Excluir(int ate_id)
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.Excluir(ate_id);
        }

        public DataTable PesquisarNomeAnimalAtendimento(String ani_nome)
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.PesquisarNomeAnimalAtendimento(ani_nome);

            return dalObj.PesquisarNomeAnimalAtendimento(ani_nome);
        }

        // teste
        public DataTable PesquisarAnimaldoAtendimento(String ate_animal)
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.PesquisarNomeAnimalAtendimento(ate_animal);

            return dalObj.PesquisarNomeAnimalAtendimento(ate_animal);
        }
                        

        public DataTable PesquisarNomeCliente(String cli_nome)
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.PesquisarNomeCliente(cli_nome);

            return dalObj.PesquisarNomeCliente(cli_nome);
        }

        public DataTable PesquisarTodosAtendimentos()
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.PesquisarTodosAtendimentos();

            return dalObj.PesquisarTodosAtendimentos();
        }
                    

        public AtendimentoDTO CarregaAtendimentoDTO(int ate_id)
        {
            AtendimentoDAL dalObj = new AtendimentoDAL(conexao);
            dalObj.CarregaAtendimentoDTO(ate_id);

            return dalObj.CarregaAtendimentoDTO(ate_id);
        }

    }//class 

}//namespace
