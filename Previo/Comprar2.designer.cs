namespace Previo
{
    partial class Comprar2
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.grpadicionar = new System.Windows.Forms.GroupBox();
            this.btnañadircarrito = new System.Windows.Forms.Button();
            this.txbcantcomprar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grpadicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(157, 79);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(13, 13);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "?";
            // 
            // grpadicionar
            // 
            this.grpadicionar.Controls.Add(this.btnañadircarrito);
            this.grpadicionar.Controls.Add(this.txbcantcomprar);
            this.grpadicionar.Controls.Add(this.label2);
            this.grpadicionar.Location = new System.Drawing.Point(31, 98);
            this.grpadicionar.Name = "grpadicionar";
            this.grpadicionar.Size = new System.Drawing.Size(298, 100);
            this.grpadicionar.TabIndex = 9;
            this.grpadicionar.TabStop = false;
            this.grpadicionar.Text = "Menu Comprar";
            this.grpadicionar.Visible = false;
            this.grpadicionar.Enter += new System.EventHandler(this.grpadicionar_Enter);
            // 
            // btnañadircarrito
            // 
            this.btnañadircarrito.Location = new System.Drawing.Point(129, 68);
            this.btnañadircarrito.Name = "btnañadircarrito";
            this.btnañadircarrito.Size = new System.Drawing.Size(75, 23);
            this.btnañadircarrito.TabIndex = 7;
            this.btnañadircarrito.Text = "Añadir!";
            this.btnañadircarrito.UseVisualStyleBackColor = true;
            this.btnañadircarrito.Click += new System.EventHandler(this.btnañadircarrito_Click);
            // 
            // txbcantcomprar
            // 
            this.txbcantcomprar.Location = new System.Drawing.Point(129, 42);
            this.txbcantcomprar.Name = "txbcantcomprar";
            this.txbcantcomprar.Size = new System.Drawing.Size(75, 20);
            this.txbcantcomprar.TabIndex = 5;
            this.txbcantcomprar.TextChanged += new System.EventHandler(this.txbadicionar_TextChanged);
            this.txbcantcomprar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcantcomprar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UNIDADES A COMPRAR DEL PRODUCTO";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(151, 53);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(105, 27);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(172, 20);
            this.txbcodigo.TabIndex = 7;
            this.txbcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CODIGO DEL PRODUCTO";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(129, 71);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Añadir !!!";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Comprar2
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
            this.Name = "Comprar2";
            this.Text = "Comprar2";
            this.grpadicionar.ResumeLayout(false);
            this.grpadicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox grpadicionar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txbcantcomprar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnañadircarrito;
    }
}