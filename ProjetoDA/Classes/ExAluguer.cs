using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Aluguer
    {
        public Aluguer(string dtaINicio, string dtaFim, string valor, string kms, int idCliente, int idCarro)
        {
            this.DataInicio = dtaINicio;
            this.DataFim = dtaFim;
            this.Kms = kms;
            this.ClienteIdCliente = idCliente;
            this.CarroAluguer.IdCarro = idCarro;
        }

        public override string ToString()
        {
            return "Dta: " + DataInicio + " Dta Fim: " + DataFim + " Valor " + Valor + " Kms " + Kms;
        }
    }
}
