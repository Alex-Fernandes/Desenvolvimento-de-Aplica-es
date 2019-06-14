using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Carro
    {
        public List<CarroOficina> ListCarroOficina = new List<CarroOficina>();
        public List<CarroVenda> ListCarroVenda = new List<CarroVenda>();
        public List<CarroAluguer> ListCarroAluguer = new List<CarroAluguer>();

        /*
        public Carro( string chassi,string marca, string modelo, string combustivel)
        {
            NumeroChassis = chassi;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
        }

        */
        public override string ToString()
        {
            return  Marca + " - " + Modelo + " - " + NumeroChassis + " - Conbustivel: " + Combustivel;
        }
    }
}
