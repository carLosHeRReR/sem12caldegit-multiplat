using Semana12.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana12
{
    public partial class App : Application
    {
        CalculatorDemoViewModel calculatorDemoViewModel;
        public App()
        {
            InitializeComponent();

            calculatorDemoViewModel = new CalculatorDemoViewModel();
            calculatorDemoViewModel.RestoreState(Current.Properties);

            MainPage = new MainPage(calculatorDemoViewModel);

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            calculatorDemoViewModel.SaveState(Current.Properties);
        }

        protected override void OnResume()
        {
        }
    }
}
