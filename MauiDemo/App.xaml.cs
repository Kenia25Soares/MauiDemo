namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

      
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new MinhaPagina());
            var minhaPagina = new MinhaPagina();

            var navPage = new NavigationPage(minhaPagina);

            navPage.BarBackgroundColor = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            return new Window(navPage);




        }
    }
}