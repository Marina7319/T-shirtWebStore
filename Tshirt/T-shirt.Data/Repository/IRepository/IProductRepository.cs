namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Models.Models;

    public interface IProductRepository : IRepository<Product>
    {

        void Update(Product obj);

    }
}
