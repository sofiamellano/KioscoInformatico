using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class ProductosEnOferta : ContentPage
{
	public ProductosEnOferta()
	{
        InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ProductosEnOfertaViewModel;
        //if (viewmodel.NotaSeleccionada != null)
        //{
        viewmodel.ObtenerProductos();
        //}
    }
}