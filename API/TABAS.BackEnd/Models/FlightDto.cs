namespace TABAS.BackEnd.Models
{
    /// <summary>
    /// This class is assigned for the flights data.
    /// </summary>
    public class FlightDto
    {
        public int Fligth_number { get; set; }
        public string State { get; set; }
        public int Capacity { get; set; }
        public int Total_suitcases { get; set; }
        public AirplaneDto Airplane { get; set; }
        public DateTime Schedule { get; set; }
    }
}
