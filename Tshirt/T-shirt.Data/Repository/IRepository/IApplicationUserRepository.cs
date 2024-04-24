namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Models.Models;

    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        public void Update(ApplicationUser applicationUser);
    }
}
