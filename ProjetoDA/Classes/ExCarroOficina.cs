using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class CarroOficina : Carro
    {
        public List<Servico> ListServico = new List<Servico>();

        public CarroOficina(string chassi,string marca, string modelo, string combustivel,string matricula, string kms, int clienteID, int idcarro)
        {
            NumeroChassis = chassi;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;

            Matricula = matricula;
            Kms = kms;
            ClienteIdCliente = clienteID;
            IdCarro = idcarro;
        }

        public override string ToString()
        {
            return IdCarro + "Matricula: " + Matricula + " -Kms: " + Kms + " -ClienteID: " + ClienteIdCliente + " -Carro: " + IdCarro;
        }
    }
}
