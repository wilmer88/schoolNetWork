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
        public double? hourlyRate;
        public RollType? rollType;
        public int []? studentGrades = new int[] {100,82 };
        public string[]? comments = new string[] {"does good work", "learns fast" };
        public DateTime? dob= new DateTime?();
        public DateTime? dateCreated= new DateTime?();
        const int minimalHoursWorkedUnit = 1;

        public SchoolFigure(string first, string last, string em, DateTime db, double rate, RollType roll, int [] grades,string [] notes, DateTime created) 
        {
            firstName = first;
            lastName = last;
            email = em;
            dateCreated = created;
            hourlyRate = rate;
            rollType = roll;
            studentGrades =  grades;
            comments = notes;
            dob = db;

        } 
    }
}
