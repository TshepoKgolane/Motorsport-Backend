using Motorsport.Data;
using Motorsport.Model.Domain;
using Motorsport.Repositories.Interface;
using System.ComponentModel;

namespace Motorsport.Repositories.Business
{
    public class DriverRepository : IDriverRepository
    {
        private readonly MotorsportDbContext _dbContext;

        public DriverRepository(MotorsportDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<Driver> CreateAsync(Driver driver)
        {
            //adds the object to the database
            await _dbContext.Drivers.AddAsync(driver);
            //saves the database object to MSSQL
            await _dbContext.SaveChangesAsync();
            return driver;
            //Done with section 2
        }
    }
}
