using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data criação 17/02
// Data alteração 17/02

//  Modelo de Dados - DTO (Modelo) // OK
// 1- Cria os atributos privados | 2 - ctrl + r + e - gerar os gets/sets | 

namespace DTO
{
    public class UsuarioDTO
    {
        private int usr_id;
        private string usr_nome;
        private string usr_cpf;
        private string usr_telefone;
        private string usr_celular;
        private string usr_logradouro;
        private string usr_numero;
        private string usr_complemento;
        private string usr_bairro;
        private int usr_cargo;
        private string usr_usuario;        
        private string usr_senha;
        private string usr_confirmarSenha;
        private string usr_email;
        private int usr_cidade;
        private int usr_estado;

        public int Usr_id
        {
            get
            {
                return usr_id;
            }

            set
            {
                usr_id = value;
            }
        }

        public string Usr_nome
        {
            get
            {
                return usr_nome;
            }

            set
            {
                usr_nome = value;
            }
        }

        public string Usr_cpf
        {
            get
            {
                return usr_cpf;
            }

            set
            {
                usr_cpf = value;
            }
        }

        public string Usr_telefone
        {
            get
            {
                return usr_telefone;
            }

            set
            {
                usr_telefone = value;
            }
        }

        public string Usr_celular
        {
            get
            {
                return usr_celular;
            }

            set
            {
                usr_celular = value;
            }
        }

        public string Usr_logradouro
        {
            get
            {
                return usr_logradouro;
            }

            set
            {
                usr_logradouro = value;
            }
        }

        public string Usr_numero
        {
            get
            {
                return usr_numero;
            }

            set
            {
                usr_numero = value;
            }
        }

        public string Usr_complemento
        {
            get
            {
                return usr_complemento;
            }

            set
            {
                usr_complemento = value;
            }
        }

        public string Usr_bairro
        {
            get
            {
                return usr_bairro;
            }

            set
            {
                usr_bairro = value;
            }
        }

        public int Usr_cargo
        {
            get
            {
                return usr_cargo;
            }

            set
            {
                usr_cargo = value;
            }
        }

        public string Usr_usuario
        {
            get
            {
                return usr_usuario;
            }

            set
            {
                usr_usuario = value;
            }
        }

        public string Usr_senha
        {
            get
            {
                return usr_senha;
            }

            set
            {
                usr_senha = value;
            }
        }

        public string Usr_confirmarSenha
        {
            get
            {
                return usr_confirmarSenha;
            }

            set
            {
                usr_confirmarSenha = value;
            }
        }

        public string Usr_email
        {
            get
            {
                return usr_email;
            }

            set
            {
                usr_email = value;
            }
        }

        public int Usr_cidade
        {
            get
            {
                return usr_cidade;
            }

            set
            {
                usr_cidade = value;
            }
        }

        public int Usr_estado
        {
            get
            {
                return usr_estado;
            }

            set
            {
                usr_estado = value;
            }

        }
            public UsuarioDTO() // metodo construtor que inicia as variaveis
        {
            this.Usr_id = 0;
            this.Usr_nome = "";
            this.Usr_cpf = "";
            this.Usr_telefone = "";
            this.Usr_celular = "";
            this.Usr_logradouro = "";
            this.Usr_numero = "";
            this.Usr_complemento = "";
            this.Usr_bairro = "";
            this.Usr_cidade = 0;
            this.Usr_estado = 0;
            this.Usr_cargo = 0;
            this.Usr_usuario = "";
            this.Usr_senha = "";
            this.Usr_confirmarSenha = "";
            this.Usr_email = "";


        }

        public UsuarioDTO(int usr_id, string usr_nome, string usr_cpf, string usr_telefone, string usr_celular, string usr_logradouro, string usr_numero, string usr_complemento, string usr_bairro, int usr_cidade, int usr_estado, int usr_cargo, string usr_usuario, string usr_senha, string usr_confirmarSenha, string usr_email) // metodo construtor para instanciar variaveis
        {
            this.Usr_id = usr_id;
            this.Usr_nome = usr_nome;
            this.usr_cpf = usr_cpf;
            this.usr_telefone = usr_telefone;
            this.usr_celular = usr_celular;
            this.usr_logradouro = usr_logradouro;
            this.usr_numero = usr_numero;
            this.usr_complemento = usr_complemento;
            this.usr_bairro = usr_bairro;
            this.Usr_cidade = usr_cidade;
            this.usr_estado = usr_estado;
            this.usr_cargo = usr_cargo;
            this.usr_usuario = usr_usuario;
            this.usr_senha = usr_senha;
            this.usr_confirmarSenha = usr_confirmarSenha;
            this.usr_email = usr_email;

        }

    
    }//class

}//namespace
