using RegisterAndLogin.Models;

namespace RegisterAndLogin.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { id = 0, UserName = "marvyn", Password="bigbucks" } );
            knownUsers.Add(new UserModel { id = 1, UserName = "dennis", Password = "dna" });
            knownUsers.Add(new UserModel { id = 2, UserName = "rob", Password = "dawa" });
            knownUsers.Add(new UserModel { id = 3, UserName = "bobby", Password = "tampa" });
        }
        public bool isValid(UserModel user)
        {
            return knownUsers.Any( x => x.UserName == user.UserName && x.Password == user.Password );
        }
    }
}
