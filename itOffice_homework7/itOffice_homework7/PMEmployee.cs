namespace itOffice_homework7
{
    class PMEmployee:Employee,IAssignTasks
    {
        public string Certificates { get; set; }

        public PMEmployee(string fName, string jPosition, string cert) : base(fName, jPosition)
        {
            Certificates = cert;
        }


        public void AssignTask()
        {
            Console.WriteLine("Assign Tasks");
        }
    }
}
