namespace TABAS.BackEnd.Models
{
    /// <summary>
    /// This class is assigned for the suitcases data.
    /// </summary>
    public class SuitcaseDto
    {
        public int Number { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public int Passenger_id { get; set; }
        public int BagCart_id { get; set; }
        public int Flight_number { get; set; }
    }
}
