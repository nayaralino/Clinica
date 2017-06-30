// Data de criação 21/02
// Data de alteração 21/03 - alterei a estrutura no banco, alterei aqui para comportar o atendimento

namespace DTO
{
    public class VacinaDTO
    {
        private int vac_id;
        private string vac_atendimento;
        private int vac_tipo;
        private int vac_aplicaçao;
        private string vac_data;
        private string vac_intervalo;

        public int Vac_id { get => vac_id; set => vac_id = value; }
        public string Vac_atendimento { get => vac_atendimento; set => vac_atendimento = value; }
        public int Vac_tipo { get => vac_tipo; set => vac_tipo = value; }
        public int Vac_aplicaçao { get => vac_aplicaçao; set => vac_aplicaçao = value; }
        public string Vac_data { get => vac_data; set => vac_data = value; }
        public string Vac_intervalo { get => vac_intervalo; set => vac_intervalo = value; }
        

        public VacinaDTO() // metodo construtor que inicia as variaveis
        {
            this.Vac_id = 0;
            this.Vac_atendimento = "";
            this.Vac_aplicaçao = 0;
            this.Vac_data = "";
            this.Vac_tipo = 0;
            this.Vac_intervalo = "";
        }

        public VacinaDTO(int vac_id, string vac_vacina) // metodo construtor para instanciar variaveis
        {
            this.Vac_id = vac_id;
            this.Vac_atendimento = vac_atendimento;
            this.Vac_aplicaçao = vac_aplicaçao;
            this.Vac_data = vac_data;
            this.Vac_tipo = vac_tipo;
            this.Vac_intervalo = vac_intervalo;
        }
    }
}
