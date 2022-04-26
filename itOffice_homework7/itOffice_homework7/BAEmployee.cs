namespace itOffice_homework7
{
    class BAEmployee:Employee
    {
        public bool Uml { get; set; }
        public BAEmployee(string fName, string jPosition, bool uml) : base(fName, jPosition)
        {
            Uml = uml;
        }
    }
}
