using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class CarroAluguer : Carro
    {
       
        public CarroAluguer(string chassi, string marca, string modelo, string combustivel, string estado, string matricula,int idcarro)
        {
            NumeroChassis = chassi;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;

            Estado = estado;
            Matricula = matricula;
            IdCarro = idcarro;
        }

        public override string ToString()
        {
            return "Estado: " + Estado + "Matricula: " + Matricula + "IdCarro" + IdCarro;
        }
    }
}
