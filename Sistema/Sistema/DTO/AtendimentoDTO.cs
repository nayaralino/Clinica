using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AtendimentoDTO
    {
        private int ate_id;
        private int ate_animal;
        private int ate_cliente;
        private int ate_medico;
        private int ate_tipo;
        private string ate_data;
        private string ate_hora;
        private string ate_anamnese;
        private string ate_tratamento;

        public int Ate_id
        {
            get
            {
                return ate_id;
            }

            set
            {
                ate_id = value;
            }
        }

        public int Ate_animal
        {
            get
            {
                return ate_animal;
            }

            set
            {
                ate_animal = value;
            }
        }

        public int Ate_cliente
        {
            get
            {
                return ate_cliente;
            }

            set
            {
                ate_cliente = value;
            }
        }

        public int Ate_medico
        {
            get
            {
                return ate_medico;
            }

            set
            {
                ate_medico = value;
            }
        }

        public int Ate_tipo
        {
            get
            {
                return ate_tipo;
            }

            set
            {
                ate_tipo = value;
            }
        }

        public string Ate_data
        {
            get
            {
                return ate_data;
            }

            set
            {
                ate_data = value;
            }
        }

        public string Ate_hora
        {
            get
            {
                return ate_hora;
            }

            set
            {
                ate_hora = value;
            }
        }


        public string Ate_anamnese
        {
            get
            {
                return ate_anamnese;
            }

            set
            {
                ate_anamnese = value;
            }
        }

        public string Ate_tratamento
        {
            get
            {
                return ate_tratamento;
            }

            set
            {
                ate_tratamento = value;
            }
        }

    

        public AtendimentoDTO() // metodo construtor que inicia as variaveis
        {
            this.Ate_id = 0;
            this.Ate_animal = 0;
            this.Ate_cliente = 0;
            this.Ate_medico = 0;
            this.Ate_tipo = 0;
            this.Ate_data = "";
            this.Ate_hora = "";
            this.Ate_anamnese = "";
            this.Ate_tratamento = ""; 
        
        }

        public AtendimentoDTO(int ate_id, int ate_animal, int ate_cliente, int ate_medico, int ate_tipo, string ate_data, string ate_hora, string ate_anamnese, string ate_tratamento) // metodo construtor para instanciar variaveis
        {
            this.Ate_id = ate_id;
            this.Ate_animal = ate_animal;
            this.Ate_cliente = ate_cliente;
            this.Ate_medico = ate_medico;
            this.Ate_tipo = ate_tipo;
            this.Ate_data = ate_data;
            this.Ate_hora = ate_hora;
            this.Ate_anamnese = ate_anamnese;
            this.Ate_tratamento = ate_tratamento;
           
        }
    }
}
