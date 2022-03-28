namespace sorting_homework8
{
    class DevEmployee : Employee, ICoding
    {
        string DevTools { get; set; }

        public DevEmployee(string fName, string jPosition,int tId, string dTool) : base(fName, jPosition,tId)
        {
            DevTools = dTool;
        }

        public void Coding()
        {
            Console.WriteLine("Code developing");
        }

    }
}

