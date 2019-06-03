using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Servico
    {
        
        public Servico(int id, string dtaEntrada, string tipo, string dtaSaida,string idCarro)
        {
            IdServico = id;
            DataEntrada = dtaEntrada;
            Tipo = tipo;
            DataSaida = dtaSaida;
            //CarroOficinaIdCarroOficina = idCarro;
        }

    }
}
