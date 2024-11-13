using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KioscoInformaticoApp.ViewModels
{
    public partial class KioscoShellViewModel : ObservableObject
    {
        public IRelayCommand LogoutCommand { get; }

        [ObservableProperty]
        private bool isUserLogout = true;

        public KioscoShellViewModel()
        {
            LogoutCommand = new RelayCommand(Logout);
        }

        private void Logout()
        {
            IsUserLogout = true;
            (App.Current.MainPage as KioscoShell).DisableAppAfterLogin();
        }
    }
}
