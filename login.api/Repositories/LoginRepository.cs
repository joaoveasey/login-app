using login.api.Infra;
using login.api.Interfaces;
using login.api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace login.api.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public readonly ApplicationDbContext _context;

        public LoginRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Login> Login(Login login)
        {
            await _context.AddAsync(login);

            _context.SaveChanges();

            return login;
        }
    }
}
