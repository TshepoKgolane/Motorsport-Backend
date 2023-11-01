using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motorsport.Model.DTO;
using Motorsport.Model.Domain;
using Motorsport.Data;
using Motorsport.Repositories.Interface;

namespace Motorsport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverRepository _driverRepository;

        public DriversController(IDriverRepository driverRepository)
        {
            this._driverRepository = driverRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateDriver(CreateDriverRequest request)
        {
            try
            {
                var driver = new Driver
                {
                    Name = request.Name,
                    LastName = request.LastName,
                    Team = request.Team,
                    Nationality = request.Nationality,
                    RaceId = request.RaceId
                };

                //This is taking the data from this object and sending it to the interface which inturn sends it to the business class that implements the interface where the operation of saving
                //the data to the database will take place
                await _driverRepository.CreateAsync(driver);
                if (!driver.Name.Equals("string") && !driver.LastName.Equals("string") && !driver.Team.Equals("string")
                    && !driver.Nationality.Equals("string"))
                {
                    var response = new Driver
                    {
                        Id = driver.Id,
                        Name = driver.Name,
                        LastName = driver.LastName,
                        Team = driver.Team,
                        Nationality = driver.Nationality,
                        RaceId = driver.RaceId
                    };
                    return Ok(response);
                }
                return this.BadRequest();


                //in roder to throw a BadRequest 400-Error
                //return BadRequest(responce);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult<> GetDriver()
        {

        }
    }
}
