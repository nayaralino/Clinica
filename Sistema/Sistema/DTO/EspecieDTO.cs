using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Modelo de Dados - DTO (Modelo) // OK
// 1- Cria os atributos privados | 2 - ctrl + r + e - gerar os gets/sets | 

namespace DTO
{
    public class EspecieDTO
    {
        private int esp_id;
        private string esp_descriçao;

        public EspecieDTO() // metodo construtor que inicia as variaveis
        {
            this.Esp_id = 0;
            this.Esp_descriçao = "";
            

        }

        public EspecieDTO(int esp_id, string esp_descriçao) // metodo construtor para instanciar variaveis
        {
            this.Esp_id = esp_id;
            this.Esp_descriçao = esp_descriçao;
           
        }

        public int Esp_id
        {
            get
            {
                return esp_id;
            }

            set
            {
                esp_id = value;
            }
        }

        public string Esp_descriçao
        {
            get
            {
                return esp_descriçao;
            }

            set
            {
                esp_descriçao = value;
            }
        }
    
    }//class
}//namespace
