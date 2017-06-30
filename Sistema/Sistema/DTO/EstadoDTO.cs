using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 14/02
// Data de modificação 14/02

namespace DTO
{
    public class EstadoDTO
    {
        private int est_id;
        private string est_estado;

        public int Est_id
        {
            get
            {
                return est_id;
            }

            set
            {
                est_id = value;
            }
        }

        public string Est_estado
        {
            get
            {
                return est_estado;
            }

            set
            {
                est_estado = value;
            }
        }

        public EstadoDTO() // metodo construtor que inicia as variaveis
        {
            this.Est_id = 0;
            this.Est_estado = "";

        }

        public EstadoDTO(int est_id, string est_estado) // metodo construtor para instanciar variaveis
        {
            this.Est_id = est_id;
            this.Est_estado = est_estado;
        }
    }
}
