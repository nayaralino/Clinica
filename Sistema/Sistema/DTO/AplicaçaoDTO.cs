// Data de criação 17/02
// Data de modificação 17/02

namespace DTO
    {
        public class AplicaçaoDTO
        {
            private int apl_id;
            private string apl_descriçao;

        
        public AplicaçaoDTO() // metodo construtor que inicia as variaveis
            {
                this.Apl_id = 0;
                this.Apl_descriçao = "";
            }

            public AplicaçaoDTO(int apl_id, string apl_descriçao) // metodo construtor para instanciar variaveis
            {
                this.Apl_id = apl_id;
                this.Apl_descriçao = apl_descriçao;

            }

        public int Apl_id { get => apl_id; set => apl_id = value; }
        public string Apl_descriçao { get => apl_descriçao; set => apl_descriçao = value; }
    }
    }