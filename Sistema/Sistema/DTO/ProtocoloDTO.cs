// Data de criação 17/02
// Data de modificação 17/02

namespace DTO
{
    public class ProtocoloDTO
    {
        private int prot_id;
        private int prot_atendimento;
        private int prot_tipo;
        private int prot_aplicaçao;
        private string prot_data;
        private string prot_intervalo;

        public int Prot_id
        {
            get
            {
                return prot_id;
            }

            set
            {
                prot_id = value;
            }
        }

        public int Prot_atendimento
        {
            get
            {
                return prot_atendimento;
            }

            set
            {
                prot_atendimento = value;
            }
        }

        public int Prot_tipo
        {
            get
            {
                return prot_tipo;
            }

            set
            {
                prot_tipo = value;
            }
        }

        public int Prot_aplicaçao
        {
            get
            {
                return prot_aplicaçao;
            }

            set
            {
                prot_aplicaçao = value;
            }
        }

        public string Prot_data
        {
            get
            {
                return prot_data;
            }

            set
            {
                prot_data = value;
            }
        }

        public string Prot_intervalo
        {
            get
            {
                return prot_intervalo;
            }

            set
            {
                prot_intervalo = value;
            }
        }

        public ProtocoloDTO() // metodo construtor que inicia as variaveis
        {
            this.Prot_id = 0;
            this.Prot_id = 0;
            this.Prot_atendimento = 0;
            this.Prot_tipo = 0;
            this.Prot_aplicaçao = 0;
            this.Prot_data = "";
            this.Prot_intervalo = "";

        }

        public ProtocoloDTO(int tipop_id, int prot_atendimento, int prot_tipo, int prot_aplicaçao, string prot_data, string prot_intervalo) // metodo construtor para instanciar variaveis
        {
            this.Prot_id = prot_id;
            this.Prot_atendimento = prot_atendimento;
            this.Prot_tipo = prot_tipo;
            this.Prot_aplicaçao = prot_aplicaçao;
            this.Prot_data = prot_data;
            this.Prot_intervalo = prot_intervalo;

        }


    }
}
