namespace ProjetoDA
{
	partial class CriarServico
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
            this.buttonCriar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarDtaSaida = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTipoServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDtaEntrada = new System.Windows.Forms.TextBox();
            this.labelDtaSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCriar
            // 
            this.buttonCriar.Location = new System.Drawing.Point(166, 330);
            this.buttonCriar.Name = "buttonCriar";
            this.buttonCriar.Size = new System.Drawing.Size(75, 23);
            this.buttonCriar.TabIndex = 0;
            this.buttonCriar.Text = "Criar";
            this.buttonCriar.UseVisualStyleBackColor = true;
            this.buttonCriar.Click += new System.EventHandler(this.buttonCriar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(85, 330);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Entrada:";
            // 
            // CalendarDtaSaida
            // 
            this.CalendarDtaSaida.Location = new System.Drawing.Point(8, 156);
            this.CalendarDtaSaida.Name = "CalendarDtaSaida";
            this.CalendarDtaSaida.TabIndex = 3;
            this.CalendarDtaSaida.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDtaSaida_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Saída:";
            // 
            // textBoxTipoServico
            // 
            this.textBoxTipoServico.Location = new System.Drawing.Point(16, 93);
            this.textBoxTipoServico.Name = "textBoxTipoServico";
            this.textBoxTipoServico.Size = new System.Drawing.Size(219, 20);
            this.textBoxTipoServico.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de serviço:";
            // 
            // textBoxDtaEntrada
            // 
            this.textBoxDtaEntrada.Location = new System.Drawing.Point(95, 27);
            this.textBoxDtaEntrada.Name = "textBoxDtaEntrada";
            this.textBoxDtaEntrada.Size = new System.Drawing.Size(133, 20);
            this.textBoxDtaEntrada.TabIndex = 7;
            // 
            // labelDtaSaida
            // 
            this.labelDtaSaida.AutoSize = true;
            this.labelDtaSaida.Location = new System.Drawing.Point(105, 134);
            this.labelDtaSaida.Name = "labelDtaSaida";
            this.labelDtaSaida.Size = new System.Drawing.Size(10, 13);
            this.labelDtaSaida.TabIndex = 8;
            this.labelDtaSaida.Text = "-";
            // 
            // CriarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 365);
            this.Controls.Add(this.labelDtaSaida);
            this.Controls.Add(this.textBoxDtaEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTipoServico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalendarDtaSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCriar);
            this.Name = "CriarServico";
            this.Text = "CriarServico";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCriar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MonthCalendar CalendarDtaSaida;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxTipoServico;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDtaEntrada;
        private System.Windows.Forms.Label labelDtaSaida;
    }
}