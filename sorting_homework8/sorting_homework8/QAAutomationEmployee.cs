namespace sorting_homework8
{
    class QAAutomationEmployee : Employee, ICoding
    {
        string AutomationTool { get; set; }

        public QAAutomationEmployee(string fName, string jPosition,int tId, string autoTool) : base(fName, jPosition, tId)
        {
            AutomationTool = autoTool;
        }

        public void Coding()
        {
            Console.WriteLine("Code developing");
        }
    }
}
