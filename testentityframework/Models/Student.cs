using System.ComponentModel.DataAnnotations;

namespace testentityframework.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Batch")]
        public string Batch { get; set; }
        //[Required(ErrorMessage = "Marks")]
        public int? Marks { get; set; }
    }    
}