namespace sorting_homework8
{
    class QAEmployee : Employee
    {
        public string QaTool { get; set; }

        public QAEmployee(string fName, string jPosition, int tId, string qTool) : base(fName, jPosition, tId)
        {
            QaTool = qTool;
        }
    }
}
