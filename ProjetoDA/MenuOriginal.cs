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
    public partial class MenuOriginal : Form
    {
        public MenuOriginal()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelHoras.Text = DateTime.Now.ToLongTimeString();
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente();
            menuCliente.Show();
        }

        private void button_Oficina_Click(object sender, EventArgs e)
        {
            MenuOficina menuOficina = new MenuOficina();
            menuOficina.Show();
        }
    }
}
