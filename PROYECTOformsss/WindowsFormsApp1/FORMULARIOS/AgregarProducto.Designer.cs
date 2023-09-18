namespace WindowsFormsApp1.FORMULARIOS
{
    partial class AgregarProducto
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
            this.btn_agregarReceta = new System.Windows.Forms.Button();
            this.panel_producto = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_compuesto = new System.Windows.Forms.RadioButton();
            this.rb_simple = new System.Windows.Forms.RadioButton();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.a_la_venta = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdbtnSi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pane_proSimple = new System.Windows.Forms.Panel();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pane_precio = new System.Windows.Forms.Panel();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.panel_producto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.a_la_venta.SuspendLayout();
            this.pane_proSimple.SuspendLayout();
            this.pane_precio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregarReceta
            // 
            this.btn_agregarReceta.AutoSize = true;
            this.btn_agregarReceta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_agregarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarReceta.Location = new System.Drawing.Point(640, 252);
            this.btn_agregarReceta.Name = "btn_agregarReceta";
            this.btn_agregarReceta.Size = new System.Drawing.Size(212, 47);
            this.btn_agregarReceta.TabIndex = 26;
            this.btn_agregarReceta.Text = "AGREGAR PRODUCTO\r\n";
            this.btn_agregarReceta.UseVisualStyleBackColor = false;
            this.btn_agregarReceta.Visible = false;
            // 
            // panel_producto
            // 
            this.panel_producto.AutoSize = true;
            this.panel_producto.Controls.Add(this.button14);
            this.panel_producto.Controls.Add(this.fecha);
            this.panel_producto.Controls.Add(this.btn_agregarReceta);
            this.panel_producto.Controls.Add(this.label1);
            this.panel_producto.Controls.Add(this.label2);
            this.panel_producto.Controls.Add(this.groupBox1);
            this.panel_producto.Controls.Add(this.btn_guardar);
            this.panel_producto.Controls.Add(this.a_la_venta);
            this.panel_producto.Controls.Add(this.label5);
            this.panel_producto.Controls.Add(this.pane_proSimple);
            this.panel_producto.Controls.Add(this.pane_precio);
            this.panel_producto.Controls.Add(this.txtId);
            this.panel_producto.Controls.Add(this.comboCategoria);
            this.panel_producto.Controls.Add(this.txtNombre);
            this.panel_producto.Controls.Add(this.label14);
            this.panel_producto.Controls.Add(this.txtDescripcion);
            this.panel_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_producto.Location = new System.Drawing.Point(0, 0);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(873, 688);
            this.panel_producto.TabIndex = 25;
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Location = new System.Drawing.Point(481, 17);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_compuesto);
            this.groupBox1.Controls.Add(this.rb_simple);
            this.groupBox1.Location = new System.Drawing.Point(7, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 39);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // rb_compuesto
            // 
            this.rb_compuesto.AutoSize = true;
            this.rb_compuesto.Location = new System.Drawing.Point(199, 14);
            this.rb_compuesto.Name = "rb_compuesto";
            this.rb_compuesto.Size = new System.Drawing.Size(157, 17);
            this.rb_compuesto.TabIndex = 1;
            this.rb_compuesto.TabStop = true;
            this.rb_compuesto.Text = "PRODUCTO COMPUESTO";
            this.rb_compuesto.UseVisualStyleBackColor = true;
            // 
            // rb_simple
            // 
            this.rb_simple.AutoSize = true;
            this.rb_simple.Location = new System.Drawing.Point(50, 14);
            this.rb_simple.Name = "rb_simple";
            this.rb_simple.Size = new System.Drawing.Size(128, 17);
            this.rb_simple.TabIndex = 0;
            this.rb_simple.TabStop = true;
            this.rb_simple.Text = "PRODUCTO SIMPLE";
            this.rb_simple.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(654, 347);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(198, 62);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "GUARDAR PRODUCTO";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // a_la_venta
            // 
            this.a_la_venta.Controls.Add(this.radioButton2);
            this.a_la_venta.Controls.Add(this.rdbtnSi);
            this.a_la_venta.Location = new System.Drawing.Point(7, 120);
            this.a_la_venta.Name = "a_la_venta";
            this.a_la_venta.Size = new System.Drawing.Size(426, 32);
            this.a_la_venta.TabIndex = 19;
            this.a_la_venta.TabStop = false;
            this.a_la_venta.Text = "A LA VENTA";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdbtnSi
            // 
            this.rdbtnSi.AutoSize = true;
            this.rdbtnSi.Location = new System.Drawing.Point(101, 10);
            this.rdbtnSi.Name = "rdbtnSi";
            this.rdbtnSi.Size = new System.Drawing.Size(35, 17);
            this.rdbtnSi.TabIndex = 0;
            this.rdbtnSi.TabStop = true;
            this.rdbtnSi.Text = "SI";
            this.rdbtnSi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DESCRIPCIÓN";
            // 
            // pane_proSimple
            // 
            this.pane_proSimple.Controls.Add(this.txtStockMinimo);
            this.pane_proSimple.Controls.Add(this.label8);
            this.pane_proSimple.Controls.Add(this.txtStock);
            this.pane_proSimple.Controls.Add(this.txtMarca);
            this.pane_proSimple.Controls.Add(this.label7);
            this.pane_proSimple.Controls.Add(this.label6);
            this.pane_proSimple.Location = new System.Drawing.Point(3, 331);
            this.pane_proSimple.Name = "pane_proSimple";
            this.pane_proSimple.Size = new System.Drawing.Size(426, 86);
            this.pane_proSimple.TabIndex = 6;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(313, 58);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtStockMinimo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOCK MÍNIMO";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(83, 58);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(83, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "STOCK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MARCA";
            // 
            // pane_precio
            // 
            this.pane_precio.Controls.Add(this.txtPrecioVenta);
            this.pane_precio.Controls.Add(this.label4);
            this.pane_precio.Controls.Add(this.label15);
            this.pane_precio.Controls.Add(this.txtPrecioCosto);
            this.pane_precio.Location = new System.Drawing.Point(3, 201);
            this.pane_precio.Name = "pane_precio";
            this.pane_precio.Size = new System.Drawing.Size(426, 34);
            this.pane_precio.TabIndex = 15;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(101, 9);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO COSTO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "PRECIO VENTA";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(303, 6);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCosto.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 7;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(113, 162);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(120, 21);
            this.comboCategoria.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "CATEGORÍA";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 252);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(325, 73);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Text = "";
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(738, 121);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 32);
            this.button14.TabIndex = 29;
            this.button14.Text = "Volver";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(873, 688);
            this.Controls.Add(this.panel_producto);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.a_la_venta.ResumeLayout(false);
            this.a_la_venta.PerformLayout();
            this.pane_proSimple.ResumeLayout(false);
            this.pane_proSimple.PerformLayout();
            this.pane_precio.ResumeLayout(false);
            this.pane_precio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarReceta;
        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_compuesto;
        private System.Windows.Forms.RadioButton rb_simple;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox a_la_venta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdbtnSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pane_proSimple;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pane_precio;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button button14;
    }
}