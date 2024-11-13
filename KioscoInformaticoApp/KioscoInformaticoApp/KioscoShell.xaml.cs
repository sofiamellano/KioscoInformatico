using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Utils;
using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoApp.Views;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {
        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            RegisterRoute();
        }

        private void RegisterRoute()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView));
        }

        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;
            viewmodel.IsUserLogout = false;
        } 
        public void DisableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
        //private async void OnReceiveMessage(Message mensaje)
        //{
        //    if (mensaje.Value == "AbrirProductos")
        //    {
        //       // await Navigation.PushAsync(new ProductosView());
        //    }
        //    if (mensaje.Value == "AbrirOfertas")
        //    {
        //       // await Navigation.PushAsync(new ProductosEnOferta());
        //    }
        //    if (mensaje.Value == "AgregarProducto")
        //    {
        //        //await Navigation.PushAsync(new AddEditProductoView());
        //    }
        //    if (mensaje.Value == "EditarProducto")
        //    {
        //       //await Navigation.PushAsync(new AddEditProductoView(mensaje.ProductoAEditar));
        //    }
        //}
    }
}
