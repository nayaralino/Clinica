using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 09/02
// Data de modificação 30/06 - Add datetime e status



namespace DTO
{
    public class AnimalDTO
    {
        private int ani_id;
        private string ani_nome;
        private int ani_sexo;
        private int ani_especie;
        private int ani_raça;
        private string ani_idade;
        private string ani_peso;
        private int ani_cliente;
        private DateTime ani_cadastro;
        private int ani_status;

        public int Ani_id { get => ani_id; set => ani_id = value; }
        public string Ani_nome { get => ani_nome; set => ani_nome = value; }
        public int Ani_sexo { get => ani_sexo; set => ani_sexo = value; }
        public int Ani_especie { get => ani_especie; set => ani_especie = value; }
        public int Ani_raça { get => ani_raça; set => ani_raça = value; }
        public string Ani_idade { get => ani_idade; set => ani_idade = value; }
        public string Ani_peso { get => ani_peso; set => ani_peso = value; }
        public int Ani_cliente { get => ani_cliente; set => ani_cliente = value; }
        public DateTime Ani_cadastro { get => ani_cadastro; set => ani_cadastro = value; }
        public int Ani_status { get => ani_status; set => ani_status = value; }

        public AnimalDTO() // metodo construtor que inicia as variaveis
        {
            this.Ani_id = 0;
            this.Ani_nome = "";
            this.Ani_especie = 0;
            this.Ani_idade = "";
            this.Ani_peso = "";
            this.Ani_sexo = 0;
            this.Ani_cliente = 0;
            this.Ani_raça = 0;
            this.Ani_status = 0;
        }

        public AnimalDTO(int ani_id, string ani_nome, int ani_sexo, int ani_especie, int ani_raça, string ani_idade, string ani_peso, int ani_cliente, int ani_status) // metodo construtor para instanciar variaveis
        {
            this.Ani_id = ani_id;
            this.Ani_nome = ani_nome;
            this.Ani_especie = ani_especie;
            this.Ani_idade = ani_idade;
            this.Ani_peso = ani_peso;
            this.Ani_raça = ani_raça;
            this.Ani_sexo = ani_sexo;
            this.Ani_cliente = ani_cliente;
            this.Ani_status = ani_status;
        }

       
    }//class

}//namespace
 