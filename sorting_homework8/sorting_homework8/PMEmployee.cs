namespace sorting_homework8
{
    class PMEmployee : Employee, IAssignTasks
    {
        public string Certificates { get; set; }

        public PMEmployee(string fName, string jPosition, int tId, in string cert) : base(fName, jPosition, tId)
        {
            Certificates = cert;
        }


        public void AssignTask()
        {
            Console.WriteLine("Assign Tasks");
        }
    }
}
