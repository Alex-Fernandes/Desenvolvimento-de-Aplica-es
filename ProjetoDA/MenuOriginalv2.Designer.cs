namespace ProjetoDA
{
	partial class MenuOriginalv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOriginalv2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnOficina = new System.Windows.Forms.Button();
            this.btnMenuCliente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalAlug = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVenda);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnOficina);
            this.panel2.Controls.Add(this.btnMenuCliente);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 211);
            this.panel2.TabIndex = 1;
            // 
            // btnVenda
            // 
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.Location = new System.Drawing.Point(487, 57);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(138, 137);
            this.btnVenda.TabIndex = 3;
            this.btnVenda.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(333, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 137);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnOficina
            // 
            this.btnOficina.FlatAppearance.BorderSize = 0;
            this.btnOficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOficina.Image = ((System.Drawing.Image)(resources.GetObject("btnOficina.Image")));
            this.btnOficina.Location = new System.Drawing.Point(173, 57);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Size = new System.Drawing.Size(137, 137);
            this.btnOficina.TabIndex = 1;
            this.btnOficina.UseVisualStyleBackColor = true;
            // 
            // btnMenuCliente
            // 
            this.btnMenuCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuCliente.BackgroundImage")));
            this.btnMenuCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenuCliente.FlatAppearance.BorderSize = 0;
            this.btnMenuCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMenuCliente.Location = new System.Drawing.Point(20, 57);
            this.btnMenuCliente.Name = "btnMenuCliente";
            this.btnMenuCliente.Size = new System.Drawing.Size(138, 137);
            this.btnMenuCliente.TabIndex = 0;
            this.btnMenuCliente.UseVisualStyleBackColor = false;
            this.btnMenuCliente.Click += new System.EventHandler(this.btnMenuCliente_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelData,
            this.toolStripStatusLabelHoras,
            this.toolStripStatusLabelTotalVendas,
            this.toolStripStatusLabelTotalAlug});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(674, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelData.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabelData.Text = "01/01/2019";
            // 
            // toolStripStatusLabelHoras
            // 
            this.toolStripStatusLabelHoras.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelHoras.Name = "toolStripStatusLabelHoras";
            this.toolStripStatusLabelHoras.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabelHoras.Text = "00:00:00";
            // 
            // toolStripStatusLabelTotalVendas
            // 
            this.toolStripStatusLabelTotalVendas.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelTotalVendas.Name = "toolStripStatusLabelTotalVendas";
            this.toolStripStatusLabelTotalVendas.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabelTotalVendas.Text = "Total vendas: 0";
            // 
            // toolStripStatusLabelTotalAlug
            // 
            this.toolStripStatusLabelTotalAlug.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelTotalAlug.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabelTotalAlug.Name = "toolStripStatusLabelTotalAlug";
            this.toolStripStatusLabelTotalAlug.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabelTotalAlug.Text = "Total alugados: 0";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.Location = new System.Drawing.Point(640, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MenuOriginalv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(674, 274);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuOriginalv2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Aluguer";
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOficina;
        private System.Windows.Forms.Button btnMenuCliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoras;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalAlug;
        private System.Windows.Forms.Button btnClose;
    }
}