using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeEmployees.API.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        [ForeignKey(nameof(PracticeId))]
        public int PracticeId { get; set; }

        public Practice Practice { get; set; }
    }
}
