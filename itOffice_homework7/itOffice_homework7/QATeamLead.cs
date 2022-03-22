namespace itOffice_homework7
{
    class QATeamLead:Employee,IAssignTasks
    {
        public string TeamName { get; set; }

        public QATeamLead(string fName, string jPosition, string teamName) : base(fName, jPosition)
        {
            TeamName = teamName;
        }
        public void AssignTask()
        {
            Console.WriteLine("Assign Tasks");
        }
    }
}
