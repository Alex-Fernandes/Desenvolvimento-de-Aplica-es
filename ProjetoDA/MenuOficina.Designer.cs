namespace ProjetoDA
{
    partial class MenuOficina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClientePesquisar = new System.Windows.Forms.Button();
            this.textBoxClientePesquisar = new System.Windows.Forms.TextBox();
            this.listBoxSelecionar_Cliente = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOficina_adicionar = new System.Windows.Forms.Button();
            this.listBoxCarro_Oficina = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonServicos_Criar = new System.Windows.Forms.Button();
            this.comboBoxServicos = new System.Windows.Forms.ComboBox();
            this.listBoxServicos = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonParecelas_Criar = new System.Windows.Forms.Button();
            this.textBoxParecelas_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxParecelas_Descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParecelas = new System.Windows.Forms.ListBox();
            this.label_nomeCliente = new System.Windows.Forms.Label();
            this.label_NifCliente = new System.Windows.Forms.Label();
            this.label_TelefoneCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ValorTotalCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_MoradaCliente = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPastaDeRecibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClientePesquisar);
            this.groupBox1.Controls.Add(this.textBoxClientePesquisar);
            this.groupBox1.Controls.Add(this.listBoxSelecionar_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Cliente";
            // 
            // buttonClientePesquisar
            // 
            this.buttonClientePesquisar.Location = new System.Drawing.Point(113, 49);
            this.buttonClientePesquisar.Name = "buttonClientePesquisar";
            this.buttonClientePesquisar.Size = new System.Drawing.Size(66, 29);
            this.buttonClientePesquisar.TabIndex = 2;
            this.buttonClientePesquisar.Text = "Pesquisar";
            this.buttonClientePesquisar.UseVisualStyleBackColor = true;
            this.buttonClientePesquisar.Click += new System.EventHandler(this.buttonClientePesquisar_Click);
            // 
            // textBoxClientePesquisar
            // 
            this.textBoxClientePesquisar.Location = new System.Drawing.Point(6, 23);
            this.textBoxClientePesquisar.Name = "textBoxClientePesquisar";
            this.textBoxClientePesquisar.Size = new System.Drawing.Size(173, 20);
            this.textBoxClientePesquisar.TabIndex = 1;
            // 
            // listBoxSelecionar_Cliente
            // 
            this.listBoxSelecionar_Cliente.FormattingEnabled = true;
            this.listBoxSelecionar_Cliente.Location = new System.Drawing.Point(0, 88);
            this.listBoxSelecionar_Cliente.Name = "listBoxSelecionar_Cliente";
            this.listBoxSelecionar_Cliente.Size = new System.Drawing.Size(182, 498);
            this.listBoxSelecionar_Cliente.TabIndex = 0;
            this.listBoxSelecionar_Cliente.SelectedIndexChanged += new System.EventHandler(this.listBoxSelecionar_Cliente_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOficina_adicionar);
            this.groupBox2.Controls.Add(this.listBoxCarro_Oficina);
            this.groupBox2.Location = new System.Drawing.Point(208, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro na Oficina";
            // 
            // buttonOficina_adicionar
            // 
            this.buttonOficina_adicionar.Location = new System.Drawing.Point(6, 393);
            this.buttonOficina_adicionar.Name = "buttonOficina_adicionar";
            this.buttonOficina_adicionar.Size = new System.Drawing.Size(239, 23);
            this.buttonOficina_adicionar.TabIndex = 1;
            this.buttonOficina_adicionar.Text = "Adicionar Carro";
            this.buttonOficina_adicionar.UseVisualStyleBackColor = true;
            this.buttonOficina_adicionar.Click += new System.EventHandler(this.buttonOficina_adicionar_Click);
            // 
            // listBoxCarro_Oficina
            // 
            this.listBoxCarro_Oficina.FormattingEnabled = true;
            this.listBoxCarro_Oficina.Location = new System.Drawing.Point(0, 19);
            this.listBoxCarro_Oficina.Name = "listBoxCarro_Oficina";
            this.listBoxCarro_Oficina.Size = new System.Drawing.Size(245, 368);
            this.listBoxCarro_Oficina.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonServicos_Criar);
            this.groupBox3.Controls.Add(this.comboBoxServicos);
            this.groupBox3.Controls.Add(this.listBoxServicos);
            this.groupBox3.Location = new System.Drawing.Point(459, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 422);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // buttonServicos_Criar
            // 
            this.buttonServicos_Criar.Location = new System.Drawing.Point(0, 394);
            this.buttonServicos_Criar.Name = "buttonServicos_Criar";
            this.buttonServicos_Criar.Size = new System.Drawing.Size(225, 23);
            this.buttonServicos_Criar.TabIndex = 4;
            this.buttonServicos_Criar.Text = "Criar Serviço";
            this.buttonServicos_Criar.UseVisualStyleBackColor = true;
            this.buttonServicos_Criar.Click += new System.EventHandler(this.buttonServicos_Criar_Click);
            // 
            // comboBoxServicos
            // 
            this.comboBoxServicos.FormattingEnabled = true;
            this.comboBoxServicos.Location = new System.Drawing.Point(6, 366);
            this.comboBoxServicos.Name = "comboBoxServicos";
            this.comboBoxServicos.Size = new System.Drawing.Size(219, 21);
            this.comboBoxServicos.TabIndex = 1;
            // 
            // listBoxServicos
            // 
            this.listBoxServicos.FormattingEnabled = true;
            this.listBoxServicos.Location = new System.Drawing.Point(6, 19);
            this.listBoxServicos.Name = "listBoxServicos";
            this.listBoxServicos.Size = new System.Drawing.Size(219, 342);
            this.listBoxServicos.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonParecelas_Criar);
            this.groupBox4.Controls.Add(this.textBoxParecelas_Valor);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxParecelas_Descricao);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.listBoxParecelas);
            this.groupBox4.Location = new System.Drawing.Point(697, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 422);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parecelas";
            // 
            // buttonParecelas_Criar
            // 
            this.buttonParecelas_Criar.Location = new System.Drawing.Point(0, 393);
            this.buttonParecelas_Criar.Name = "buttonParecelas_Criar";
            this.buttonParecelas_Criar.Size = new System.Drawing.Size(275, 23);
            this.buttonParecelas_Criar.TabIndex = 5;
            this.buttonParecelas_Criar.Text = "Criar Parecelas";
            this.buttonParecelas_Criar.UseVisualStyleBackColor = true;
            this.buttonParecelas_Criar.Click += new System.EventHandler(this.buttonParecelas_Criar_Click);
            // 
            // textBoxParecelas_Valor
            // 
            this.textBoxParecelas_Valor.Location = new System.Drawing.Point(90, 359);
            this.textBoxParecelas_Valor.Name = "textBoxParecelas_Valor";
            this.textBoxParecelas_Valor.Size = new System.Drawing.Size(185, 20);
            this.textBoxParecelas_Valor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // textBoxParecelas_Descricao
            // 
            this.textBoxParecelas_Descricao.Location = new System.Drawing.Point(90, 324);
            this.textBoxParecelas_Descricao.Name = "textBoxParecelas_Descricao";
            this.textBoxParecelas_Descricao.Size = new System.Drawing.Size(185, 20);
            this.textBoxParecelas_Descricao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // listBoxParecelas
            // 
            this.listBoxParecelas.FormattingEnabled = true;
            this.listBoxParecelas.Location = new System.Drawing.Point(6, 19);
            this.listBoxParecelas.Name = "listBoxParecelas";
            this.listBoxParecelas.Size = new System.Drawing.Size(269, 303);
            this.listBoxParecelas.TabIndex = 0;
            // 
            // label_nomeCliente
            // 
            this.label_nomeCliente.AutoSize = true;
            this.label_nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label_nomeCliente.Location = new System.Drawing.Point(343, 50);
            this.label_nomeCliente.Name = "label_nomeCliente";
            this.label_nomeCliente.Size = new System.Drawing.Size(347, 36);
            this.label_nomeCliente.TabIndex = 5;
            this.label_nomeCliente.Text = "Sem Cliente Selecionado";
            // 
            // label_NifCliente
            // 
            this.label_NifCliente.AutoSize = true;
            this.label_NifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NifCliente.Location = new System.Drawing.Point(283, 105);
            this.label_NifCliente.Name = "label_NifCliente";
            this.label_NifCliente.Size = new System.Drawing.Size(14, 20);
            this.label_NifCliente.TabIndex = 6;
            this.label_NifCliente.Text = "-";
            // 
            // label_TelefoneCliente
            // 
            this.label_TelefoneCliente.AutoSize = true;
            this.label_TelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TelefoneCliente.Location = new System.Drawing.Point(322, 140);
            this.label_TelefoneCliente.Name = "label_TelefoneCliente";
            this.label_TelefoneCliente.Size = new System.Drawing.Size(14, 20);
            this.label_TelefoneCliente.TabIndex = 7;
            this.label_TelefoneCliente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor Total:";
            // 
            // label_ValorTotalCliente
            // 
            this.label_ValorTotalCliente.AutoSize = true;
            this.label_ValorTotalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ValorTotalCliente.Location = new System.Drawing.Point(841, 110);
            this.label_ValorTotalCliente.Name = "label_ValorTotalCliente";
            this.label_ValorTotalCliente.Size = new System.Drawing.Size(65, 24);
            this.label_ValorTotalCliente.TabIndex = 9;
            this.label_ValorTotalCliente.Text = "00.00€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "NIF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Conctato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Morada:";
            // 
            // label_MoradaCliente
            // 
            this.label_MoradaCliente.AutoSize = true;
            this.label_MoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MoradaCliente.Location = new System.Drawing.Point(503, 105);
            this.label_MoradaCliente.Name = "label_MoradaCliente";
            this.label_MoradaCliente.Size = new System.Drawing.Size(14, 20);
            this.label_MoradaCliente.TabIndex = 14;
            this.label_MoradaCliente.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.abrirPastaDeRecibosToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // abrirPastaDeRecibosToolStripMenuItem
            // 
            this.abrirPastaDeRecibosToolStripMenuItem.Name = "abrirPastaDeRecibosToolStripMenuItem";
            this.abrirPastaDeRecibosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.abrirPastaDeRecibosToolStripMenuItem.Text = "Abrir Pasta de Recibos";
            // 
            // MenuOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 618);
            this.Controls.Add(this.label_MoradaCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ValorTotalCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_TelefoneCliente);
            this.Controls.Add(this.label_NifCliente);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_nomeCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuOficina";
            this.Text = "MenuOficina";
            this.Activated += new System.EventHandler(this.MenuOficina_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxSelecionar_Cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCarro_Oficina;
        private System.Windows.Forms.Button buttonOficina_adicionar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonServicos_Criar;
        private System.Windows.Forms.ComboBox comboBoxServicos;
        private System.Windows.Forms.ListBox listBoxServicos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonParecelas_Criar;
        private System.Windows.Forms.TextBox textBoxParecelas_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParecelas_Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxParecelas;
        private System.Windows.Forms.Label label_nomeCliente;
        private System.Windows.Forms.Label label_NifCliente;
        private System.Windows.Forms.Label label_TelefoneCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ValorTotalCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_MoradaCliente;
        private System.Windows.Forms.Button buttonClientePesquisar;
        private System.Windows.Forms.TextBox textBoxClientePesquisar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPastaDeRecibosToolStripMenuItem;
    }
}