// Data de criação 21/02
// Data de alteração 15/03 - adicionei o tipo exame e coloquei o exame com o atendimento

namespace DTO
{
    public class ExameDTO
    {
        private int exame_id;
        private string exame_atendimento;
        private string exame_dtSolicitaçao;
        private string exame_dtResultado;
        private string exame_tipo;
        private string exame_resultado;
        private string exame_laboratorio;

        public string Exame_atendimento
        {
            get
            {
                return exame_atendimento;
            }

            set
            {
                exame_atendimento = value;
            }
        }

        public string Exame_dtSolicitaçao
        {
            get
            {
                return exame_dtSolicitaçao;
            }

            set
            {
                exame_dtSolicitaçao = value;
            }
        }

        public string Exame_tipo
        {
            get
            {
                return exame_tipo;
            }

            set
            {
                exame_tipo = value;
            }
        }

        public string Exame_resultado
        {
            get
            {
                return exame_resultado;
            }

            set
            {
                exame_resultado = value;
            }
        }

        public int Exame_id
        {
            get
            {
                return exame_id;
            }

            set
            {
                exame_id = value;
            }
        }

        public string Exame_laboratorio
        {
            get
            {
                return exame_laboratorio;
            }

            set
            {
                exame_laboratorio = value;
            }
        }

        public string Exame_dtResultado
        {
            get
            {
                return exame_dtResultado;
            }

            set
            {
                exame_dtResultado = value;
            }
        }

        public ExameDTO() // metodo construtor que inicia as variaveis
        {
            this.Exame_id = 0;
            this.Exame_atendimento = "";
            this.Exame_dtSolicitaçao = "";
            this.Exame_dtResultado = "";
            this.Exame_tipo  = "";
            this.Exame_laboratorio = "";
            this.Exame_resultado = "";

        }

        // metodo construtor para instanciar variaveis
        public ExameDTO(int exame_id, string exame_atendimento, string exame_dtSolicitaçao, string exame_dtResultado, string exame_tipo , string exame_laboratorio, string exame_resultado) 
        {
            this.Exame_id = exame_id;
            this.Exame_atendimento = exame_atendimento;
            this.Exame_dtSolicitaçao = exame_dtSolicitaçao;
            this.Exame_dtResultado = exame_dtResultado;
            this.Exame_tipo  = exame_tipo ;
            this.Exame_laboratorio = exame_laboratorio;
            this.Exame_resultado = exame_resultado;
        }
    }
}
