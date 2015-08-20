using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Exception_handling
{
    public class ExamResult
    {
        private int minGrade;

        private int maxGrade;

        private int grade;

        private string comment;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                Validator.LessThanZero(value);
                this.grade = value;
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                Validator.LessThanZero(value);
                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                Validator.ValidateLessThanLength(value, 1, this.MinGrade);
                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get
            {
                return this.comment;
            }

            private set
            {
                Validator.ValidateString(value);
                this.comment = value;
            }
        }
    }
}
