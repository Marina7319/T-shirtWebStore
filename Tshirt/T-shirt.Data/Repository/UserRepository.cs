namespace T_shirt.Data.Repository
{

    using Microsoft.EntityFrameworkCore;

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class UserRepository : IUserRepository
    {

        public readonly TshirtStoreDbContext _context;

        public UserRepository(TshirtStoreDbContext context) 
        { 

            _context = context;
        
        }
        public bool Add(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _context.ApplicationUsers.ToListAsync();
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            return await _context.ApplicationUsers.FindAsync(id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(ApplicationUser user)
        {
            _context.Update(user);
            return Save();
        }
    }
}
