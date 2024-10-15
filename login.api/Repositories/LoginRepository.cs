using login.api.Interfaces;
using login.api.Models;

namespace login.api.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public Task<Login> Login(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
