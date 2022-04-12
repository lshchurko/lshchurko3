namespace itOffice_homework7
{
    abstract class Employee
    {
        public string FullName { get; private set; }
        public string JobPosition { get; private set; }

        public Employee(string fullName, string jobPosition)
        {
            FullName = fullName;
            JobPosition = jobPosition;
        }

        public override string ToString()
        {
            return FullName + " " + JobPosition;
        }
    }
}
