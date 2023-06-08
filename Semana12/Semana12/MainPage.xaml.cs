using Semana12.ViewModel;
using System;
using Xamarin.Forms;

namespace Semana12
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CalculatorDemoViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
        }

        void OnPageSizeChanged(object sender, EventArgs args)
        {
            if (Width < Height)
            {
                mainGrid.RowDefinitions[1].Height = GridLength.Auto;
                mainGrid.ColumnDefinitions[1].Width = new GridLength(0, GridUnitType.Absolute);

                Grid.SetRow(keypadGrid, 1);
                Grid.SetColumn(keypadGrid, 0);
            }
            else
            {
                mainGrid.RowDefinitions[1].Height = new GridLength(0, GridUnitType.Absolute);
                mainGrid.ColumnDefinitions[1].Width = GridLength.Auto;
                Grid.SetRow(keypadGrid, 0);
                Grid.SetColumn(keypadGrid, 1);
            }
        }
    }
}
