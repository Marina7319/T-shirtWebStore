namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private TshirtStoreDbContext _db;
        public ApplicationUserRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(ApplicationUser applicationUser)
        {
            _db.ApplicationUsers.Update(applicationUser);
        }
    }
}
