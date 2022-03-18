namespace TABAS.BackEnd.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public string Password { get; set; }
        public RolDto Rol { get; set; }
    }
}
