using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Data de criação 18/02
// Data de alteração 18/02


namespace DTO
{
    public class CargoDTO
    {
        private int car_id;
        private string car_cargo;

        public int Car_id
        {
            get
            {
                return car_id;
            }

            set
            {
                car_id = value;
            }
        }

        public string Car_cargo
        {
            get
            {
                return car_cargo;
            }

            set
            {
                car_cargo = value;
            }
        }

        public CargoDTO() // metodo construtor que inicia as variaveis
        {
            this.Car_id = 0;
            this.Car_cargo = "";

        }

        public CargoDTO(int car_id, string car_cargo) // metodo construtor para instanciar variaveis
        {
            this.Car_id = car_id;
            this.Car_cargo = car_cargo;

        }

    }
}
