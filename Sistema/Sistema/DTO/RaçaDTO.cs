using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 09/02
// Data de modificação 09/02
// 1- Cria os atributos privados | 2 - ctrl + r + e - gerar os gets/sets | 
// Data de modificação 11/02
// estava errado o raça dto estava recebendo esp 
// coloquei o fk esp_id


namespace DTO
{
    public class RaçaDTO
    {
        private int raç_id;
        private string raç_descriçao;
        private int raç_especie;

        public int Raç_id { get => raç_id; set => raç_id = value; }
        public string Raç_descriçao { get => raç_descriçao; set => raç_descriçao = value; }
        public int Raç_especie { get => raç_especie; set => raç_especie = value; }

        public RaçaDTO() // metodo construtor que inicia as variaveis
        {
            this.Raç_id = 0;
            this.Raç_descriçao = "";
            this.Raç_especie = 0;


        }

        public RaçaDTO(int raç_id, string raç_descriçao, int raç_especie) // metodo construtor para instanciar variaveis
        {
            this.Raç_id = raç_id;
            this.Raç_descriçao = raç_descriçao;
            this.Raç_especie = raç_especie;

        }

        
    }//class

}//namespace