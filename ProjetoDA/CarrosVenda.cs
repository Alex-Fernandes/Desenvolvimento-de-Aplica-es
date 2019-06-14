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
    public partial class CarrosVenda : Form
    {
        private ModelOficinaContainer ModelStand;


        public string IdCarro;
        public string Chassi;
        public string Marca;
        public string Modelo;
        public string Combustivel;

        public CarrosVenda()
        {
            InitializeComponent();
        }

        private void CarrosVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelOficinaDataSet2.Carro' table. You can move, or remove it, as needed.
            this.carroTableAdapter.Fill(this.modelOficinaDataSet2.Carro);

        }
        //Filtrar por nº de  chassi
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

        //Atriguir os valors da grid para as variaveis
        private void carroDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecionado = carroDataGridView.Rows[index];
            IdCarro = selecionado.Cells[0].Value.ToString(); 
            Marca = selecionado.Cells[1].Value.ToString();
            Modelo = selecionado.Cells[2].Value.ToString();
            Chassi = selecionado.Cells[3].Value.ToString();
            Combustivel = selecionado.Cells[4].Value.ToString();
        }

        //para guardar
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelOficinaContainer modelStand = new ModelOficinaContainer();
                int IDCarro = Int32.Parse(IdCarro);

                modelStand.Carro.Add(new CarroVenda(Chassi, Marca, Modelo, Combustivel, textBoxExtras.Text, IDCarro));
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
