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
            //return new Window(new AppShell());
            //var minhaPagina = new MinhaPagina();

            //var navPage = new NavigationPage(minhaPagina);

            //navPage.BarBackgroundColor = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;

            //var window = new Window(new StackLayoutDemo());

            //return window;
            var pagina = new StackLayoutDemo();
            return new Window(new NavigationPage(pagina));

        }
    }
}