using login.api.Interfaces;
using login.api.Models;

namespace login.api.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        public Task<Register> AddRegister(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<Register> DeleteRegister(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Register> UpdateRegister(int id, Register register)
        {
            throw new NotImplementedException();
        }
    }
}
