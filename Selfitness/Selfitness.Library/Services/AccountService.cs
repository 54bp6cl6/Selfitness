using Microsoft.EntityFrameworkCore;
using Selfitness.Library.DbModels;
using System.Collections;

namespace Selfitness.Library.Services
{
    public class AccountService : BaseService
    {
        public AccountService(BaseServiceArgument baseArgument) : base(baseArgument) 
        {
        }

        public Task<bool> IsAccountExits(string account)
        {
            return _db.User.AnyAsync(x => x.Account == account);
        }

        public async Task CreateAccount(string account, string password)
        {
            var passwordHash = EncryptService.GetSHA256Strng(password);
            await _db.User.AddAsync(new User
            {
                Account = account,
                PasswordHash = passwordHash
            });
            await _db.SaveChangesAsync();
        }

        public Task<bool> IsPasswordCurrect(string account, string password)
        {
            var hash = EncryptService.GetSHA256Strng(password);
            return _db.User.AnyAsync(x => x.Account == account && 
                StructuralComparisons.StructuralEqualityComparer.Equals(x.PasswordHash, hash));
        }
    }
}
