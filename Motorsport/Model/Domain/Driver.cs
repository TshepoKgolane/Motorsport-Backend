using System.Xml.Linq;

namespace Motorsport.Model.Domain
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string Team{ get; set; }
        public string RaceId { get; set; }
    }
}
