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
            this.listBoxSelecionar_Cliente = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCarro_Oficina = new System.Windows.Forms.ListBox();
            this.buttonOficina_adicionar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxSelecionar_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um Cliente";
            // 
            // listBoxSelecionar_Cliente
            // 
            this.listBoxSelecionar_Cliente.FormattingEnabled = true;
            this.listBoxSelecionar_Cliente.Location = new System.Drawing.Point(0, 23);
            this.listBoxSelecionar_Cliente.Name = "listBoxSelecionar_Cliente";
            this.listBoxSelecionar_Cliente.Size = new System.Drawing.Size(197, 563);
            this.listBoxSelecionar_Cliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonOficina_adicionar);
            this.groupBox2.Controls.Add(this.listBoxCarro_Oficina);
            this.groupBox2.Location = new System.Drawing.Point(208, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro na Oficina";
            // 
            // listBoxCarro_Oficina
            // 
            this.listBoxCarro_Oficina.FormattingEnabled = true;
            this.listBoxCarro_Oficina.Location = new System.Drawing.Point(0, 19);
            this.listBoxCarro_Oficina.Name = "listBoxCarro_Oficina";
            this.listBoxCarro_Oficina.Size = new System.Drawing.Size(245, 368);
            this.listBoxCarro_Oficina.TabIndex = 0;
            // 
            // buttonOficina_adicionar
            // 
            this.buttonOficina_adicionar.Location = new System.Drawing.Point(6, 393);
            this.buttonOficina_adicionar.Name = "buttonOficina_adicionar";
            this.buttonOficina_adicionar.Size = new System.Drawing.Size(239, 23);
            this.buttonOficina_adicionar.TabIndex = 1;
            this.buttonOficina_adicionar.Text = "Adicionar";
            this.buttonOficina_adicionar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(459, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 408);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // MenuOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 599);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuOficina";
            this.Text = "MenuOficina";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxSelecionar_Cliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxCarro_Oficina;
        private System.Windows.Forms.Button buttonOficina_adicionar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}