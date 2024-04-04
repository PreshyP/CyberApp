using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;

namespace CyberBullingApp2;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel(Navigation);
    }
}