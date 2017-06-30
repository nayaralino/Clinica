// Data de criação 17/02
// Data de modificação 17/02

namespace DTO
{
    public class TipoProtocoloDTO
    {
        private int tipop_id;
        private string tipop_descriçao;

        public int Tipop_id
        {
            get
            {
                return tipop_id;
            }

            set
            {
                tipop_id = value;
            }
        }

        public string Tipop_descriçao
        {
            get
            {
                return tipop_descriçao;
            }

            set
            {
                tipop_descriçao = value;
            }
        }

        public TipoProtocoloDTO() // metodo construtor que inicia as variaveis
        {
            this.Tipop_id = 0;
            this.Tipop_descriçao = "";
        }

        public TipoProtocoloDTO(int tipop_id, string tipop_descriçao) // metodo construtor para instanciar variaveis
        {
            this.Tipop_id = tipop_id;
            this.Tipop_descriçao = tipop_descriçao;

        }
    }
}











