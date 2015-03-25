using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students_and_workers
{
    class Worker:Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay):base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHours
        {
            get
            {
                return (decimal)this.WeekSalary / this.WorkHoursPerDay;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Week salary:{2} Workhours per day:{3} Money per hour:{4}", this.FirstName, this.LastName, this.WeekSalary,this.WorkHoursPerDay, this.MoneyPerHours);
        }


    }
}
