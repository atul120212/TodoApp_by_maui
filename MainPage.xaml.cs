using myFirstApp.ViewModel;

namespace myFirstApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

        }

        
    }

}
