using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
	public partial class MenuVenda : Form
	{
		private ModelOficinaContainer ModelStand;
        public int IDSelecionado;

        public MenuVenda()
		{
			InitializeComponent();
			ModelStand = new ModelOficinaContainer();
			LerDados_Select_Cilente();
		}

        //Mostrar os dado dos clientes
		private void LerDados_Select_Cilente()
		{
			listBoxClientes.DataSource = ModelStand.Cliente.ToList<Cliente>();
		}

        //Pesquisar por nome de cliente
		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			if (textBoxClientes.Text.Length > 0)
			{
				ModelStand.Dispose();
				ModelStand = new ModelOficinaContainer();

				(from cliente in ModelStand.Cliente
				 where cliente.Nome.ToUpper().Contains(textBoxClientes.Text.ToUpper())
				 orderby cliente.Nome
				 select cliente).ToList();

				listBoxClientes.DataSource = ModelStand.Cliente.Local.ToBindingList();
			}
			else
			{
				ModelStand.Dispose();
				ModelStand = new ModelOficinaContainer();

				(from cliente in ModelStand.Cliente
				 orderby cliente.Nome
				 select cliente).Load();

				listBoxClientes.DataSource = ModelStand.Cliente.Local.ToBindingList();
			}
			textBoxClientes.Text = String.Empty;
		}

        //Preencer as Labels
		private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			Cliente cliente = listBoxClientes.SelectedItem as Cliente;

			labelNomeCliente.Text = cliente.Nome;
			labelNIF.Text = cliente.NIF;
			labelContacto.Text = cliente.Contacto;
		}

        private void listBoxCarrosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroVenda carro = listBoxCarrosVenda.SelectedItem as CarroVenda;

            labelMarca_Modelo.Text = carro.Marca + carro.Modelo;
            labelMatricula.Text = carro.NumeroChassis;
            labelCombustivel.Text = carro.Combustivel;
            labelExtra.Text = carro.Extras;
        }

        //Abrir o carros venda
        private void btnCriar_Click(object sender, EventArgs e)
        {
            CarrosVenda carrosVenda = new CarrosVenda();
            carrosVenda.Show();
        }

        //Ir buscar data dos serviços
        private void LerDados_Select_Carros(int IdOfice)
        {
            // nao funciona da erro
            ModelStand = new ModelOficinaContainer();
            (
                from tipo in ModelStand.Venda.OfType<CarroVenda>()
                where tipo.IdCarro.ToString().Contains(IdOfice.ToString())
                select tipo
            ).Load();
            listBoxCarrosVenda.DataSource = ModelStand.Carro.Local.ToBindingList();
        }

        //Ir buscar o id do cliente
        private void listBoxClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;

            labelNomeCliente.Text = cliente.Nome;
            labelNIF.Text = cliente.NIF;
            labelContacto.Text = cliente.Contacto;

            IDSelecionado = cliente.IdCliente;
            LerDados_Select_Carros(IDSelecionado);
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = labelNomeCliente.Text + ".txt";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("****************************************");
                writer.WriteLine("Cliente: ");
                writer.WriteLine("Nome: " + labelNomeCliente.Text + " Nif: " + labelNIF.Text + " Morada: " + labelContacto.Text);
                writer.WriteLine("");
                writer.WriteLine("Dados do Carro: ");
                writer.WriteLine("Marca: " + labelMarca_Modelo.Text + " Matricula: " + labelMatricula.Text + " Combustivel: " + labelCombustivel.Text + " Extra: " + labelExtra.Text);
                writer.WriteLine("****************************************");
                writer.Flush();
                writer.Close();

            }
        }

        
    }
}
