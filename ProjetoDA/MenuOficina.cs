using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjetoDA
{
    public partial class MenuOficina : Form
    {
        private Model1Container ModelStand;

        public MenuOficina()
        {

            InitializeComponent();
            ModelStand = new Model1Container();
            LerDados_Select_Cilente();

        }

        private void LerDados_Select_Cilente()
        {
            ModelStand = new Model1Container();

             (
                from Cliente in ModelStand.Clientes
                orderby Cliente.Nome
                select Cliente
             ).Load();

            /*
            List<string> _names = (from p in context.RakHolders select p.Name)
    .ToList()
    .Select(name => name.Split(','))
    .Select(nameSplitted => string.Format("{0},{1}", nameSplitted[0].Trim(), nameSplitted[1].Trim()))
    .ToList();*/

            //listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.Local.ToBindingList();
            listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.ToList<Cliente>();
            clienteDataGridView.DataSource = ModelStand.Clientes.ToList<Cliente>();
        }

    }
}
