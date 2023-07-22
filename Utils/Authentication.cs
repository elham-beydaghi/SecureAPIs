using Microsoft.AspNetCore.Identity;

namespace SecureAPIs.Utils
{
    public static class Authentication
    {
        public async static Task<bool> AuthenticateWithUsernameAndPassword(string username, string password)
        {
            bool isAuthenticated = false;

            //var userManager = new UserManager<IdentityUser>(new UserStore);
            //var user = await userManager.FindByNameAsync(username);
            //if (user != null && await userManager.CheckPasswordAsync(user, password))
            //{
            //    isAuthenticated = true;
            //}

            return isAuthenticated;
        }

        public static bool AuthenticateWithToken(string token)
        {
            return true;
        }

        public static bool AuthenticateWithOAuth2(string provider, string accessToken)
        {
            return true;
        }

        public static bool AuthenticateWithGoogle(string accessToken)
        {
            return true;
        }
    }
}
