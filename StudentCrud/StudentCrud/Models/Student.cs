using System.ComponentModel.DataAnnotations;

namespace StudentCrud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string City { get; set; }
        public int Mobile { get; set; }
    }
}
