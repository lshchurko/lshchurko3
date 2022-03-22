namespace itOffice_homework7
{
    class QAAutomationTeamLead:Employee,IAssignTasks,ICodeReview, ICoding
    {
      public string Team { get; set; }

        public QAAutomationTeamLead(string fName, string jPosition, string teamQA) : base(fName, jPosition)
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
