namespace sorting_homework8
{
    class QATeamLead : Employee, IAssignTasks
    {
        public string TeamName { get; set; }

        public QATeamLead(string fName, string jPosition, int tId, string teamName) : base(fName, jPosition, tId)
        {
            TeamName = teamName;
        }
        public void AssignTask()
        {
            Console.WriteLine("Assign Tasks");
        }
    }
}
