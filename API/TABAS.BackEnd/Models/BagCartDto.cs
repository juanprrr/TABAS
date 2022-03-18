namespace TABAS.BackEnd.Models
{
    /// <summary>
    /// This class is assigned for the bag carts data.
    /// </summary>
    public class BagCartDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Number_of_suitcases { get; set; }
        public string State { get; set; }
        public bool Stamp { get; set; }
    }
}
