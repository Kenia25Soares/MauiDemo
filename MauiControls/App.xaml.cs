using MauiControls.Pages;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AppShell());
            var pagina = new MauiPresentationControls();
            var navPage = new NavigationPage(pagina)
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };
            return new Window(navPage);

            //var window = new Window(new MauiPresentationControls());


            //return window;
        }
    }
}