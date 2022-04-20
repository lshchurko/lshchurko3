using sorting_homework8.Comparer;

namespace sorting_homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Office ls = new Office();

            ls.Employees.Add(new QAEmployee("Jer.Kal.", "QAEmployee",1235, "QAtool1"));
            ls.Employees.Add(new DevEmployee("Ber.Ly.", "DevEmployee",2222, "Devtool1"));
            ls.Employees.Add(new DevEmployee("Ofrds.Mcsdc.", "DevEmployee",1000, "Devtool2"));
            ls.Employees.Add(new BAEmployee("Ar.KW.", "BAEmployee",2345, true));
            ls.Employees.Add(new PMEmployee("Q.U.", "PMEmployee",1111, "Certificate1"));
            ls.Employees.Add(new QAAutomationEmployee("Teffffsd.Asd.", "QAAutomationEmployee",3788, "AutoQAtool1"));
            ls.Employees.Add(new QAAutomationTeamLead("Pasd.Pds.", "QAAutomationTeamLead",9999, "QA team"));
            ls.Employees.Add(new DevTEamLead("Z.L.", "DevTEamLead",6895, "Dev1 Team"));
            ls.Employees.Add(new QATeamLead("K.J.", "QATeamLead",3285, "QA Team2"));

            int[] choiceResult= new[] {1,2,3,4};
           
            IComparer<Employee> comparer = null;

            foreach (int ind in choiceResult)
            {
                switch (ind)
                {
                    case 1:
                        comparer = new FullNameComparer();
                        Console.WriteLine("\n Sorting by Name");
                        break;
                    case 2:
                        comparer = new TaxIdComparer();
                        Console.WriteLine("\n Sorting by TaxId");
                        break;

                    case 3:
                        comparer = new LengthComparer();
                        Console.WriteLine("\n Sorting by Full Name Length");
                        break;

                    default:
                        comparer = new TaskAssignerComparer();
                        Console.WriteLine("\n Sorting by ITaskAssignerAndFullName");
                        break;

                }
                ls.Employees.Sort(comparer);

                foreach (Employee employee in ls.Employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            

        }
    }
}

