// Data de criação 20/02
// Data de alteração 18/03 - tpate para tipoa

namespace DTO
{
    public class TipoAtendimentoDTO
    {

        private int tpa_id;
        private string tpa_atendimento;

        public int Tpa_id { get => tpa_id; set => tpa_id = value; }
        public string Tpa_atendimento { get => tpa_atendimento; set => tpa_atendimento = value; }

        public TipoAtendimentoDTO() // metodo construtor que inicia as variaveis
        {
            this.Tpa_id = 0;
            this.Tpa_atendimento = "";

        }

        public TipoAtendimentoDTO(int tpa_id, string tpa_atendimento) // metodo construtor para instanciar variaveis
        {
            this.Tpa_id = tpa_id;
            this.Tpa_atendimento = tpa_atendimento;

        }

        
    }
}
