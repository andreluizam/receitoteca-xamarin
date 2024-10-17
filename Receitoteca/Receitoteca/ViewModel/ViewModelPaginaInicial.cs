using Receitoteca.Views;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Receitoteca.ViewModel
{
    public class ViewModelPaginaInicial
    {
        public ICommand BtnStartClicked { get; set; }

        public ViewModelPaginaInicial()
        {
            BtnStartClicked = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Login());
            });
        }
    }
}
