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
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCarro));
            this.groupBoxCarros = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltrar = new System.Windows.Forms.TextBox();
            this.carroDataGridView = new System.Windows.Forms.DataGridView();
            this.carroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxAdcCarro = new System.Windows.Forms.GroupBox();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            combustivelLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            this.groupBoxCarros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).BeginInit();
            this.carroBindingNavigator.SuspendLayout();
            this.groupBoxAdcCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(70, 188);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 1;
            combustivelLabel.Text = "Combustivel:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(70, 109);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(70, 135);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "Modelo:";
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(70, 161);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 9;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // groupBoxCarros
            // 
            this.groupBoxCarros.Controls.Add(this.btnFiltrar);
            this.groupBoxCarros.Controls.Add(this.textBoxFiltrar);
            this.groupBoxCarros.Controls.Add(this.carroDataGridView);
            this.groupBoxCarros.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCarros.Name = "groupBoxCarros";
            this.groupBoxCarros.Size = new System.Drawing.Size(481, 307);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.carroDataGridView.DataSource = this.carroBindingSource;
            this.carroDataGridView.Location = new System.Drawing.Point(7, 60);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.Size = new System.Drawing.Size(443, 220);
            this.carroDataGridView.TabIndex = 0;
            // 
            // carroBindingNavigator
            // 
            this.carroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carroBindingNavigator.BindingSource = this.carroBindingSource;
            this.carroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carroBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.carroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.carroBindingNavigatorSaveItem});
            this.carroBindingNavigator.Location = new System.Drawing.Point(10, 30);
            this.carroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carroBindingNavigator.Name = "carroBindingNavigator";
            this.carroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carroBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.carroBindingNavigator.TabIndex = 1;
            this.carroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carroBindingNavigatorSaveItem
            // 
            this.carroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroBindingNavigatorSaveItem.Image")));
            this.carroBindingNavigatorSaveItem.Name = "carroBindingNavigatorSaveItem";
            this.carroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroBindingNavigatorSaveItem.Text = "Save Data";
            this.carroBindingNavigatorSaveItem.Click += new System.EventHandler(this.carroBindingNavigatorSaveItem_Click_1);
            // 
            // groupBoxAdcCarro
            // 
            this.groupBoxAdcCarro.Controls.Add(combustivelLabel);
            this.groupBoxAdcCarro.Controls.Add(this.combustivelTextBox);
            this.groupBoxAdcCarro.Controls.Add(marcaLabel);
            this.groupBoxAdcCarro.Controls.Add(this.marcaTextBox);
            this.groupBoxAdcCarro.Controls.Add(modeloLabel);
            this.groupBoxAdcCarro.Controls.Add(this.modeloTextBox);
            this.groupBoxAdcCarro.Controls.Add(numeroChassisLabel);
            this.groupBoxAdcCarro.Controls.Add(this.numeroChassisTextBox);
            this.groupBoxAdcCarro.Controls.Add(this.carroBindingNavigator);
            this.groupBoxAdcCarro.Location = new System.Drawing.Point(499, 13);
            this.groupBoxAdcCarro.Name = "groupBoxAdcCarro";
            this.groupBoxAdcCarro.Size = new System.Drawing.Size(322, 306);
            this.groupBoxAdcCarro.TabIndex = 1;
            this.groupBoxAdcCarro.TabStop = false;
            this.groupBoxAdcCarro.Text = "Adicionar Carro";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(162, 185);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.combustivelTextBox.TabIndex = 2;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(162, 106);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 6;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(162, 132);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 8;
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(162, 158);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroChassisTextBox.TabIndex = 10;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(ProjetoDA.Carro);
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
            // AdicionarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 331);
            this.Controls.Add(this.groupBoxAdcCarro);
            this.Controls.Add(this.groupBoxCarros);
            this.Name = "AdicionarCarro";
            this.Text = "AdicionarCarro";
            this.groupBoxCarros.ResumeLayout(false);
            this.groupBoxCarros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingNavigator)).EndInit();
            this.carroBindingNavigator.ResumeLayout(false);
            this.carroBindingNavigator.PerformLayout();
            this.groupBoxAdcCarro.ResumeLayout(false);
            this.groupBoxAdcCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCarros;
		private System.Windows.Forms.BindingNavigator carroBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.BindingSource carroBindingSource;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton carroBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView carroDataGridView;
		private System.Windows.Forms.GroupBox groupBoxAdcCarro;
		private System.Windows.Forms.TextBox combustivelTextBox;
		private System.Windows.Forms.TextBox marcaTextBox;
		private System.Windows.Forms.TextBox modeloTextBox;
		private System.Windows.Forms.TextBox numeroChassisTextBox;
		private System.Windows.Forms.Button btnFiltrar;
		private System.Windows.Forms.TextBox textBoxFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}