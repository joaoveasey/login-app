using login.api.Infra;
using login.api.Interfaces;
using login.api.Models;

namespace login.api.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        private readonly ApplicationDbContext _context;

        public RegisterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Register> AddRegister(Register register)
        {
            await _context.AddAsync(register);

            _context.SaveChanges();

            return register;
        }

        public async Task<Register> DeleteRegister(int id)
        {
            Register register = _context.Registers.FirstOrDefault(x => x.Id == id);

            _context.Remove(register);
            _context.SaveChanges();

            return register;
        }

        public async Task<Register> UpdateRegister(int id, Register register)
        {
            _context.Update(register);
            _context.SaveChanges();

            return register;
        }
    }
}
