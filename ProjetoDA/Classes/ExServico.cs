﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Servico : CarroOficina
    {
        public List<Parcela> ListParecela = new List<Parcela>();


        public Servico(string dtaEntrada, string tipo, string dtaSaida, int CarroOficina)
        {
            DataEntrada = dtaEntrada;
            Tipo = tipo;
            DataSaida = dtaSaida;
            CarroOficinaIdCarro = CarroOficina;
        }


        public override string ToString()
        {
            return  CarroOficinaIdCarro + Tipo + " de " + DataEntrada + " a " + DataSaida;
        }

    }
}
