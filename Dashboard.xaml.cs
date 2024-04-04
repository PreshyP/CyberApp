
using Newtonsoft.Json;

namespace CyberBullingApp2;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
		GetProfileInfo();
	}

    private void GetProfileInfo()
    {
		var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("", ""));
        //UserEmail.Text = userInfo.User.Email;
    }
}