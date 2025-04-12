namespace ZARN04._11._25._07._08
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "ZARN04.11.25.07.08" };
        }
    }
}
