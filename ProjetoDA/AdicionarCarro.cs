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
		private ModelOficinaContainer ModelStand;

        public AdicionarCarro()
        {
            InitializeComponent();

		    ModelStand = new ModelOficinaContainer();
			(
				from carro in ModelStand.Carro
				orderby carro.NumeroChassis
				select carro
			).Load();

        
            //Mostar os carros
			carroBindingSource.DataSource = ModelStand.Carro.Local.ToBindingList();
		}
        
        //Botao para guardar
        private void carroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            ModelStand.SaveChanges();
        }


        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            /* Nao retirar 
             * err0
             */

        }

        //Pesquisar pelo numero de chassi pelos Carros
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;

                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (from carro in ModelStand.Carro
                 where carro.NumeroChassis.ToUpper().Contains(textBoxFiltrar.Text.ToUpper())
                 orderby carro.NumeroChassis
                 select carro).ToList();

                carroBindingSource.DataSource = ModelStand.Carro.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;

                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (
                    from carro in ModelStand.Carro
                    orderby carro.NumeroChassis
                    select carro
                ).Load();

                carroBindingSource.DataSource = ModelStand.Cliente.Local.ToBindingList();
            }
        }

        //Ghost texto se nao clicar ou se clicar noutro sitio aparece 
        private void textBoxFiltrar_Enter(object sender, EventArgs e)
        {
            if (textBoxFiltrar.Text == "Introduza o numero de Chassi")
            {
                textBoxFiltrar.Text = "";
            }
        }

        //Ghost texto ao clicar desaparece
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
