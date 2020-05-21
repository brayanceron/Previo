namespace Previo

{
    partial class Tienda
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
            this.lblbienvenidoTienda = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbvender = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txbxvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.ListBox();
            this.txbunidades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcodigoproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxnombre_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcomprar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.lsbxmostradorcarrito = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbxmostrador = new System.Windows.Forms.ListBox();
            this.btncomprar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbvender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcomprar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbienvenidoTienda
            // 
            this.lblbienvenidoTienda.AutoSize = true;
            this.lblbienvenidoTienda.Location = new System.Drawing.Point(421, 9);
            this.lblbienvenidoTienda.Name = "lblbienvenidoTienda";
            this.lblbienvenidoTienda.Size = new System.Drawing.Size(135, 13);
            this.lblbienvenidoTienda.TabIndex = 1;
            this.lblbienvenidoTienda.Text = "Bienvenido a la AppTienda";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbvender);
            this.tabControl1.Controls.Add(this.tbcomprar);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 460);
            this.tabControl1.TabIndex = 2;
            // 
            // tbvender
            // 
            this.tbvender.Controls.Add(this.button2);
            this.tbvender.Controls.Add(this.txbxvalor);
            this.tbvender.Controls.Add(this.label4);
            this.tbvender.Controls.Add(this.btnactualizar);
            this.tbvender.Controls.Add(this.btnregistrar);
            this.tbvender.Controls.Add(this.groupBox1);
            this.tbvender.Controls.Add(this.txbunidades);
            this.tbvender.Controls.Add(this.label3);
            this.tbvender.Controls.Add(this.txbcodigoproducto);
            this.tbvender.Controls.Add(this.label2);
            this.tbvender.Controls.Add(this.tbxnombre_producto);
            this.tbvender.Controls.Add(this.label1);
            this.tbvender.Location = new System.Drawing.Point(4, 22);
            this.tbvender.Name = "tbvender";
            this.tbvender.Padding = new System.Windows.Forms.Padding(3);
            this.tbvender.Size = new System.Drawing.Size(952, 434);
            this.tbvender.TabIndex = 0;
            this.tbvender.Text = "VENDER";
            this.tbvender.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbxvalor
            // 
            this.txbxvalor.Location = new System.Drawing.Point(18, 268);
            this.txbxvalor.Name = "txbxvalor";
            this.txbxvalor.Size = new System.Drawing.Size(208, 20);
            this.txbxvalor.TabIndex = 10;
            this.txbxvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbunidades_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "VALOR DEL PRODUCTO";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(665, 324);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(93, 23);
            this.btnactualizar.TabIndex = 8;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(148, 321);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(78, 23);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "REGISTRAR ";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadicionar);
            this.groupBox1.Controls.Add(this.pantalla);
            this.groupBox1.Location = new System.Drawing.Point(312, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MIS PRODUCTOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(180, 274);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(243, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "ADICIONAR UNIDADES AUN PRODUCTO";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // pantalla
            // 
            this.pantalla.FormattingEnabled = true;
            this.pantalla.Location = new System.Drawing.Point(6, 32);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(417, 238);
            this.pantalla.TabIndex = 0;
            // 
            // txbunidades
            // 
            this.txbunidades.Location = new System.Drawing.Point(18, 209);
            this.txbunidades.Name = "txbunidades";
            this.txbunidades.Size = new System.Drawing.Size(208, 20);
            this.txbunidades.TabIndex = 5;
            this.txbunidades.TextChanged += new System.EventHandler(this.txbunidades_TextChanged);
            this.txbunidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbunidades_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UNIDADES  EN VENTA DEL PRODUCTO";
            // 
            // txbcodigoproducto
            // 
            this.txbcodigoproducto.Enabled = false;
            this.txbcodigoproducto.Location = new System.Drawing.Point(18, 120);
            this.txbcodigoproducto.Name = "txbcodigoproducto";
            this.txbcodigoproducto.Size = new System.Drawing.Size(208, 20);
            this.txbcodigoproducto.TabIndex = 3;
            this.txbcodigoproducto.TextChanged += new System.EventHandler(this.txbcodigoproducto_TextChanged);
            this.txbcodigoproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbunidades_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO DEL PRODUCTO";
            // 
            // tbxnombre_producto
            // 
            this.tbxnombre_producto.Location = new System.Drawing.Point(18, 50);
            this.tbxnombre_producto.Name = "tbxnombre_producto";
            this.tbxnombre_producto.Size = new System.Drawing.Size(208, 20);
            this.tbxnombre_producto.TabIndex = 1;
            this.tbxnombre_producto.TextChanged += new System.EventHandler(this.tbxnombre_producto_TextChanged);
            this.tbxnombre_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxnombre_producto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL PRODUCTO";
            // 
            // tbcomprar
            // 
            this.tbcomprar.Controls.Add(this.groupBox3);
            this.tbcomprar.Controls.Add(this.groupBox2);
            this.tbcomprar.Location = new System.Drawing.Point(4, 22);
            this.tbcomprar.Name = "tbcomprar";
            this.tbcomprar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcomprar.Size = new System.Drawing.Size(952, 434);
            this.tbcomprar.TabIndex = 1;
            this.tbcomprar.Text = "COMPRAR";
            this.tbcomprar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbltotal);
            this.groupBox3.Controls.Add(this.btnquitar);
            this.groupBox3.Controls.Add(this.lsbxmostradorcarrito);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(605, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 411);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CARRITO";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(16, 385);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(125, 13);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "TOTAL DE LA COMPRA";
            this.lbltotal.Visible = false;
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(168, 354);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 2;
            this.btnquitar.Text = "QUITAR";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // lsbxmostradorcarrito
            // 
            this.lsbxmostradorcarrito.FormattingEnabled = true;
            this.lsbxmostradorcarrito.Location = new System.Drawing.Point(19, 32);
            this.lsbxmostradorcarrito.Name = "lsbxmostradorcarrito";
            this.lsbxmostradorcarrito.Size = new System.Drawing.Size(305, 316);
            this.lsbxmostradorcarrito.TabIndex = 0;
            this.lsbxmostradorcarrito.SelectedIndexChanged += new System.EventHandler(this.lsbxmostradorcarrito_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbxmostrador);
            this.groupBox2.Controls.Add(this.btncomprar);
            this.groupBox2.Location = new System.Drawing.Point(15, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 411);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTOS DISPONIBLES PARA COMPRAR";
            // 
            // lsbxmostrador
            // 
            this.lsbxmostrador.FormattingEnabled = true;
            this.lsbxmostrador.Location = new System.Drawing.Point(0, 43);
            this.lsbxmostrador.Name = "lsbxmostrador";
            this.lsbxmostrador.Size = new System.Drawing.Size(540, 355);
            this.lsbxmostrador.TabIndex = 0;
            this.lsbxmostrador.SelectedIndexChanged += new System.EventHandler(this.lsbxmostrador_SelectedIndexChanged);
            // 
            // btncomprar
            // 
            this.btncomprar.Location = new System.Drawing.Point(409, 19);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(131, 23);
            this.btncomprar.TabIndex = 1;
            this.btncomprar.Text = "AÑADIR AL CARRITO";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblbienvenidoTienda);
            this.MaximizeBox = false;
            this.Name = "Tienda";
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.Tienda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbvender.ResumeLayout(false);
            this.tbvender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbcomprar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenidoTienda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbvender;
        private System.Windows.Forms.TextBox tbxnombre_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbcomprar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbunidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbcodigoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.ListBox pantalla;
        private System.Windows.Forms.TextBox txbxvalor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.ListBox lsbxmostrador;
        private System.Windows.Forms.Button btncomprar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbxmostradorcarrito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltotal;
    }
}