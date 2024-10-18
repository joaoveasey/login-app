using login.api.Models;

namespace login.api.Interfaces
{
    public interface ILoginRepository
    {
        public Task<Login> Login(Login login);
    }
}
