namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    public class UnitOfWork : IUnitOfWork
    {

        public IApplicationUserRepository ApplicationUser { get; set; }

        public TshirtStoreDbContext database;

        public ICategoryRepository Category { get; set; }

        public IProductRepository Product { get; set; }


        public UnitOfWork(TshirtStoreDbContext db)
        {

            database = db;
            Category = new CategoryRepository(database);
            Product = new ProductRepository(database);
            ApplicationUser = new ApplicationUserRepository(database);



        }

        public void Save()
        {
            database.SaveChanges();
        }

    }
}
