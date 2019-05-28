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
    public partial class AdicionarCarro : Form
    {
		private Model1Container ModelStand;

        public AdicionarCarro()
        {
            InitializeComponent();

		    ModelStand = new Model1Container();
			(
				from carro in ModelStand.Carros
				orderby carro.NumeroChassis
				select carro
			).Load();

			carroBindingSource.DataSource = ModelStand.Carros.Local.ToBindingList();
		}
        
		private void carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			ModelStand.SaveChanges();
		}


        private void carroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            ModelStand.SaveChanges();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                ModelStand.Dispose();
                ModelStand = new Model1Container();

                (from carro in ModelStand.Carros
                 where carro.NumeroChassis.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                 orderby carro.NumeroChassis
                 select carro).ToList();

                carroBindingSource.DataSource = ModelStand.Carros.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                ModelStand.Dispose();
                ModelStand = new Model1Container();

                (
                    from carro in ModelStand.Carros
                    orderby carro.NumeroChassis
                    select carro
                ).Load();

                carroBindingSource.DataSource = ModelStand.Clientes.Local.ToBindingList();
            }
        }

        private void textBoxFiltrar_Enter(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text == "Introduza o numero de Chassi")
            {
                textBoxFiltrar.Text = "";
            }
        }

        private void textBoxFiltrar_Leave(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text == "")
            {
                textBoxFiltrar.Text = "Introduza o numero de Chassi";
                textBoxFiltrar.ForeColor = Color.Black;
            }
        }
    }
}
