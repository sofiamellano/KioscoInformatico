using KioscoInformaticoDesktop.Views;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoDesktop.GenerateCompraView;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void MenuItemSalirDelSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea salir del sistema?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MenuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void iconMenuItemProducto_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void iconMenuItemClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void iconMenuItemProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.ShowDialog();
        }

        private void iconMenuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesViewReport localidadesViewReport = new LocalidadesViewReport();
            localidadesViewReport.ShowDialog();
        }

        private void iconMenuClientes_Click(object sender, EventArgs e)
        {
            ClientesViewReport clientesViewReport = new ClientesViewReport();
            clientesViewReport.ShowDialog();
        }

        private void iconMenuItemVentas_Click(object sender, EventArgs e)
        {
            RegistroVentaView registroVentaView = new RegistroVentaView();
            registroVentaView.ShowDialog();
        }
    }
}
