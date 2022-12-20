using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notCorporate
{
    internal class SchoolFigure
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public RollType rollType;
        public Array studentGrades; 

        public DateTime dob;


        const int minimalHoursWorkedUnit = 1;

        public SchoolFigure(string first, string last, string em, DateTime birthdate, double rate, RollType roll, Array grades) 
        {
            firstName = first;
            lastName = last;
            email = em;
            dob = birthdate;
            hourlyRate = rate;
            rollType = roll;
            studentGrades = grades;
        } 
    }
}
