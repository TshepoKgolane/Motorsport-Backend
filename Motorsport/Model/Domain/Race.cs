using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Motorsport.Model.Domain
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> ParticipantDriverIds { get; set; }
    }
}
