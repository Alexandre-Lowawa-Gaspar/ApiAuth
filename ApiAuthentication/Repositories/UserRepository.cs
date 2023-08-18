using ApiAuthentication.Models;

namespace ApiAuthentication.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>()
            {
            new() {Id=1,UserName="Madara",Password="Suzano",Role="Hokage"},
            new() { Id = 2, UserName = "Naruto", Password = "Uzumaki", Role = "Jinnjurike" }
             };
            return users.FirstOrDefault(x => string.Equals(x.UserName, username,StringComparison.CurrentCultureIgnoreCase) && x.Password==password);
        }
    }
}
