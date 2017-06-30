using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 13-02
// Data de modificação 13-02

namespace DTO
{
    public class EspecialidadeDTO
    {
        private int espec_id;
        private string espec_especialidade;

        public int Espec_id
        {
            get
            {
                return espec_id;
            }

            set
            {
                espec_id = value;
            }
        }

        public string Espec_especialidade
        {
            get
            {
                return espec_especialidade;
            }

            set
            {
                espec_especialidade = value;
            }
        }

        public EspecialidadeDTO() // metodo construtor que inicia as variaveis
        {
            this.Espec_id = 0;
            this.Espec_especialidade = "";

        }

        public EspecialidadeDTO(int espec_id, string espec_especialidade) // metodo construtor para instanciar variaveis
        {
            this.Espec_id = espec_id;
            this.Espec_especialidade = espec_especialidade;
        }


    }//class

}//namespace