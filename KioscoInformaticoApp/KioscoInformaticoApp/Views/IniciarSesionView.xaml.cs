using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Utils;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
        //BindingContext = new IniciarSesionViewModel();

        /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        
        if (mensaje.Value == "AbrirkioscoShell")
        {
            await Navigation.PushAsync(new KioscoShell());
        }
        if (mensaje.Value == "CerrarVentana")
        {
            await Navigation.PopAsync();
        }
        
    }
}