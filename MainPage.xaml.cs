using Todo_MAUI.ViewModel;

namespace Todo_MAUI
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }

        
    }

}
