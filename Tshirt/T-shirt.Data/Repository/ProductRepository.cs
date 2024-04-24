namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class ProductRepository : Repository<Product>, IProductRepository
    {

        private readonly TshirtStoreDbContext _db;

        public ProductRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
