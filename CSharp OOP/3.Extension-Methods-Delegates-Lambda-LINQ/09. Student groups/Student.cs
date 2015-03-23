using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Student_groups
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<decimal> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int fn, string tel, string email, List<decimal> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

    
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("First name: {0}", this.FirstName));
            result.AppendLine(String.Format("Last name: {0}", this.LastName));
            result.AppendLine(String.Format("FN: {0}", this.FN));
            result.AppendLine(String.Format("Tel: {0}", this.Tel));
            result.AppendLine(String.Format("Email: {0}", this.Email));
            result.AppendLine(String.Format("Marks: {0}", String.Join(", ",this.Marks)));
            result.AppendLine(String.Format("Group number: {0}", this.GroupNumber));

            return result.ToString();
        }
    }
}
