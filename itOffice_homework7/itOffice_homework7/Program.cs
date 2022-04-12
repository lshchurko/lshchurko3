namespace itOffice_homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Office ls = new Office();

            ls.Employees.Add(new QAEmployee("J.K.", "QAEmployee", "QAtool1"));
            ls.Employees.Add(new DevEmployee("A.L.", "DevEmployee", "Devtool1"));
            ls.Employees.Add(new DevEmployee("O.M.", "DevEmployee", "Devtool2"));
            ls.Employees.Add(new BAEmployee("Ar.KW.", "BAEmployee",true));
            ls.Employees.Add(new PMEmployee("Q.U.", "PMEmployee", "Certificate1"));
            ls.Employees.Add(new QAAutomationEmployee("T.A.", "QAAutomationEmployee", "AutoQAtool1"));
            ls.Employees.Add(new QAAutomationTeamLead("P.P.", "QAAutomationTeamLead", "QA team"));
            ls.Employees.Add(new DevTEamLead("Z.L.", "DevTEamLead", "Dev1 Team"));
            ls.Employees.Add(new QATeamLead("K.J.", "QATeamLead", "QA Team2"));

            foreach (Employee employee in ls.Employees)
            {
                if (employee is ICoding || employee is ICodeReview || employee is IAssignTasks)
                {
                    if (employee is ICoding)
                    {
                        (employee as ICoding).Coding();
                        Console.WriteLine(employee.ToString());
                    }
                    if (employee is ICodeReview)
                    {
                        (employee as ICodeReview).CodeReview();
                        Console.WriteLine(employee.ToString());
                    }
                    if (employee is IAssignTasks)
                    {
                        (employee as IAssignTasks).AssignTask();
                        Console.WriteLine(employee.ToString());
                    }

                }
            }
        }
    }
}

