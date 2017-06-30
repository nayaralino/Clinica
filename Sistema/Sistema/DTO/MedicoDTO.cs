using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação -> 13/02
// Data de revisão -> 14/02

 

namespace DTO
{
    public class MedicoDTO
    {
        private int med_id;
        private string med_nome;
        private string med_crmv;
        private int med_especialidade; //fk
        private string med_logradouro;
        private string med_numero;
        private string med_complemento;
        private string med_bairro;
        private int med_cidade; //fk
        private int med_estado; //fk


        public MedicoDTO() // metodo construtor que inicia as variaveis
        {
            this.Med_id = 0;
            this.Med_nome = "";
            this.Med_crmv= "";
            this.Med_especialidade = 0;
            this.Med_logradouro = "";
            this.Med_numero = "";
            this.Med_complemento = "";
            this.Med_bairro = "";
            this.Med_cidade = 0;
            this.Med_estado = 0;
         
        }

        public MedicoDTO(int med_id, string med_nome, string med_crmv, int med_especialidade, string med_logradouro, string med_numero, string med_complemento, string med_bairro, int med_cidade, int med_estado) // metodo construtor para instanciar variaveis
        {
            this.Med_id = med_id;
            this.Med_nome = med_nome;
            this.Med_crmv = med_crmv;            
            this.Med_especialidade = med_especialidade;
            this.Med_logradouro = med_logradouro;
            this.Med_numero = med_numero;
            this.Med_complemento = med_complemento;
            this.Med_bairro = med_bairro;
            this.Med_cidade = med_cidade;
            this.Med_estado = med_estado;
        }



        public int Med_id
        {
            get
            {
                return med_id;
            }

            set
            {
                med_id = value;
            }
        }

        public string Med_nome
        {
            get
            {
                return med_nome;
            }

            set
            {
                med_nome = value;
            }
        }

        public string Med_crmv
        {
            get
            {
                return med_crmv;
            }

            set
            {
                med_crmv = value;
            }
        }

        public int Med_especialidade
        {
            get
            {
                return med_especialidade;
            }

            set
            {
                med_especialidade = value;
            }
        }

        public string Med_logradouro
        {
            get
            {
                return med_logradouro;
            }

            set
            {
                med_logradouro = value;
            }
        }

        public string Med_numero
        {
            get
            {
                return med_numero;
            }

            set
            {
                med_numero = value;
            }
        }

        public string Med_complemento
        {
            get
            {
                return med_complemento;
            }

            set
            {
                med_complemento = value;
            }
        }

        public string Med_bairro
        {
            get
            {
                return med_bairro;
            }

            set
            {
                med_bairro = value;
            }
        }

        public int Med_cidade
        {
            get
            {
                return med_cidade;
            }

            set
            {
                med_cidade = value;
            }
        }

        public int Med_estado
        {
            get
            {
                return med_estado;
            }

            set
            {
                med_estado = value;
            }
        }

    }//class

}//namespace
