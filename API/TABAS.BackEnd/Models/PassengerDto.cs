namespace TABAS.BackEnd.Models
{
    /// <summary>
    /// This class is assigned for the passengers data.
    /// </summary>
    public class PassengerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string LastName2 { get; set; }
        public string Password { get; set; }
        public List<int> Phones { get; set; }
    }
}
