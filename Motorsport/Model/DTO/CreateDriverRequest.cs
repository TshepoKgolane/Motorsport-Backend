namespace Motorsport.Model.DTO
{
    public class CreateDriverRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public string Nationality { get; set; }
        public string RaceId { get; set; }
    }
}
