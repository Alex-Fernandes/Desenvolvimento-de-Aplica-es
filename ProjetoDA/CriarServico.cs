using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
	public partial class CriarServico : Form
	{
        private ModelOficinaContainer ModelStand;
        public int CarroId;

        public CriarServico(MenuOficina menuOficina)
		{
			InitializeComponent();
            textBoxDtaEntrada.Text = DateTime.Now.ToString("d/M/yyyy");
            CarroId = menuOficina.OficinaIDSelecionado;
        }

        //guardar
        private void buttonCriar_Click(object sender, EventArgs e)
        {
            ModelStand = new ModelOficinaContainer();
            ModelStand.Servicos.Add(new Servico(textBoxDtaEntrada.Text, textBoxTipoServico.Text, labelDtaSaida.Text, CarroId));
            ModelStand.SaveChanges();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //para mostrar a data selecionada pelo utilizador
        private void CalendarDtaSaida_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelDtaSaida.Text = CalendarDtaSaida.SelectionRange.Start.ToShortDateString();
        }
    }
}
