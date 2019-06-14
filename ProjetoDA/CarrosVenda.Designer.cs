namespace ProjetoDA
{
    partial class CarrosVenda
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
            this.idCarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChassisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelOficinaDataSet2 = new ProjetoDA.ModelOficinaDataSet2();
            this.groupBoxAdcCarro = new System.Windows.Forms.GroupBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxIdCarro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtras = new System.Windows.Forms.TextBox();
            this.carroTableAdapter = new ProjetoDA.ModelOficinaDataSet2TableAdapters.CarroTableAdapter();
            this.groupBoxCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet2)).BeginInit();
            this.groupBoxAdcCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCarros
            // 
            this.groupBoxCarros.Controls.Add(this.btnFiltrar);
            this.groupBoxCarros.Controls.Add(this.textBoxFiltrar);
            this.groupBoxCarros.Controls.Add(this.carroDataGridView);
            this.groupBoxCarros.Location = new System.Drawing.Point(3, 12);
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
            this.carroDataGridView.Location = new System.Drawing.Point(12, 57);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.Size = new System.Drawing.Size(544, 220);
            this.carroDataGridView.TabIndex = 0;
            this.carroDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carroDataGridView_CellClick);
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
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.modelOficinaDataSet2;
            // 
            // modelOficinaDataSet2
            // 
            this.modelOficinaDataSet2.DataSetName = "ModelOficinaDataSet2";
            this.modelOficinaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxAdcCarro
            // 
            this.groupBoxAdcCarro.Controls.Add(this.buttonConfirmar);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxIdCarro);
            this.groupBoxAdcCarro.Controls.Add(this.label4);
            this.groupBoxAdcCarro.Controls.Add(this.label1);
            this.groupBoxAdcCarro.Controls.Add(this.textBoxExtras);
            this.groupBoxAdcCarro.Location = new System.Drawing.Point(588, 13);
            this.groupBoxAdcCarro.Name = "groupBoxAdcCarro";
            this.groupBoxAdcCarro.Size = new System.Drawing.Size(236, 276);
            this.groupBoxAdcCarro.TabIndex = 2;
            this.groupBoxAdcCarro.TabStop = false;
            this.groupBoxAdcCarro.Text = "Adicionar Carro Venda";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(81, 168);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(74, 46);
            this.buttonConfirmar.TabIndex = 8;
            this.buttonConfirmar.Text = "Confirmar Venda";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBoxIdCarro
            // 
            this.textBoxIdCarro.Location = new System.Drawing.Point(107, 103);
            this.textBoxIdCarro.Name = "textBoxIdCarro";
            this.textBoxIdCarro.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCarro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdCarro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extras:";
            // 
            // textBoxExtras
            // 
            this.textBoxExtras.Location = new System.Drawing.Point(107, 56);
            this.textBoxExtras.Name = "textBoxExtras";
            this.textBoxExtras.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtras.TabIndex = 0;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // CarrosVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 292);
            this.Controls.Add(this.groupBoxAdcCarro);
            this.Controls.Add(this.groupBoxCarros);
            this.Name = "CarrosVenda";
            this.Text = "CarrosVenda";
            this.Load += new System.EventHandler(this.CarrosVenda_Load);
            this.groupBoxCarros.ResumeLayout(false);
            this.groupBoxCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelOficinaDataSet2)).EndInit();
            this.groupBoxAdcCarro.ResumeLayout(false);
            this.groupBoxAdcCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.DataGridView carroDataGridView;
        private System.Windows.Forms.GroupBox groupBoxAdcCarro;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxIdCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtras;
        private ModelOficinaDataSet2 modelOficinaDataSet2;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private ModelOficinaDataSet2TableAdapters.CarroTableAdapter carroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChassisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivelDataGridViewTextBoxColumn;
    }
}