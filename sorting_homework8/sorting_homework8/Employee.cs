namespace sorting_homework8
{
    abstract class Employee
    {
        public string FullName { get; private set; }
        public string JobPosition { get; private set; }

        public int TaxId { get; private set; }

        public Employee(string fullName, string jobPosition, int taxId)
        {
            FullName = fullName;
            JobPosition = jobPosition;
            TaxId = taxId;
        }

        public override string ToString()
        {
            return FullName + " " + JobPosition+" "+TaxId;
        }
    }
}
