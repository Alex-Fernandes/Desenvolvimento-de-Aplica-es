namespace ProjetoDA
{
    partial class MenuAluguer
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBoxClientes = new System.Windows.Forms.TextBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxCarros = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxDtaEntrega = new System.Windows.Forms.TextBox();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.labelDtaAluguer = new System.Windows.Forms.Label();
            this.labelCombustivel = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelMarca_Modelo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelNIF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDesalugar = new System.Windows.Forms.Button();
            this.listBoxCarrosAlugados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.textBoxClientes);
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Clientes";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(129, 28);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 25);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // textBoxClientes
            // 
            this.textBoxClientes.Location = new System.Drawing.Point(7, 30);
            this.textBoxClientes.Multiline = true;
            this.textBoxClientes.Name = "textBoxClientes";
            this.textBoxClientes.Size = new System.Drawing.Size(116, 23);
            this.textBoxClientes.TabIndex = 1;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 59);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(198, 355);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBoxCarros);
            this.groupBox2.Location = new System.Drawing.Point(229, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 425);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carros Disponiveis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCarros
            // 
            this.listBoxCarros.FormattingEnabled = true;
            this.listBoxCarros.Location = new System.Drawing.Point(6, 46);
            this.listBoxCarros.Name = "listBoxCarros";
            this.listBoxCarros.Size = new System.Drawing.Size(198, 368);
            this.listBoxCarros.TabIndex = 0;
            this.listBoxCarros.SelectedIndexChanged += new System.EventHandler(this.listBoxCarros_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxValor);
            this.groupBox3.Controls.Add(this.textBoxDtaEntrega);
            this.groupBox3.Controls.Add(this.btnFatura);
            this.groupBox3.Controls.Add(this.btnAlugar);
            this.groupBox3.Controls.Add(this.labelDtaAluguer);
            this.groupBox3.Controls.Add(this.labelCombustivel);
            this.groupBox3.Controls.Add(this.labelMatricula);
            this.groupBox3.Controls.Add(this.labelMarca_Modelo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labelContacto);
            this.groupBox3.Controls.Add(this.labelNIF);
            this.groupBox3.Controls.Add(this.labelNome);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(445, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 425);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alugar";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(141, 337);
            this.textBoxValor.Multiline = true;
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(80, 31);
            this.textBoxValor.TabIndex = 24;
            // 
            // textBoxDtaEntrega
            // 
            this.textBoxDtaEntrega.Location = new System.Drawing.Point(235, 266);
            this.textBoxDtaEntrega.Name = "textBoxDtaEntrega";
            this.textBoxDtaEntrega.Size = new System.Drawing.Size(74, 20);
            this.textBoxDtaEntrega.TabIndex = 23;
            // 
            // btnFatura
            // 
            this.btnFatura.Location = new System.Drawing.Point(207, 9);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(114, 23);
            this.btnFatura.TabIndex = 15;
            this.btnFatura.Text = "Imprimir Fatura";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAlugar.Location = new System.Drawing.Point(246, 396);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(75, 23);
            this.btnAlugar.TabIndex = 22;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // labelDtaAluguer
            // 
            this.labelDtaAluguer.AutoSize = true;
            this.labelDtaAluguer.Location = new System.Drawing.Point(243, 236);
            this.labelDtaAluguer.Name = "labelDtaAluguer";
            this.labelDtaAluguer.Size = new System.Drawing.Size(22, 13);
            this.labelDtaAluguer.TabIndex = 19;
            this.labelDtaAluguer.Text = ". . .";
            // 
            // labelCombustivel
            // 
            this.labelCombustivel.AutoSize = true;
            this.labelCombustivel.Location = new System.Drawing.Point(86, 301);
            this.labelCombustivel.Name = "labelCombustivel";
            this.labelCombustivel.Size = new System.Drawing.Size(22, 13);
            this.labelCombustivel.TabIndex = 17;
            this.labelCombustivel.Text = ". . .";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(70, 268);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(22, 13);
            this.labelMatricula.TabIndex = 16;
            this.labelMatricula.Text = ". . .";
            // 
            // labelMarca_Modelo
            // 
            this.labelMarca_Modelo.AutoSize = true;
            this.labelMarca_Modelo.Location = new System.Drawing.Point(57, 236);
            this.labelMarca_Modelo.Name = "labelMarca_Modelo";
            this.labelMarca_Modelo.Size = new System.Drawing.Size(22, 13);
            this.labelMarca_Modelo.TabIndex = 15;
            this.labelMarca_Modelo.Text = ". . .";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 31);
            this.label15.TabIndex = 14;
            this.label15.Text = "Valor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Data Entrega:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Data Aluguer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Combustível:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Matricula:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Informação do Carro a Alugar";
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Location = new System.Drawing.Point(67, 136);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(22, 13);
            this.labelContacto.TabIndex = 6;
            this.labelContacto.Text = ". . .";
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Location = new System.Drawing.Point(41, 105);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(22, 13);
            this.labelNIF.TabIndex = 5;
            this.labelNIF.Text = ". . .";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(87, 78);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(22, 13);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = ". . .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDesalugar);
            this.groupBox4.Controls.Add(this.listBoxCarrosAlugados);
            this.groupBox4.Location = new System.Drawing.Point(779, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 425);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Carros  Alugados";
            // 
            // btnDesalugar
            // 
            this.btnDesalugar.Location = new System.Drawing.Point(161, 396);
            this.btnDesalugar.Name = "btnDesalugar";
            this.btnDesalugar.Size = new System.Drawing.Size(75, 23);
            this.btnDesalugar.TabIndex = 1;
            this.btnDesalugar.Text = "Desalugar";
            this.btnDesalugar.UseVisualStyleBackColor = true;
            // 
            // listBoxCarrosAlugados
            // 
            this.listBoxCarrosAlugados.FormattingEnabled = true;
            this.listBoxCarrosAlugados.Location = new System.Drawing.Point(7, 20);
            this.listBoxCarrosAlugados.Name = "listBoxCarrosAlugados";
            this.listBoxCarrosAlugados.Size = new System.Drawing.Size(229, 368);
            this.listBoxCarrosAlugados.TabIndex = 0;
            // 
            // MenuAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuAluguer";
            this.Text = "Menu Aluguer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBoxClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCarros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelNIF;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.Label labelDtaAluguer;
        private System.Windows.Forms.Label labelCombustivel;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelMarca_Modelo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDesalugar;
        private System.Windows.Forms.ListBox listBoxCarrosAlugados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.TextBox textBoxDtaEntrega;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}