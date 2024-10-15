using login.api.Models;

namespace login.api.Interfaces
{
    public interface IRegisterRepository
    {
        public Task<Register> AddRegister(Register register);
        public Task<Register> UpdateRegister(int id, Register register);
        public Task<Register> DeleteRegister(int id);
    }
}
