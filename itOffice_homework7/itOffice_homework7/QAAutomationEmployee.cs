namespace itOffice_homework7
{
    class QAAutomationEmployee:Employee,ICoding
    {
        string AutomationTool { get; set; }

        public QAAutomationEmployee(string fName, string jPosition, string autoTool) : base(fName, jPosition)
        {
            AutomationTool = autoTool;
        }

        public void Coding()
        {
            Console.WriteLine("Code developing");
        }
    }
}
