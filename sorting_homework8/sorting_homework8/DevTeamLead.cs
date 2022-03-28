namespace sorting_homework8
{
    class DevTEamLead : Employee, ICoding, ICodeReview, IAssignTasks
    {
        string DevTeam { get; set; }

        public DevTEamLead(string fName, string jPosition, int tId, string dTeam) : base(fName, jPosition, tId)
        {
            DevTeam = dTeam;
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
