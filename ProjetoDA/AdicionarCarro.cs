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
        public CarroOficina Ofcarro = null;

        public int IdCliente;
        public string Marca;
        public string Modelo;
        public string Combustivel;

        public AdicionarCarro(MenuOficina menuOficina)
        {
            InitializeComponent();

            IdCliente = menuOficina.IDSelecionado;
            textBoxIdCliente.Text = IdCliente.ToString();

        }

        private void AdicionarCarro_Load(object sender, EventArgs e)
        {
            Mostrar_Carros();
        }

        private void Mostrar_Carros()
        {
            ModelStand = new ModelOficinaContainer();
            (
                from carro in ModelStand.Carro
                orderby carro.IdCarro
                select carro
            ).Load();

            //Mostar os carros
            carroBindingSource.DataSource = null;
            carroBindingSource.DataSource = ModelStand.Carro.Local.ToBindingList();
            
        }
         /*
        private void Mostrar_Oficina()
        {
            ModelStand = new ModelOficinaContainer();
            (
                from matricula in ModelStand.Carro.OfType<CarroOficina>()
                orderby matricula.Matricula
                select matricula
            ).Load();

            /*
            carroDataGridView.Columns[0].HeaderText = "Matricula";
            carroDataGridView.Columns[1].HeaderText = "Kms";
            carroDataGridView.Columns[2].HeaderText = "ClienteID";
            carroDataGridView.Columns[3].HeaderText = "IdCarro";
            carroDataGridView.Columns[4].Visible = false;*/
            //Mostar os carros
            /*
            carroDataGridView.Enabled = false;
            carroCarroOficinaBindingSource.DataSource = null;
            carroCarroOficinaBindingSource.DataSource = ModelStand.Carro.Local.ToBindingList();
            
        }*/

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
        

        private void carroDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecionado = carroDataGridView.Rows[index];
            textBoxIdOficina.Text = selecionado.Cells[0].Value.ToString();
            textBoxNumChassi.Text = selecionado.Cells[3].Value.ToString();
            Marca = selecionado.Cells[1].Value.ToString();
            Modelo = selecionado.Cells[2].Value.ToString();
            Combustivel = selecionado.Cells[4].Value.ToString();
        }
       

        public void buttonConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                ModelOficinaContainer modelStand = new ModelOficinaContainer();
                 int IDCarro = Int32.Parse(textBoxIdOficina.Text);

                modelStand.Carro.Add(new CarroOficina(textBoxNumChassi.Text, Marca, Modelo, Combustivel, textBoxNumChassi.Text,textBoxKms.Text, IdCliente, IDCarro));
                modelStand.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

    }
}
