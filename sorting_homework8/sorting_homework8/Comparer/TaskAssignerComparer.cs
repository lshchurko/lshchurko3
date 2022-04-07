
namespace sorting_homework8.Comparer
{
    internal class TaskAssignerComparer: IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {

            if (x is IAssignTasks)
                {
                if (y is not IAssignTasks)
                {
                    return -1;
                }
                else
                {
                    if (x.FullName[0] > y.FullName[0])
                    {
                        return 1;
                    }
                    else if (x.FullName[0] == y.FullName[0])
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                }

             else 
                { 
                return 1;
                }
            }

        }

        }
   