using Receitoteca.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace Receitoteca.ViewModel
{
    public class ViewModelLogin
    {
        public ICommand TapCriarConta { get; set; }

        public ViewModelLogin()
        {
            TapCriarConta = new Command(async() =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new CriarConta());
            });
        }
    }
}
