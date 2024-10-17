using System.Windows.Input;
using Xamarin.Forms;

namespace Receitoteca.ViewModel
{
    public class ViewModelCriarConta
    {
        public ICommand BtnCriarConta { get; set; }
        public ICommand TapLogar { get; set; }

        public ViewModelCriarConta()
        {
            BtnCriarConta = new Command(() => { Application.Current.MainPage.DisplayAlert("a", "a", "OK"); });
            TapLogar = new Command(async() => { await Application.Current.MainPage.Navigation.PopAsync(); });
        }
    }
}
