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
                // Trabalhar com nova pagina para criar conta
            });
        }
    }
}
