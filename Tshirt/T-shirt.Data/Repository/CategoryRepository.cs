namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {

        private readonly TshirtStoreDbContext database;

        public CategoryRepository(TshirtStoreDbContext db) : base(db) //CategoryRepository
        {
            database = db;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj) // Update
        {
            database.Categories.Update(obj);
        }
    }
}
