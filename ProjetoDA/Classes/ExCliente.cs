using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Cliente
    {
        public List<Carro> ListCarro = new List<Carro>();
        
        
        public Cliente(string nome, string nif, string morada, string contacto)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.Morada = morada;
            this.Contacto = contacto;
        }

        public override string ToString() 
        {
            return "Nome: " + Nome + " - NIF: " + NIF;
        }
    
    }
}
