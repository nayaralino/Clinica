using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 30/06
// Data de alteração 30/06

namespace DTO
{
    public class STAnimalDTO
    {
        private int sta_id;
        private string sta_descriçao;

        public int Sta_id { get => sta_id; set => sta_id = value; }
        public string Sta_descriçao { get => sta_descriçao; set => sta_descriçao = value; }

        public STAnimalDTO() // metodo construtor que inicia as variaveis
        {
            this.Sta_id = 0;
            this.Sta_descriçao = "";

        }

        public STAnimalDTO(int sta_id, string sta_descriçao) // metodo construtor para instanciar variaveis
        {
            this.Sta_id = sta_id;
            this.Sta_descriçao = sta_descriçao;

        }
    }
}
