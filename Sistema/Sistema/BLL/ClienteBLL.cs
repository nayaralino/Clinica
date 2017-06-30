using DAL;
using System;
using System.Data;
using DTO;
using BLL;

// revisao 13-02

namespace BLL
{
    public class ClienteBLL
    {
        private ConexaoDAL conexao;

        public ClienteBLL(ConexaoDAL cliBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = cliBllCon;
        }

        public void Incluir(ClienteDTO cliBllCrud)
        {
            if (cliBllCrud.Cli_nome.Trim().Length == 0) //verifica se foi informado um nome ou se esta vazio
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (cliBllCrud.Cli_cpf.Trim().Length == 0) //verifica se foi informado um CPF ou se esta vazio
            {
                throw new Exception("O CPF do cliente é obrigatório");
            }
            cliBllCrud.Cli_nome = cliBllCrud.Cli_nome.ToUpper(); //coloca em maiusculo
            cliBllCrud.Cli_bairro = cliBllCrud.Cli_bairro.ToUpper();


            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.Incluir(cliBllCrud);

        }

        public void Alterar(ClienteDTO cliBllCrud)
        {
            if (cliBllCrud.Cli_id <= 0)
            {
                throw new Exception("O código do cliente é obrigatório"); //verifica se foi informado um codigo ou se esta vazio
            }

            if (cliBllCrud.Cli_nome.Trim().Length == 0) //verifica se foi informado uma especie ou se esta vazio
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (cliBllCrud.Cli_cpf.Trim().Length == 0) //verifica se foi informado uma especie ou se esta vazio
            {
                throw new Exception("O CPF do cliente é obrigatório");
            }
            cliBllCrud.Cli_nome = cliBllCrud.Cli_nome.ToUpper(); //coloca em maiusculo
            cliBllCrud.Cli_bairro = cliBllCrud.Cli_bairro.ToUpper();


            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.Alterar(cliBllCrud);
        }

        public void Excluir(int cli_id)
        {
            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.Excluir(cli_id);
        }

        public DataTable PesquisarNome(String valor)
        {
            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.PesquisarNome(valor);

            return dalObj.PesquisarNome(valor);
        }

        public DataTable PesquisarTodos()
        {
            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.PesquisarTodos();

            return dalObj.PesquisarTodos();
        }        

        public DataTable PesquisarCPF(String cli_cpf)
        {
            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.PesquisarCPF(cli_cpf);

            return dalObj.PesquisarCPF(cli_cpf);
        }
                
        public ClienteDTO CarregaClienteDTO(int cli_id)
        {
            ClienteDAL dalObj = new ClienteDAL(conexao);
            dalObj.CarregaClienteDTO(cli_id);

            return dalObj.CarregaClienteDTO(cli_id);
        }
        
    }//class

}//namespace
