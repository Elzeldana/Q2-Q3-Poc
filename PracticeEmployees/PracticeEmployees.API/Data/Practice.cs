namespace PracticeEmployees.API.Data
{
    public class Practice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Employee>Employees { get; set; }
    }
}