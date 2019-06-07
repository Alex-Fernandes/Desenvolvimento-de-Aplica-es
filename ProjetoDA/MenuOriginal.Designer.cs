namespace ProjetoDA
{
    partial class MenuOriginal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOriginal));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clientes = new System.Windows.Forms.Button();
            this.button_Oficina = new System.Windows.Forms.Button();
            this.button_Aluger = new System.Windows.Forms.Button();
            this.button_Venda = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalAlug = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a sua opção";
            // 
            // button_Clientes
            // 
            this.button_Clientes.BackColor = System.Drawing.SystemColors.Window;
            this.button_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("button_Clientes.Image")));
            this.button_Clientes.Location = new System.Drawing.Point(46, 110);
            this.button_Clientes.Name = "button_Clientes";
            this.button_Clientes.Size = new System.Drawing.Size(150, 139);
            this.button_Clientes.TabIndex = 1;
            this.button_Clientes.UseVisualStyleBackColor = false;
            this.button_Clientes.Click += new System.EventHandler(this.button_Clientes_Click);
            // 
            // button_Oficina
            // 
            this.button_Oficina.Image = ((System.Drawing.Image)(resources.GetObject("button_Oficina.Image")));
            this.button_Oficina.Location = new System.Drawing.Point(231, 110);
            this.button_Oficina.Name = "button_Oficina";
            this.button_Oficina.Size = new System.Drawing.Size(140, 139);
            this.button_Oficina.TabIndex = 2;
            this.button_Oficina.UseVisualStyleBackColor = true;
            this.button_Oficina.Click += new System.EventHandler(this.button_Oficina_Click);
            // 
            // button_Aluger
            // 
            this.button_Aluger.Image = ((System.Drawing.Image)(resources.GetObject("button_Aluger.Image")));
            this.button_Aluger.Location = new System.Drawing.Point(410, 110);
            this.button_Aluger.Name = "button_Aluger";
            this.button_Aluger.Size = new System.Drawing.Size(140, 139);
            this.button_Aluger.TabIndex = 3;
            this.button_Aluger.UseVisualStyleBackColor = true;
            // 
            // button_Venda
            // 
            this.button_Venda.Image = ((System.Drawing.Image)(resources.GetObject("button_Venda.Image")));
            this.button_Venda.Location = new System.Drawing.Point(589, 110);
            this.button_Venda.Name = "button_Venda";
            this.button_Venda.Size = new System.Drawing.Size(137, 139);
            this.button_Venda.TabIndex = 4;
            this.button_Venda.UseVisualStyleBackColor = true;
            this.button_Venda.Click += new System.EventHandler(this.button_Venda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelData,
            this.toolStripStatusLabelHoras,
            this.toolStripStatusLabelTotalVendas,
            this.toolStripStatusLabelTotalAlug});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabelData.Text = "01/01/2019";
            // 
            // toolStripStatusLabelHoras
            // 
            this.toolStripStatusLabelHoras.Name = "toolStripStatusLabelHoras";
            this.toolStripStatusLabelHoras.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelHoras.Text = "00:00:00";
            // 
            // toolStripStatusLabelTotalVendas
            // 
            this.toolStripStatusLabelTotalVendas.Name = "toolStripStatusLabelTotalVendas";
            this.toolStripStatusLabelTotalVendas.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabelTotalVendas.Text = "Total vendas: 0";
            // 
            // toolStripStatusLabelTotalAlug
            // 
            this.toolStripStatusLabelTotalAlug.Name = "toolStripStatusLabelTotalAlug";
            this.toolStripStatusLabelTotalAlug.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabelTotalAlug.Text = "Total alugados: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestão de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestão Oficina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gestão Aluger";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gestão Venda";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Location = new System.Drawing.Point(152, 290);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(442, 204);
            this.clienteDataGridView.TabIndex = 10;
            // 
            // MenuOriginal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Venda);
            this.Controls.Add(this.button_Aluger);
            this.Controls.Add(this.button_Oficina);
            this.Controls.Add(this.button_Clientes);
            this.Controls.Add(this.label1);
            this.Name = "MenuOriginal";
            this.Text = "RealStand";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clientes;
        private System.Windows.Forms.Button button_Oficina;
        private System.Windows.Forms.Button button_Aluger;
        private System.Windows.Forms.Button button_Venda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoras;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalAlug;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView clienteDataGridView;
    }
}

