using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Carro
    {
        public override string ToString()
        {
            return  Marca + " - " + Modelo + " - " + NumeroChassis + " - Conbustivel: " + Combustivel;
        }
    }
}
