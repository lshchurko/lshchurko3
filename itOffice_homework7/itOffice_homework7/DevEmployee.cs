namespace itOffice_homework7
{
    class DevEmployee:Employee,ICoding
    {
        string DevTools { get; set; }

        public DevEmployee(string fName, string jPosition, string dTool) : base(fName, jPosition)
        {
            DevTools = dTool;
        }

        public void Coding()
        {
            Console.WriteLine("Code developing");
        }

    }
}
