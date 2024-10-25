namespace KioscoInformaticoDesktop.GenerateCompraView
{
    partial class RegistroVentaView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            comboBoxCliente = new ComboBox();
            comboBoxFormadePago = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            gridDetalleVentas = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBoxProducto = new ComboBox();
            panel1 = new Panel();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            numericSubtotal = new NumericUpDown();
            numericCantidad = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            label10 = new Label();
            btnFinalizarVenta = new FontAwesome.Sharp.IconButton();
            btnQuitar = new FontAwesome.Sharp.IconButton();
            numericTotal = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)gridDetalleVentas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(260, 65);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(198, 23);
            comboBoxCliente.TabIndex = 26;
            // 
            // comboBoxFormadePago
            // 
            comboBoxFormadePago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormadePago.FormattingEnabled = true;
            comboBoxFormadePago.Location = new Point(37, 65);
            comboBoxFormadePago.Name = "comboBoxFormadePago";
            comboBoxFormadePago.Size = new Size(172, 23);
            comboBoxFormadePago.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 28;
            label1.Text = "Forma de Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 29;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 107);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 31;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 107);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 33;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 107);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 35;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 107);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 38;
            label6.Text = "Subtotal $";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(753, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(80, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // gridDetalleVentas
            // 
            gridDetalleVentas.AllowUserToAddRows = false;
            gridDetalleVentas.AllowUserToDeleteRows = false;
            gridDetalleVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDetalleVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridDetalleVentas.DefaultCellStyle = dataGridViewCellStyle2;
            gridDetalleVentas.Location = new Point(12, 195);
            gridDetalleVentas.Name = "gridDetalleVentas";
            gridDetalleVentas.ReadOnly = true;
            gridDetalleVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridDetalleVentas.Size = new Size(692, 173);
            gridDetalleVentas.TabIndex = 40;
            gridDetalleVentas.DataBindingComplete += gridDetalleVentas_DataBindingComplete;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 390);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 42;
            label7.Text = "NETO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 390);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 44;
            label8.Text = "IVA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(522, 390);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 46;
            label9.Text = "TOTAL";
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(37, 137);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(172, 23);
            comboBoxProducto.TabIndex = 49;
            comboBoxProducto.SelectedIndexChanged += comboBoxProducto_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(numericPrecio);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 83);
            panel1.TabIndex = 50;
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
            btnAgregar.Location = new Point(697, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 54);
            btnAgregar.TabIndex = 52;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(700, 29);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 51;
            label10.Text = "Fecha";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFinalizarVenta.BackColor = Color.OrangeRed;
            btnFinalizarVenta.ForeColor = Color.White;
            btnFinalizarVenta.IconChar = FontAwesome.Sharp.IconChar.GetPocket;
            btnFinalizarVenta.IconColor = Color.White;
            btnFinalizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFinalizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarVenta.Location = new Point(697, 402);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(136, 54);
            btnFinalizarVenta.TabIndex = 52;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
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
            btnQuitar.Location = new Point(710, 252);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(108, 54);
            btnQuitar.TabIndex = 53;
            btnQuitar.Text = "Quitar";
            btnQuitar.TextAlign = ContentAlignment.MiddleRight;
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(477, 420);
            numericTotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(120, 23);
            numericTotal.TabIndex = 54;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(297, 420);
            numericUpDown2.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 55;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Enabled = false;
            numericUpDown3.Location = new Point(101, 420);
            numericUpDown3.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 56;
            numericUpDown3.TextAlign = HorizontalAlignment.Right;
            // 
            // RegistroVentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(858, 479);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericTotal);
            Controls.Add(btnQuitar);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(label10);
            Controls.Add(comboBoxProducto);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gridDetalleVentas);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFormadePago);
            Controls.Add(comboBoxCliente);
            Controls.Add(panel1);
            Name = "RegistroVentaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)gridDetalleVentas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxFormadePago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridView gridDetalleVentas;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxProducto;
        private Panel panel1;
        private NumericUpDown numericPrecio;
        private NumericUpDown numericSubtotal;
        private NumericUpDown numericCantidad;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnFinalizarVenta;
        private FontAwesome.Sharp.IconButton btnQuitar;
        private NumericUpDown numericTotal;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
    }
}