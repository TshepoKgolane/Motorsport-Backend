namespace Motorsport.Model.DTO
{
    public class DriverDto
    {
        //This is the responce model
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Nationality { get; set; }

    }
}
