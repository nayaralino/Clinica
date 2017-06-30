using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CidadeDTO
    {
        private int cid_id;
        private string cid_cidade;

        public int Cid_id
        {
            get
            {
                return cid_id;
            }

            set
            {
                cid_id = value;
            }
        }

        public string Cid_cidade
        {
            get
            {
                return cid_cidade;
            }

            set
            {
                cid_cidade = value;
            }
        }

        public CidadeDTO() // metodo construtor que inicia as variaveis
        {
            this.Cid_id = 0;
            this.Cid_cidade = "";

        }

        public CidadeDTO(int cid_id, string cid_cidade) // metodo construtor para instanciar variaveis
        {
            this.Cid_id = cid_id;
            this.Cid_cidade = cid_cidade;
        }
    }
}
