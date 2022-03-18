namespace TABAS.BackEnd.Models
{
    /// <summary>
    /// This class is assigned for the employees data.
    /// </summary>
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public string Password { get; set; }
        public RoleDto Role { get; set; }
    }
}
