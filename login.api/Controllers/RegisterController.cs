using login.api.Infra;
using login.api.Models;
using login.api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace login.api.Controllers
{
    public class RegisterController : ControllerBase
    {
        private readonly RegisterRepository? _registerRepository;
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
            _registerRepository = new RegisterRepository(context);
        }

        [HttpPost]
        public async Task<ActionResult<Register>> AddRegister(Register register)
        {
            try
            {
                var result = await _registerRepository.AddRegister(register);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro na tentativa de registro, tente novamente mais tarde." + ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Register>> DeleteRegister(int id)
        {
            try
            {
                var result = await _registerRepository.DeleteRegister(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro na tentativa de exclusão, tente novamente mais tarde." + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Register>> UpdateRegister(int id, Register register)
        {
            try
            {
                var result = await _registerRepository.UpdateRegister(id, register);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um erro na tentativa de atualização, tente novamente mais tarde." + ex.Message);
            }
        }
    }
}
