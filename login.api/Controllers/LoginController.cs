using login.api.Infra;
using login.api.Models;
using login.api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace login.api.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly LoginRepository? _loginRepository;
        public ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
            _loginRepository = new LoginRepository(context);
        }

        [HttpPost]
        public async Task<ActionResult<Login>> Login(Login login)
        {
            try
            {
                var result = await _loginRepository.Login(login);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro na tentativa login, tente novamente mais tarde." + ex.Message);
            }
        }
    }
}
