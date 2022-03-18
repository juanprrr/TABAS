namespace TABAS.BackEnd.Models
{
    public class PassengerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string LastName2 { get; set; }
        public string Password { get; set; }
        public List<PhoneDto> Phones { get; set; }
    }
}
