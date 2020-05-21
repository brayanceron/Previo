namespace Previo
{
    partial class Eliminar
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
            this.txbeliminar = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.grpeliminar = new System.Windows.Forms.GroupBox();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpeliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbeliminar
            // 
            this.txbeliminar.Location = new System.Drawing.Point(129, 42);
            this.txbeliminar.Name = "txbeliminar";
            this.txbeliminar.Size = new System.Drawing.Size(75, 20);
            this.txbeliminar.TabIndex = 5;
            this.txbeliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbeliminar_KeyPress);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(159, 80);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(13, 13);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "?";
            // 
            // grpeliminar
            // 
            this.grpeliminar.Controls.Add(this.btnquitar);
            this.grpeliminar.Controls.Add(this.txbeliminar);
            this.grpeliminar.Controls.Add(this.label2);
            this.grpeliminar.Location = new System.Drawing.Point(33, 99);
            this.grpeliminar.Name = "grpeliminar";
            this.grpeliminar.Size = new System.Drawing.Size(298, 100);
            this.grpeliminar.TabIndex = 9;
            this.grpeliminar.TabStop = false;
            this.grpeliminar.Text = "Menu Adicionar";
            this.grpeliminar.Visible = false;
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(129, 71);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 6;
            this.btnquitar.Text = "QUITAR";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
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
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(153, 54);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(107, 28);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(172, 20);
            this.txbcodigo.TabIndex = 7;
            this.txbcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CODIGO DEL PRODUCTO";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.grpeliminar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.grpeliminar.ResumeLayout(false);
            this.grpeliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbeliminar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox grpeliminar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.Label label1;
    }
}