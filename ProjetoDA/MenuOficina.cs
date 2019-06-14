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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Try-Catch apanhar o erro e explicar para se poder perceber, foi retirado da internet 
//Link: https://www.c-sharpcorner.com/UploadFile/97fc7a/validation-failed-for-one-or-more-entities-mvcentity-frame/
//Autor: Sachin Kalia

namespace ProjetoDA
{
    public partial class MenuOficina : Form
    {
        private ModelOficinaContainer ModelStand;
        public Cliente cliente = null;
        public CarroOficina carroOficina = null;
        public Carro carro= null;

        public int IDSelecionado;
        public int OficinaIDSelecionado;
        public int ServicoID;

        public MenuOficina(MenuOriginal menu)
        {
            
            InitializeComponent();
            ModelStand = new ModelOficinaContainer();
            carroOficina = menu.oficina;
            LerDados_Select_Cilente();

        }

        //Ir buscar data dos Clientes
        private void LerDados_Select_Cilente()
        {
            listBoxSelecionar_Cliente.DataSource = ModelStand.Cliente.ToList<Cliente>();
        }

        //Ir buscar data dos Carros Oficina
        private void LerDados_Select_Carros()
        {
            ModelStand = new ModelOficinaContainer();
            (
                from matricula in ModelStand.Carro.OfType<CarroOficina>()
                where matricula.ClienteIdCliente.ToString().Contains(IDSelecionado.ToString())
                select matricula
            ).Load();
            listBoxCarro_Oficina.DataSource = ModelStand.Carro.Local.ToBindingList();

        }

        //Ir buscar data dos serviços
        private void LerDados_Select_Servicos(int IdOfice)
        {
            ModelStand = new ModelOficinaContainer();

            (from servicos in ModelStand.Servicos
             where servicos.CarroOficinaIdCarro.ToString() == IdOfice.ToString()
             select servicos).ToList();

            listBoxServicos.DataSource = ModelStand.Servicos.Local.ToBindingList();
        }

        //Data das Parcelas
        private void LerDados_Select_Parcela(int IdService)
        {
            ModelStand = new ModelOficinaContainer();

            (from parcela in ModelStand.Parcela
             where parcela.ServicoIdServico.ToString() == IdService.ToString()
             select parcela).ToList();

            listBoxParecelas.DataSource = ModelStand.Parcela.Local.ToBindingList();
        }

        //Mostrar os dados do utilzador nas labels
        private void listBoxSelecionar_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LerDados_Select_Carros();
            Cliente cliente = listBoxSelecionar_Cliente.SelectedItem as Cliente;

            label_nomeCliente.Text = cliente.Nome;
            label_NifCliente.Text = cliente.NIF;
            label_TelefoneCliente.Text = cliente.Contacto;
            label_MoradaCliente.Text = cliente.Morada;
            IDSelecionado = cliente.IdCliente;
            LerDados_Select_Carros();
        }

        //Mudar para o adicionar carro
        private void buttonOficina_adicionar_Click(object sender, EventArgs e)
        {
            AdicionarCarro adicionarCarro = new AdicionarCarro(this);
            adicionarCarro.Show();
        }

        //Pesquisar por nome pelos Clientes
        private void buttonClientePesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxClientePesquisar.Text.Length > 0)
            {
                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (from cliente in ModelStand.Cliente
                 where cliente.Nome.ToUpper().Contains(textBoxClientePesquisar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                listBoxSelecionar_Cliente.DataSource = ModelStand.Cliente.Local.ToBindingList();
            }
            else
            {
                ModelStand.Dispose();
                ModelStand = new ModelOficinaContainer();

                (from cliente in ModelStand.Cliente
                 orderby cliente.Nome
                 select cliente).Load();

                listBoxSelecionar_Cliente.DataSource = ModelStand.Cliente.Local.ToBindingList();
            }
        }

        //Fazer reload da listbox dos carros/servicos para ser atualizada quando o ultilizador sai dos Menus
        private void MenuOficina_Activated(object sender, EventArgs e)
        {
            LerDados_Select_Carros();
            //LerDados_Select_Servicos();
        }

        //Introduzir uma Parcela
        private void buttonParecelas_Criar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelOficinaContainer modelStand = new ModelOficinaContainer();

                modelStand.Parcela.Add(new Parcela(textBoxParecelas_Descricao.Text, textBoxParecelas_Valor.Text, ServicoID));
                modelStand.SaveChanges();
            }
            //Apanhar o erro e explicar para se poder perceber, foi retirado da internet 
            //Link: https://www.c-sharpcorner.com/UploadFile/97fc7a/validation-failed-for-one-or-more-entities-mvcentity-frame/
            //Autor: Sachin Kalia
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

        //Mudar para adicionar um serviço
        private void buttonServicos_Criar_Click(object sender, EventArgs e)
        {
            CriarServico criarServico = new CriarServico(this);
            criarServico.Show();
        }


        //Selecionar o IdOficina
        private void listBoxCarro_Oficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carro = listBoxCarro_Oficina.SelectedItem as CarroOficina;
            OficinaIDSelecionado = carro.IdCarro;

            LerDados_Select_Servicos(OficinaIDSelecionado);
        }

        //Selecionar o IDservico 
        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servico = listBoxServicos.SelectedItem as Servico;
            ServicoID = servico.IdServico;

            //label_ValorTotalCliente.Text = ServicoID.ToString(); teste
            LerDados_Select_Parcela(ServicoID);
            Calcular_Valor(ServicoID);
        }

        public void Calcular_Valor(int idCalc)
        {
            List<Parcela> parcelas = new List<Parcela>();
            ModelStand = new ModelOficinaContainer();
            
            parcelas=(from parcela in ModelStand.Parcela
            where parcela.ServicoIdServico.ToString() == idCalc.ToString()
            select parcela).ToList();

            //lambda expressoes que são tratadas como objetos que pode passar por metodos
            int total = parcelas.Sum(x => Convert.ToInt32(x));

            label_ValorTotalCliente.Text = total.ToString() + "€";

        }

        ///Imprimir fatura
        private void btnFatura_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = label_nomeCliente.Text + ".txt";
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("Nome: " + label_nomeCliente.Text + " Nif: " + label_NifCliente.Text+ " Morada: " + label_MoradaCliente.Text + " em " + DateTime.Now);
                writer.WriteLine("________________________________________");
                writer.WriteLine("Valor: " +label_ValorTotalCliente.Text);
                writer.Flush();
                writer.Close();

            }
        }
    }
}
