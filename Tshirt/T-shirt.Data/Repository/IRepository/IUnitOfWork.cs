namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Data.Repository.IRepository;

    public interface IUnitOfWork 
    {

        ICategoryRepository Category { get; }

        IProductRepository Product { get; }

        IApplicationUserRepository ApplicationUser { get; }


        void Save();

    }
}
