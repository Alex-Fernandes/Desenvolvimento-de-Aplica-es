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
            LerDados_Select_Carros();

        }

        //Ir buscar data dos Clientes
        private void LerDados_Select_Cilente()
        {
            listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.ToList<Cliente>();
        }

        //Ir buscar data dos Carros
        private void LerDados_Select_Carros()
        {
            listBoxCarro_Oficina.DataSource = ModelStand.Carros.ToList<Carro>();
        }

        //Mostrar os dados do utilzador nas labels
        private void listBoxSelecionar_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxSelecionar_Cliente.SelectedItem as Cliente;

            label_nomeCliente.Text = cliente.Nome;
            label_NifCliente.Text = cliente.NIF;
            label_TelefoneCliente.Text = cliente.Contacto;
            label_MoradaCliente.Text = cliente.Morada;
        }

        //Mudar para o adicionar carro
        private void buttonOficina_adicionar_Click(object sender, EventArgs e)
        {
            AdicionarCarro adicionarCarro = new AdicionarCarro();
            adicionarCarro.Show();
        }

        //Pesquisar por nome pelos Clientes
        private void buttonClientePesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxClientePesquisar.Text.Length > 0)
            {
                ModelStand.Dispose();
                ModelStand = new Model1Container();

                (from cliente in ModelStand.Clientes
                 where cliente.Nome.ToUpper().Contains(textBoxClientePesquisar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.Local.ToBindingList();
            }
            else
            {
                ModelStand.Dispose();
                ModelStand = new Model1Container();

                (from cliente in ModelStand.Clientes
                 orderby cliente.Nome
                 select cliente).Load();

                listBoxSelecionar_Cliente.DataSource = ModelStand.Clientes.Local.ToBindingList();
            }
        }

        //Fazer reload da listbox dos carros para ser atualizada quando o ultilizador sai do AdicionarCarro
        private void MenuOficina_Activated(object sender, EventArgs e)
        {
            LerDados_Select_Carros();
        }

        private void buttonParecelas_Criar_Click(object sender, EventArgs e)
        {
            //Guardar numa list a descriçao o valor introduzido
            List<string> ListParecelas = new List<string>();
            ListParecelas.Add(textBoxParecelas_Descricao.Text + " - " + textBoxParecelas_Valor.Text + "€");

            foreach (string introducao in ListParecelas) {
                listBoxParecelas.Items.Add(introducao);
            }

            //Apagar a textBox
            textBoxParecelas_Descricao.Text = "";
            textBoxParecelas_Valor.Text = "";
        }

        private void buttonServicos_Criar_Click(object sender, EventArgs e)
        {
            CriarServico criarServico = new CriarServico();
            criarServico.Show();
        }
    }
}
