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
		public CriarServico()
		{
			InitializeComponent();
            textBoxDtaEntrada.Text = DateTime.Now.ToString("d/M/yyyy");
            teste.Text = CalendarDtaSaida.SelectionRange.Start.ToShortDateString();
        }

       // Model1Container ModelStand;

        private void buttonCriar_Click(object sender, EventArgs e)
        {
          //  ModelStand = new Model1Container();
            ////ModelStand.Servicos.Add();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

    }
}
