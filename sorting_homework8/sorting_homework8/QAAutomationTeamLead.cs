namespace sorting_homework8
{
    class QAAutomationTeamLead : Employee, IAssignTasks, ICodeReview, ICoding
    {
        public string Team { get; set; }

        public QAAutomationTeamLead(string fName, string jPosition,int tId, string teamQA) : base(fName, jPosition, tId)
        {
            Team = teamQA;
        }

        public void Coding()
        {
            Console.WriteLine("Code developing");
        }

        public void AssignTask()
        {
            Console.WriteLine("Assign Tasks");
        }

        public void CodeReview()
        {
            Console.WriteLine("Review code");
        }
    }
}
