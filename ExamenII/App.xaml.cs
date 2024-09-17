using ExamenII.Views;

namespace ExamenII
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DescuentosView());
        }
    }
}
