namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Models.Models;

    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetAllUsers();

        Task<ApplicationUser> GetUserById(string id);

        bool Add(ApplicationUser user);

        bool Update(ApplicationUser user);

        bool Delete(ApplicationUser user);

        bool Save();
    }
}
