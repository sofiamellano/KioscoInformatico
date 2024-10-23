using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System.Diagnostics;

namespace KioscoInformaticoDesktop.GenerateCompraView
{
    public partial class RegistroVentaView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        GenericService<Venta> ventaService = new GenericService<Venta>();
        Venta venta = new Venta();

        public RegistroVentaView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            Stopwatch relog = new Stopwatch();
            relog.Start();

            #region Carga de combos
            await Task.WhenAll
                (
                    Task.Run(async () => comboBoxCliente.DataSource = await clienteService.GetAllAsync()),
                    Task.Run(async () => comboBoxProducto.DataSource = await productoService.GetAllAsync())
                );

            comboBoxCliente.DisplayMember = "Nombre";
            comboBoxCliente.ValueMember = "Id";
            comboBoxCliente.SelectedIndex = -1;

            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "Id";
            comboBoxProducto.SelectedIndex = -1;

            comboBoxFormadePago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            #endregion
            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetalleVentas.DataSource = venta.Detallesventa.ToList();

            relog.Stop();
            Debug.Print($"Tiempo de carga de combos: {relog.ElapsedMilliseconds} ms");
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedIndex != -1)
            {
                Producto producto = (Producto)comboBoxProducto.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = comboBoxProducto.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new DetalleVenta
            {
                Producto = (Producto)comboBoxProducto.SelectedItem,
                ProductoId = (int)comboBoxProducto.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            venta.Detallesventa.Add(detalleVenta);
            gridDetalleVentas.DataSource = venta.Detallesventa.ToList();
            comboBoxProducto.SelectedIndex = -1;
            comboBoxProducto.Focus();
            ActualizarTotalFactura();

        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = venta.Detallesventa.Sum(dv => dv.Cantidad * dv.PrecioUnitario);
        }

        private void gridDetalleVentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetalleVentas.OcultarColumnas(new string[] { "Id", "VentaId", "Venta", "ProductoId", "Eliminado" });
            btnQuitar.Enabled = gridDetalleVentas.Rows.Count > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetalleVentas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de venta");
                return;
            }
            var detalleVenta = (DetalleVenta)gridDetalleVentas.CurrentRow.DataBoundItem;
            venta.Detallesventa.Remove(detalleVenta);
            gridDetalleVentas.DataSource = venta.Detallesventa.ToList();
            ActualizarTotalFactura();
        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            // cargamos los datos de la venta
            venta.ClienteId = (int)comboBoxCliente.SelectedValue;
            venta.FormaPago = (FormaDePagoEnum)comboBoxFormadePago.SelectedValue;
            venta.Fecha = DateTime.Now;

            venta.Total = numericTotal.Value;
            venta.Iva = venta.Total * 0.21m;

            venta.Cliente = null;
            venta.Detallesventa.ToList().ForEach(dv => dv.Producto = null);
            venta.Detallesventa.ToList().ForEach(dv => dv.Venta = null);
            await ventaService.AddAsync(venta);
        }
    }
}
