using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Utils;
using KioscoInformaticoApp.Views;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
            {
                OnReceiveMessage(mensaje);
            });
        }

        private async void OnReceiveMessage(Message mensaje)
        {
            if (mensaje.Value == "AbrirProductos")
            {
               // await Navigation.PushAsync(new ProductosView());
            }
            if (mensaje.Value == "AbrirOfertas")
            {
               // await Navigation.PushAsync(new ProductosEnOferta());
            }
            if (mensaje.Value == "AgregarProducto")
            {
                //await Navigation.PushAsync(new AddEditProductoView());
            }
            if (mensaje.Value == "EditarProducto")
            {
               //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
            }
        }
    }
}
