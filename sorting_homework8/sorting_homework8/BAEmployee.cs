namespace sorting_homework8
{
    class BAEmployee : Employee
    {
        public bool Uml { get; set; }
        public BAEmployee(string fName, string jPosition, int tId, bool uml) : base(fName, jPosition,tId)
        {
            Uml = uml;
        }
    }
}
