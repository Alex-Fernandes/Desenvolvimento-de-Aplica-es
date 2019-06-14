using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class CarroVenda : Carro
    {

        public CarroVenda(string chassi, string marca, string modelo, string combustivel, string extras, int idcarro)
        {
            NumeroChassis = chassi;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;

            Extras = extras;
            IdCarro = idcarro;
        }

        public override string ToString()
        {
            return "Extra: " + Extras + "IdCarro: " + IdCarro;
        }
    }
}
