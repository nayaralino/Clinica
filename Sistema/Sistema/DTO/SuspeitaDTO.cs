// Data de criação 18/03
// Data de modificação 18/03

namespace DTO
{
    public class SuspeitaDTO
    {
        private int sus_id;
        private int sus_atendimento;
        private string sus_suspeita;

        public int Sus_id
        {
            get
            {
                return sus_id;
            }

            set
            {
                sus_id = value;
            }
        }

        public int Sus_atendimento
        {
            get
            {
                return sus_atendimento;
            }

            set
            {
                sus_atendimento = value;
            }
        }

        public string Sus_suspeita
        {
            get
            {
                return sus_suspeita;
            }

            set
            {
                sus_suspeita = value;
            }
        }

        public SuspeitaDTO() // metodo construtor que inicia as variaveis
        {
            this.Sus_id = 0;
            this.Sus_atendimento = 0;
            this.Sus_suspeita = "";
        }

        public SuspeitaDTO(int sus_id, int sus_atendimento, string sus_suspeita) // metodo construtor para instanciar variaveis
        {
            this.Sus_id = sus_id;
            this.Sus_atendimento = sus_atendimento;
            this.Sus_suspeita = sus_suspeita;

        }
    }
}
