using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Parcela
    {
        //Erro na Parcela
        public Parcela(string desc, string valor, int id)
        {
            this.Descricao = desc;
            this.Valor = valor;
            this.ServicoIdServico = id;
        }

        public override string ToString()
        {
            return "Valor: " + Valor + "Descrição: " + Descricao;
        }
    }
}
