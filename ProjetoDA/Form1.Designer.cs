namespace ProjetoDA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalVendas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalAlug = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 139);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestão Clientes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 139);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gestão Oficina";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(410, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 139);
            this.button3.TabIndex = 3;
            this.button3.Text = "Gestão Aluguer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(601, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 139);
            this.button4.TabIndex = 4;
            this.button4.Text = "Gestão Vendas";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelData,
            this.toolStripStatusLabelHoras,
            this.toolStripStatusLabelTotalVendas,
            this.toolStripStatusLabelTotalAlug});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RealStand";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHoras;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalVendas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalAlug;
        private System.Windows.Forms.Timer timer1;
    }
}

