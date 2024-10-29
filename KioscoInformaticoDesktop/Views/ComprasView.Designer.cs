namespace KioscoInformaticoDesktop.Views
{
    partial class ComprasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericTotal = new NumericUpDown();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            btnFinalizarCompra = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            comboBoxProducto = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            gridDetalleCompras = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxFormadePago = new ComboBox();
            comboBoxProveedor = new ComboBox();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            numericSubtotal = new NumericUpDown();
            numericCantidad = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetalleCompras).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Enabled = false;
            numericUpDown3.Location = new Point(79, 406);
            numericUpDown3.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 77;
            numericUpDown3.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(275, 406);
            numericUpDown2.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 76;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(455, 406);
            numericTotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(120, 23);
            numericTotal.TabIndex = 75;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnQuitar
            // 
            btnQuitar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnQuitar.BackColor = Color.OrangeRed;
            btnQuitar.ForeColor = Color.White;
            btnQuitar.IconChar = FontAwesome.Sharp.IconChar.PersonDigging;
            btnQuitar.IconColor = Color.White;
            btnQuitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(682, 244);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(108, 54);
            btnQuitar.TabIndex = 74;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextAlign = ContentAlignment.MiddleRight;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnFinalizarCompra
            // 
            btnFinalizarCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarCompra.BackColor = Color.OrangeRed;
            btnFinalizarCompra.ForeColor = Color.White;
            btnFinalizarCompra.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
            btnFinalizarCompra.IconColor = Color.White;
            btnFinalizarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarCompra.Location = new Point(652, 384);
            btnFinalizarCompra.Name = "btnFinalizarCompra";
            btnFinalizarCompra.Size = new Size(136, 54);
            btnFinalizarCompra.TabIndex = 73;
            btnFinalizarCompra.Text = "Finalizar Compra";
            btnFinalizarCompra.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarCompra.UseVisualStyleBackColor = false;
            btnFinalizarCompra.Click += btnFinalizarCompra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(652, 15);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 72;
            label10.Text = "Fecha";
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(15, 123);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(172, 23);
            comboBoxProducto.TabIndex = 70;
            comboBoxProducto.SelectedIndexChanged += comboBoxProducto_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(500, 376);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 69;
            label9.Text = "TOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 376);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 68;
            label8.Text = "IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 376);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 67;
            label7.Text = "NETO";
            // 
            // gridDetalleCompras
            // 
            gridDetalleCompras.AllowUserToAddRows = false;
            gridDetalleCompras.AllowUserToDeleteRows = false;
            gridDetalleCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetalleCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gridDetalleCompras.DefaultCellStyle = dataGridViewCellStyle1;
            gridDetalleCompras.Location = new Point(12, 179);
            gridDetalleCompras.Name = "gridDetalleCompras";
            gridDetalleCompras.ReadOnly = true;
            gridDetalleCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetalleCompras.Size = new Size(664, 173);
            gridDetalleCompras.TabIndex = 66;
            gridDetalleCompras.DataBindingComplete += gridDetalleCompras_DataBindingComplete;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(705, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(80, 23);
            dateTimePicker1.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 93);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 64;
            label6.Text = "Subtotal $";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 93);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 63;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 93);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 62;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 93);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 61;
            label3.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 60;
            label2.Text = "Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 15);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 59;
            label1.Text = "Forma de Pago";
            // 
            // comboBoxFormadePago
            // 
            comboBoxFormadePago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormadePago.FormattingEnabled = true;
            comboBoxFormadePago.Location = new Point(282, 51);
            comboBoxFormadePago.Name = "comboBoxFormadePago";
            comboBoxFormadePago.Size = new Size(172, 23);
            comboBoxFormadePago.TabIndex = 58;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(15, 51);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(198, 23);
            comboBoxProveedor.TabIndex = 57;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(numericPrecio);
            panel1.Location = new Point(1, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(795, 83);
            panel1.TabIndex = 71;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.BackColor = Color.OrangeRed;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(675, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 54);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "&Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(532, 42);
            numericSubtotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(120, 23);
            numericSubtotal.TabIndex = 51;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(412, 42);
            numericCantidad.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(69, 23);
            numericCantidad.TabIndex = 50;
            numericCantidad.TextAlign = HorizontalAlignment.Center;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(247, 42);
            numericPrecio.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(120, 23);
            numericPrecio.TabIndex = 49;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // ComprasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(btnFinalizarCompra);
            Controls.Add(label10);
            Controls.Add(comboBoxProducto);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gridDetalleCompras);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFormadePago);
            Controls.Add(comboBoxProveedor);
            Controls.Add(panel1);
            Name = "ComprasView";
            Text = "ComprasView";
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetalleCompras).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericTotal;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private FontAwesome.Sharp.IconButton btnFinalizarCompra;
        private Label label10;
        private ComboBox comboBoxProducto;
        private Label label9;
        private Label label8;
        private Label label7;
        private DataGridView gridDetalleCompras;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxFormadePago;
        private ComboBox comboBoxProveedor;
        private Panel panel1;
        private NumericUpDown numericSubtotal;
        private NumericUpDown numericCantidad;
        private NumericUpDown numericPrecio;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}