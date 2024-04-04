
namespace CyberBullingApp2.ViewModels
{
    internal class FirebaseConfig
    {
        private string webApiKey;
        private INavigation navigation;

        public FirebaseConfig(string webApiKey)
        {
            this.webApiKey = webApiKey;
        }

        public FirebaseConfig(string webApiKey, INavigation navigation)
        {
            this.webApiKey = webApiKey;
            this.navigation = navigation;
        }
    }
}