using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Receitoteca.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CriarConta : ContentPage
	{
		public CriarConta ()
		{
			InitializeComponent();
			BindingContext = new ViewModel.ViewModelCriarConta();
		}
	}
}