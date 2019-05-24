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
            listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.ToList<Cliente>();
        }

        private void listBoxSelecionar_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxSelecionar_Cliente.SelectedItem as Cliente;

            label_nomeCliente.Text = cliente.Nome;
            label_NifCliente.Text = cliente.NIF;
            label_TelefoneCliente.Text = cliente.Contacto;
            label_MoradaCliente.Text = cliente.Morada;
        }
    }
}
