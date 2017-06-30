// Data de criação 21/02
// Data de alteração 15/03 - adicionei o tipo exame e coloquei o exame com o atendimento

namespace DTO
{
    public class TipoExameDTO
    {
        private int tpe_id;
        private string tpe_descriçao;

        public int Tpe_id { get => tpe_id; set => tpe_id = value; }
        public string Tpe_descriçao { get => tpe_descriçao; set => tpe_descriçao = value; }

        public TipoExameDTO() // metodo construtor que inicia as variaveis
        {
            this.Tpe_id = 0;
            this.Tpe_descriçao = "";

        }

        public TipoExameDTO(int tpe_id, string tpe_descriçao) // metodo construtor para instanciar variaveis
        {
            this.Tpe_id = tpe_id;
            this.Tpe_descriçao = tpe_descriçao;

        }

        
    }
}