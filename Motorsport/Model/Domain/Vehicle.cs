namespace Motorsport.Model.Domain
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string EngineManufacturer { get; set; }
        public double EnginePower { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
    }
}
