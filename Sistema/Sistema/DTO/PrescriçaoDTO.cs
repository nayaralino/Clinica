// Data de criação 17/03
// Data de modificação 17/03

namespace DTO
{
    public class PrescriçaoDTO
    {
        private int pres_id;
        private int pres_atendimento;
        private string pres_prescriçao;

        public int Pres_id
        {
            get
            {
                return pres_id;
            }

            set
            {
                pres_id = value;
            }
        }

        public int Pres_atendimento
        {
            get
            {
                return pres_atendimento;
            }

            set
            {
                pres_atendimento = value;
            }
        }

        public string Pres_prescriçao
        {
            get
            {
                return pres_prescriçao;
            }

            set
            {
                pres_prescriçao = value;
            }
        }

        public PrescriçaoDTO() // metodo construtor que inicia as variaveis
        {
            this.Pres_id = 0;
            this.Pres_atendimento = 0;
            this.Pres_prescriçao = "";
        }

        public PrescriçaoDTO(int pres_id, int pres_atendimento, string pres_prescriçao) // metodo construtor para instanciar variaveis
        {
            this.Pres_id = pres_id;
            this.Pres_atendimento = pres_atendimento;
            this.Pres_prescriçao = pres_prescriçao;

        }
    }
}
