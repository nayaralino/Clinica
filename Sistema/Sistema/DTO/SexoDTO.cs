using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 09/02
// Data de modificação 09/02

namespace DTO
{
    public class SexoDTO
    {
        private int sexo_id;
        private string sexo_nome;


        public SexoDTO() // metodo construtor que inicia as variaveis
        {
            this.Sexo_id = 0;
            this.Sexo_nome = "";

        }

        public SexoDTO(int sexo_id, string sexo_nome) // metodo construtor para instanciar variaveis
        {
            this.Sexo_id = sexo_id;
            this.Sexo_nome = sexo_nome;

        }

        public int Sexo_id
        {
            get
            {
                return sexo_id;
            }

            set
            {
                sexo_id = value;
            }
        }

        public string Sexo_nome
        {
            get
            {
                return sexo_nome;
            }

            set
            {
                sexo_nome = value;
            }
        }
    }//class
}//namespace
