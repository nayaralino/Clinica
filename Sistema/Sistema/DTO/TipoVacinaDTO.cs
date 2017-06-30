// Data de criação 21/03
// Data de alteração 21/03

namespace DTO
{
    public class TipoVacinaDTO
    {
        private int tpv_id;
        private string tpv_descriçao;

        public int Tpv_id { get => tpv_id; set => tpv_id = value; }
        public string Tpv_descriçao { get => tpv_descriçao; set => tpv_descriçao = value; }

        public TipoVacinaDTO() // metodo construtor que inicia as variaveis
        {
            this.Tpv_id = 0;
            this.Tpv_descriçao = "";
        }

        public TipoVacinaDTO(int tpv_id, string tpv_descriçao) // metodo construtor para instanciar variaveis
        {
            this.Tpv_id = tpv_id;
            this.Tpv_descriçao = tpv_descriçao;
        }

    }
}