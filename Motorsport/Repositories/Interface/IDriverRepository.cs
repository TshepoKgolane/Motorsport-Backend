using Motorsport.Model.Domain;

namespace Motorsport.Repositories.Interface
{
    public interface IDriverRepository
    {
        Task<Driver> CreateAsync(Driver driver);
    }
}
