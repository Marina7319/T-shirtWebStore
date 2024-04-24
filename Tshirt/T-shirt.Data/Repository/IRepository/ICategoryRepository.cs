namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Models.Models;

    public interface ICategoryRepository : IRepository<Category>
    {

        void Update(Category obj);

        void Save();

    }
}
