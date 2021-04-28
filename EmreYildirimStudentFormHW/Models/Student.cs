using System;
using System.ComponentModel.DataAnnotations;

namespace EmreYildirimStudentFormHW.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Surname { get; set; }
        
        public string Department { get;  set; }
        
        [Range(0, 4)]
        public float? Gpa { get; set; }
        
        [Required]
        public string Email { get;  set; }
       
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        public float? Height { get; set; }

        public float? Weight { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public DateTime LastUpdateDate { get; set; }
        
        
    }
}