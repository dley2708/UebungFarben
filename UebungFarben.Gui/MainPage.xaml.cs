using UebungFarbe.Core.ViewModels;

namespace UebungFarben.Gui
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }

        
    }
}
