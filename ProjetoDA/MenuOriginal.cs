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

        public ModelOficinaContainer model = new ModelOficinaContainer();
        public Cliente cliente = new Cliente();
        public Carro carro = new Carro();
        public CarroOficina oficina = new CarroOficina();
        //erro
        //public Aluguer aluguer = new Aluguer();
       // public Parcela parcela = new Parcela();
        public Servico servico = new Servico();
        public Venda venda = new Venda();

        List<Aluguer> listAluger = new List<Aluguer>();
        List<Venda> listVenda = new List<Venda>();

        public MenuOriginal()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelHoras.Text = DateTime.Now.ToLongTimeString();

            listAluger = (from IdAluguer in model.Aluguer select IdAluguer).ToList();
            toolStripAluger.Text = listAluger.Count().ToString();

            listVenda = (from IdVenda in model.Venda select IdVenda).ToList();
            toolStripVendas.Text = listVenda.Count().ToString();
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            MenuCliente menuCliente = new MenuCliente(this);
            menuCliente.Show();
        }

        private void button_Oficina_Click(object sender, EventArgs e)
        {
            MenuOficina menuOficina = new MenuOficina(this);
            menuOficina.Show();
        }

        private void button_Venda_Click(object sender, EventArgs e)
        {
            MenuVenda menuVenda = new MenuVenda();
            menuVenda.Show();
        }

        private void button_Aluger_Click(object sender, EventArgs e)
        {
            MenuAluguer menuAluguer = new MenuAluguer(this);
            menuAluguer.Show();
        }
    }
}
