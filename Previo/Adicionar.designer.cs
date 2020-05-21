namespace Previo

{
    partial class Adicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.grpadicionar = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txbadicionar = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.grpadicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UNIDADES A ADICIONAR DEL PRODUCTO";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(107, 39);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(172, 20);
            this.txbcodigo.TabIndex = 2;
            this.txbcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbcodigo.TextChanged += new System.EventHandler(this.txbcodigo_TextChanged);
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(153, 65);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // grpadicionar
            // 
            this.grpadicionar.Controls.Add(this.btnagregar);
            this.grpadicionar.Controls.Add(this.txbadicionar);
            this.grpadicionar.Controls.Add(this.label2);
            this.grpadicionar.Location = new System.Drawing.Point(33, 110);
            this.grpadicionar.Name = "grpadicionar";
            this.grpadicionar.Size = new System.Drawing.Size(298, 100);
            this.grpadicionar.TabIndex = 4;
            this.grpadicionar.TabStop = false;
            this.grpadicionar.Text = "Menu Adicionar";
            this.grpadicionar.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(129, 71);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txbadicionar
            // 
            this.txbadicionar.Location = new System.Drawing.Point(129, 42);
            this.txbadicionar.Name = "txbadicionar";
            this.txbadicionar.Size = new System.Drawing.Size(75, 20);
            this.txbadicionar.TabIndex = 5;
            this.txbadicionar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbadicionar_KeyPress);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(159, 91);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(13, 13);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "?";
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.grpadicionar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.grpadicionar.ResumeLayout(false);
            this.grpadicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox grpadicionar;
        private System.Windows.Forms.TextBox txbadicionar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnagregar;
    }
}