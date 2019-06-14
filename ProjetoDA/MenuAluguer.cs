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
    public partial class MenuAluguer : Form
    {
        private ModelOficinaContainer ModelStand;

        public int IDSelecionado;

        public MenuAluguer(MenuOriginal menu)
        {
            InitializeComponent();
            ModelStand = new ModelOficinaContainer();
            labelDtaAluguer.Text =DateTime.Now.ToString("d/M/yyyy");
            LerDados_Select_Cilente();
            LerAlugados();
        }

        //Ler dados dos Clientes
        private void LerDados_Select_Cilente()
        {
            listBoxClientes.DataSource = ModelStand.Cliente.ToList<Cliente>();
        }

        ///Mostar os carros
        private void LerDados_Carros(int idvalor)
        {
            ModelStand = new ModelOficinaContainer();
            (
                from numero in ModelStand.Carro
                select numero.IdCarro
            ).Load();
            listBoxCarros.DataSource = ModelStand.Carro.Local.ToBindingList();
        }

        private void LerAlugados()
        {
            //Nao existe nehum aluger sem parametros
            ModelStand = new ModelOficinaContainer();
            (
                from id in ModelStand.Aluguer
                select id
            ).Load();
            listBoxCarrosAlugados.DataSource = ModelStand.Aluguer.Local.ToBindingList();
        } 

        //Pesquisa por filtro
		private void btnFiltrar_Click_1(object sender, EventArgs e)
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

        //Preencer as Labels e abrir o ler carros
		private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;

            labelNome.Text = cliente.Nome;
            labelNIF.Text = cliente.NIF;
            labelContacto.Text = cliente.Contacto;
            IDSelecionado = cliente.IdCliente;

            LerDados_Carros(IDSelecionado);
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = listBoxCarros.SelectedItem as CarroAluguer;

            labelMarca_Modelo.Text = carroAluguer.Marca + carroAluguer.Modelo;
            labelMatricula.Text = carroAluguer.NumeroChassis;
            labelCombustivel.Text = carroAluguer.Combustivel;
        }

        //Abrir o Carro Disponivel
        private void button1_Click(object sender, EventArgs e)
        {
            CarroDisponivel carroDisponivel = new CarroDisponivel();
            carroDisponivel.Show();
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = labelNome.Text + ".txt";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("****************************************");
                writer.WriteLine("Cliente: ");
                writer.WriteLine("Nome: " + labelNome.Text + " Nif: " + labelNIF.Text + " Morada: " + labelContacto.Text);
                writer.WriteLine("");
                writer.WriteLine("Dados do Carro: ");
                writer.WriteLine("Marca: " + labelMarca_Modelo.Text + " Matricula: " + labelMatricula.Text + " Combustivel: " + labelCombustivel.Text + " Data Inicio: " + labelDtaAluguer.Text + " Data Final: " + textBoxDtaEntrega.Text);
                writer.WriteLine("");
                writer.WriteLine("Valor:" + textBoxValor.Text);
                writer.WriteLine("****************************************");
                writer.Flush();
                writer.Close();

            }
        }

        
    }
}
