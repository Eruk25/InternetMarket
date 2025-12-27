using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetMarket.UserService.Domain;

namespace InternetMarket.UserService.Application.Abstractions.Repositories
{
    public interface UserRepository
    {
        public Task<IEnumerable<User>> GetAllAsync();
        public Task<User?> GetByIdAsync(Guid Id);
        public Task<User?> GetByEmailAsync(Guid Id);
        public Task CreateAsync(User user);
        public Task UpdateAsync(User user);
        public Task DeleteAsync(User user);
    }
}