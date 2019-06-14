using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class MenuCliente : Form
    {
        private ModelOficinaContainer ModelStand;
        public Cliente cliente;
        List<Cliente> listClientes = new List<Cliente>();

        public MenuCliente(MenuOriginal menu)
        {
            InitializeComponent();
            ModelStand = menu.model;
                       
            ModelStand = new ModelOficinaContainer();
            (
                from cliente in ModelStand.Cliente
                orderby cliente.Nome
                select cliente
            ).Load();

            cliente = menu.cliente;
        }

        //Carregar os clientes
        private void MenuCliente_Load(object sender, EventArgs e)
        { 
            try
            {
                clienteBindingSource.DataSource = ModelStand.Cliente.Local.ToBindingList();
                // a maneira com objetos
                //cliente = clienteDataGridView.CurrentRow.DataBoundItem as Cliente;
                ///// a maneira com list
                //listClientes = (from matricula in ModelStand.Carro.OfType<CarroOficina>() select matricula).ToList();
                //clienteDataGridView.DataSource = listClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clientes "+ ex);
            }
        }
        //Guardar os dados
        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ModelStand.SaveChanges();
        }

        //Pesquisa por nome
        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (from cliente in ModelStand.Cliente
                 where cliente.Nome.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                clienteBindingSource.DataSource = ModelStand.Cliente.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (from cliente in ModelStand.Cliente
                 orderby cliente.Nome
                 select cliente).Load();

                clienteBindingSource.DataSource = ModelStand.Cliente.Local.ToBindingList();
            }
            textBoxFiltrar.Text = String.Empty;
        }


    }
}