using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Venda
    {
        public Venda(string valor, string data, int idCliente, int Idcarro)
        {
            this.Valor = valor;
            this.Data = data;
            this.ClienteIdCliente = idCliente;
            this.CarroVenda.IdCarro = Idcarro;
        }

        public override string ToString()
        {
            return "Valor: " + Valor + " Estado: " + Estado + "Data: "+ Data;
        }
    }
}
