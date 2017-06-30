using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//revisão 22/10
// os campos com validação obrigatória - nome, cpf, usuario, senha, confirmarSenha

namespace BLL
{
    public class UsuarioBLL
    {
        private ConexaoDAL conexao;

        public UsuarioBLL(ConexaoDAL usrBllCon) // Construtor que recebe como parametro uma conexão
        {
            this.conexao = usrBllCon;
        }

        public void Incluir(UsuarioDTO usrBllCrud)
        {
            if (usrBllCrud.Usr_nome.Trim().Length == 0) //verifica se foi informado um nome e ou se esta vazio
            {
                throw new Exception("O nome do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_cpf.Trim().Length == 0) //verifica se foi informado um CPF e ou se esta vazio
            {
                throw new Exception("O CPF do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_senha.Trim().Length == 0) //verifica se foi informado uma senha e ou se esta vazio
            {
                throw new Exception("A senha do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_confirmarSenha.Trim().Length == 0) //verifica se foi informado a conf da senha e ou se esta vazio
            {
                throw new Exception("A confirmação da senha é obrigatório");
            }

            if (usrBllCrud.Usr_usuario.Trim().Length == 0) //verifica se foi informado um usuario e ou se esta vazio
            {
                throw new Exception("O usuario é obrigatório");
            }
            usrBllCrud.Usr_nome = usrBllCrud.Usr_nome.ToUpper(); //coloca em maiusculo
            usrBllCrud.Usr_usuario = usrBllCrud.Usr_usuario.ToUpper(); //coloca em maiusculo

            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.Incluir(usrBllCrud);

        }

        public void Alterar(UsuarioDTO usrBllCrud)
        {
            if (usrBllCrud.Usr_id <= 0)
            {
                throw new Exception("O código do usuario é obrigatório");//verifica se foi informado um codigo ou se esta vazio
            }

            if (usrBllCrud.Usr_nome.Trim().Length == 0) //verifica se foi informado um nome e ou se esta vazio
            {
                throw new Exception("O nome do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_cpf.Trim().Length == 0) //verifica se foi informado um CPF e ou se esta vazio
            {
                throw new Exception("O CPF do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_senha.Trim().Length == 0) //verifica se foi informado uma senha e ou se esta vazio
            {
                throw new Exception("A senha do usuario é obrigatório");
            }

            if (usrBllCrud.Usr_confirmarSenha.Trim().Length == 0) //verifica se foi informado a conf da senha e ou se esta vazio
            {
                throw new Exception("A confirmação da senha é obrigatório");
            }

            if (usrBllCrud.Usr_usuario.Trim().Length == 0) //verifica se foi informado um usuario e ou se esta vazio
            {
                throw new Exception("O usuario é obrigatório");
            }

            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.Alterar(usrBllCrud);
        }

        public void Excluir(int usr_id)
        {
            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.Excluir(usr_id);
        }

        public DataTable PesquisarNome(String valor)
        {
            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.PesquisarNome(valor);

            return dalObj.PesquisarNome(valor);
        }

        public DataTable PesquisarTodos()
        {
            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.PesquisarTodos();

            return dalObj.PesquisarTodos();
        }

        public DataTable PesquisarCPF(String usr_cpf)
        {
            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.PesquisarCPF(usr_cpf);

            return dalObj.PesquisarCPF(usr_cpf);
        }


        public UsuarioDTO CarregaUsuarioDTO(int usr_id)
        {
            UsuarioDAL dalObj = new UsuarioDAL(conexao);
            dalObj.CarregaUsuarioDTO(usr_id);

            return dalObj.CarregaUsuarioDTO(usr_id);
        }

    }//class 

}//namespace

