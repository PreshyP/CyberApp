
namespace CyberBullingApp2.ViewModels
{
    internal class FirebaseAuth
    {
        private FirebaseConfig firebaseConfig;

        public FirebaseAuth(FirebaseConfig firebaseConfig)
        {
            this.firebaseConfig = firebaseConfig;
        }

        public string FirebaseToken { get; internal set; }

        internal async Task CreateUserWithEmailAndPasswordAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        internal async Task SignInWithEmailAndPasswordAsync(string userName, string userPassword)
        {
            throw new NotImplementedException();
        }
    }
}