using CyberBullingApp2.ViewModels;
using Microsoft.Maui.Controls;

namespace CyberBullingApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

    }

}
