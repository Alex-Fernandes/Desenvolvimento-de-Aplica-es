namespace ProjetoDA
{
    partial class AdicionarCarro
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
            this.groupBoxCarros = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.carroDataGridView = new System.Windows.Forms.DataGridView();
            this.IdCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAdcCarro = new System.Windows.Forms.GroupBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxKms = new System.Windows.Forms.TextBox();
            this.textBoxNumChassi = new System.Windows.Forms.TextBox();
            this.textBoxIdOficina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.modelOficinaDataSet = new ProjetoDA.ModelOficinaDataSet();
            this.carroCarroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carro_CarroOficinaTableAdapter = new ProjetoDA.ModelOficinaDataSetTableAdapters.Carro_CarroOficinaTableAdapter();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBoxAdcCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroCarroOficinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCarros
            // 
            this.groupBoxCarros.Controls.Add(this.btnFiltrar);
            this.groupBoxCarros.Controls.Add(this.textBoxFiltrar);
            this.groupBoxCarros.Controls.Add(this.carroDataGridView);
            this.groupBoxCarros.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCarros.Name = "groupBoxCarros";
            this.groupBoxCarros.Size = new System.Drawing.Size(562, 307);
            this.groupBoxCarros.TabIndex = 0;
            this.groupBoxCarros.TabStop = false;
            this.groupBoxCarros.Text = "Carros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(321, 31);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // textBoxFiltrar
            // 
            this.textBoxFiltrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxFiltrar.Location = new System.Drawing.Point(7, 31);
            this.textBoxFiltrar.Name = "textBoxFiltrar";
            this.textBoxFiltrar.Size = new System.Drawing.Size(307, 20);
            this.textBoxFiltrar.TabIndex = 1;
            this.textBoxFiltrar.Tag = "";
            this.textBoxFiltrar.Text = "Introduza o numero de Chassi";
            this.textBoxFiltrar.Enter += new System.EventHandler(this.textBoxFiltrar_Enter);
            this.textBoxFiltrar.Leave += new System.EventHandler(this.textBoxFiltrar_Leave);
            // 
            // carroDataGridView
            // 
            this.carroDataGridView.AutoGenerateColumns = false;
            this.carroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCarro,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.carroDataGridView.DataSource = this.carroBindingSource;
            this.carroDataGridView.Location = new System.Drawing.Point(7, 60);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.Size = new System.Drawing.Size(544, 220);
            this.carroDataGridView.TabIndex = 0;
            this.carroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carroDataGridView_CellClick);
            // 
            // IdCarro
            // 
            this.IdCarro.DataPropertyName = "IdCarro";
            this.IdCarro.HeaderText = "IdCarro";
            this.IdCarro.Name = "IdCarro";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumeroChassis";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumeroChassis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Combustivel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Combustivel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(ProjetoDA.Carro);
            // 
            // groupBoxAdcCarro
            // 
            this.groupBoxAdcCarro.Controls.Add(this.buttonConfirmar);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxKms);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxNumChassi);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxIdOficina);
            this.groupBoxAdcCarro.Controls.Add(this.label4);
            this.groupBoxAdcCarro.Controls.Add(this.label3);
            this.groupBoxAdcCarro.Controls.Add(this.label2);
            this.groupBoxAdcCarro.Controls.Add(this.label1);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxIdCliente);
            this.groupBoxAdcCarro.Location = new System.Drawing.Point(580, 13);
            this.groupBoxAdcCarro.Name = "groupBoxAdcCarro";
            this.groupBoxAdcCarro.Size = new System.Drawing.Size(323, 306);
            this.groupBoxAdcCarro.TabIndex = 1;
            this.groupBoxAdcCarro.TabStop = false;
            this.groupBoxAdcCarro.Text = "Adicionar Carro Oficina";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(133, 218);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(74, 46);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "Confirmar Entrada";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBoxKms
            // 
            this.textBoxKms.Location = new System.Drawing.Point(119, 162);
            this.textBoxKms.Name = "textBoxKms";
            this.textBoxKms.Size = new System.Drawing.Size(100, 20);
            this.textBoxKms.TabIndex = 7;
            // 
            // textBoxNumChassi
            // 
            this.textBoxNumChassi.Location = new System.Drawing.Point(119, 126);
            this.textBoxNumChassi.Name = "textBoxNumChassi";
            this.textBoxNumChassi.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumChassi.TabIndex = 6;
            // 
            // textBoxIdOficina
            // 
            this.textBoxIdOficina.Location = new System.Drawing.Point(119, 86);
            this.textBoxIdOficina.Name = "textBoxIdOficina";
            this.textBoxIdOficina.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdOficina.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de Chassi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IdOficina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCliente:";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(119, 37);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 0;
            // 
            // modelOficinaDataSet
            // 
            this.modelOficinaDataSet.DataSetName = "ModelOficinaDataSet";
            this.modelOficinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroCarroOficinaBindingSource
            // 
            this.carroCarroOficinaBindingSource.DataMember = "Carro_CarroOficina";
            this.carroCarroOficinaBindingSource.DataSource = this.modelOficinaDataSet;
            // 
            // carro_CarroOficinaTableAdapter
            // 
            this.carro_CarroOficinaTableAdapter.ClearBeforeFill = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // AdicionarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 331);
            this.Controls.Add(this.groupBoxAdcCarro);
            this.Controls.Add(this.groupBoxCarros);
            this.Name = "AdicionarCarro";
            this.Text = "AdicionarCarro";
            this.Load += new System.EventHandler(this.AdicionarCarro_Load);
            this.groupBoxCarros.ResumeLayout(false);
            this.groupBoxCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBoxAdcCarro.ResumeLayout(false);
            this.groupBoxAdcCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroCarroOficinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarros;
		private System.Windows.Forms.BindingSource carroBindingSource;
		private System.Windows.Forms.DataGridView carroDataGridView;
		private System.Windows.Forms.GroupBox groupBoxAdcCarro;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.TextBox textBoxFiltrar;
        private ModelOficinaDataSet modelOficinaDataSet;
        private System.Windows.Forms.BindingSource carroCarroOficinaBindingSource;
        private ModelOficinaDataSetTableAdapters.Carro_CarroOficinaTableAdapter carro_CarroOficinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCarro;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxIdOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxKms;
        private System.Windows.Forms.TextBox textBoxNumChassi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}