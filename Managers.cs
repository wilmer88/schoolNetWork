namespace notCorporate
{
    public class Managers
    {
        public string managerName;
        public string department;
        public Array responsibilitys;
        public bool hasStripes = false;
        public double allowPaymentOf = 1000;
        public object ShowSelf => managerName;
        public Managers(double amount, Array jobs, string _name, string depart)
        {
            _name = managerName;
            amount = allowPaymentOf;
            jobs = responsibilitys;
            depart = department;
        }
    
    }
}

