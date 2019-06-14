namespace ProjetoDA
{
    partial class CarroDisponivel
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
            this.groupBoxAdcCarro = new System.Windows.Forms.GroupBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxNumChassi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCarro = new System.Windows.Forms.TextBox();
            this.carroDataGridView = new System.Windows.Forms.DataGridView();
            this.modelOficinaDataSet1 = new ProjetoDA.ModelOficinaDataSet1();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroTableAdapter = new ProjetoDA.ModelOficinaDataSet1TableAdapters.CarroTableAdapter();
            this.idCarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChassisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.groupBoxCarros.SuspendLayout();
            this.groupBoxAdcCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCarros
            // 
            this.groupBoxCarros.Controls.Add(this.carroDataGridView);
            this.groupBoxCarros.Controls.Add(this.btnFiltrar);
            this.groupBoxCarros.Controls.Add(this.textBoxFiltrar);
            this.groupBoxCarros.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCarros.Name = "groupBoxCarros";
            this.groupBoxCarros.Size = new System.Drawing.Size(562, 307);
            this.groupBoxCarros.TabIndex = 1;
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
            // 
            // groupBoxAdcCarro
            // 
            this.groupBoxAdcCarro.Controls.Add(this.textBoxEstado);
            this.groupBoxAdcCarro.Controls.Add(this.label2);
            this.groupBoxAdcCarro.Controls.Add(this.buttonConfirmar);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxNumChassi);
            this.groupBoxAdcCarro.Controls.Add(this.label3);
            this.groupBoxAdcCarro.Controls.Add(this.label1);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxIdCarro);
            this.groupBoxAdcCarro.Location = new System.Drawing.Point(590, 13);
            this.groupBoxAdcCarro.Name = "groupBoxAdcCarro";
            this.groupBoxAdcCarro.Size = new System.Drawing.Size(323, 306);
            this.groupBoxAdcCarro.TabIndex = 2;
            this.groupBoxAdcCarro.TabStop = false;
            this.groupBoxAdcCarro.Text = "Adicionar Carro Servicos";
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
            // textBoxNumChassi
            // 
            this.textBoxNumChassi.Location = new System.Drawing.Point(119, 94);
            this.textBoxNumChassi.Name = "textBoxNumChassi";
            this.textBoxNumChassi.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumChassi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de Chassi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCarro:";
            // 
            // textBoxIdCarro
            // 
            this.textBoxIdCarro.Location = new System.Drawing.Point(119, 37);
            this.textBoxIdCarro.Name = "textBoxIdCarro";
            this.textBoxIdCarro.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCarro.TabIndex = 0;
            // 
            // carroDataGridView
            // 
            this.carroDataGridView.AutoGenerateColumns = false;
            this.carroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarroDataGridViewTextBoxColumn,
            this.numeroChassisDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.combustivelDataGridViewTextBoxColumn});
            this.carroDataGridView.DataSource = this.carroBindingSource;
            this.carroDataGridView.Location = new System.Drawing.Point(6, 60);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.Size = new System.Drawing.Size(544, 220);
            this.carroDataGridView.TabIndex = 3;
            this.carroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carroDataGridView_CellClick);
            // 
            // modelOficinaDataSet1
            // 
            this.modelOficinaDataSet1.DataSetName = "ModelOficinaDataSet1";
            this.modelOficinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.modelOficinaDataSet1;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // idCarroDataGridViewTextBoxColumn
            // 
            this.idCarroDataGridViewTextBoxColumn.DataPropertyName = "IdCarro";
            this.idCarroDataGridViewTextBoxColumn.HeaderText = "IdCarro";
            this.idCarroDataGridViewTextBoxColumn.Name = "idCarroDataGridViewTextBoxColumn";
            this.idCarroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroChassisDataGridViewTextBoxColumn
            // 
            this.numeroChassisDataGridViewTextBoxColumn.DataPropertyName = "NumeroChassis";
            this.numeroChassisDataGridViewTextBoxColumn.HeaderText = "NumeroChassis";
            this.numeroChassisDataGridViewTextBoxColumn.Name = "numeroChassisDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // combustivelDataGridViewTextBoxColumn
            // 
            this.combustivelDataGridViewTextBoxColumn.DataPropertyName = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.HeaderText = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.Name = "combustivelDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estado:";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(119, 142);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstado.TabIndex = 10;
            // 
            // CarroDisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 330);
            this.Controls.Add(this.groupBoxAdcCarro);
            this.Controls.Add(this.groupBoxCarros);
            this.Name = "CarroDisponivel";
            this.Text = "CarroDisponivel";
            this.Load += new System.EventHandler(this.CarroDisponivel_Load);
            this.groupBoxCarros.ResumeLayout(false);
            this.groupBoxCarros.PerformLayout();
            this.groupBoxAdcCarro.ResumeLayout(false);
            this.groupBoxAdcCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.GroupBox groupBoxAdcCarro;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxNumChassi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdCarro;
        private System.Windows.Forms.DataGridView carroDataGridView;
        private ModelOficinaDataSet1 modelOficinaDataSet1;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private ModelOficinaDataSet1TableAdapters.CarroTableAdapter carroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChassisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.Label label2;
    }
}