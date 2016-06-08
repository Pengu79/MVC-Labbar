using System.Collections.Generic;

namespace Lab4.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Personnumber { get; set; }
        public string Adress { get; set; }
        public List<Grade> Grades { get; set; }
    }
}