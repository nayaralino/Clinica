using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Modelo de Dados - DTO (Modelo) // OK
// 1- Cria os atributos privados | 2 - ctrl + r + e - gerar os gets/sets | 

// Data de criação 13/02
// Data de modificação 14/02



namespace DTO
{
    public class ClienteDTO
    {
        private int cli_id;
        private string cli_nome;
        private string cli_cpf;
        private string cli_telefone;
        private string cli_celular;
        private string cli_email;
        private string cli_logradouro;
        private string cli_numero;
        private string cli_complemento;
        private string cli_bairro;
        private int cli_cidade;
        private int cli_estado;
        private DateTime cli_cadastro;

        public int Cli_id { get => cli_id; set => cli_id = value; }
        public string Cli_nome { get => cli_nome; set => cli_nome = value; }
        public string Cli_cpf { get => cli_cpf; set => cli_cpf = value; }
        public string Cli_telefone { get => cli_telefone; set => cli_telefone = value; }
        public string Cli_celular { get => cli_celular; set => cli_celular = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }
        public string Cli_logradouro { get => cli_logradouro; set => cli_logradouro = value; }
        public string Cli_numero { get => cli_numero; set => cli_numero = value; }
        public string Cli_complemento { get => cli_complemento; set => cli_complemento = value; }
        public string Cli_bairro { get => cli_bairro; set => cli_bairro = value; }
        public int Cli_cidade { get => cli_cidade; set => cli_cidade = value; }
        public int Cli_estado { get => cli_estado; set => cli_estado = value; }
        public DateTime Cli_cadastro { get => cli_cadastro; set => cli_cadastro = value; }
    
    }//class

}//namespace
