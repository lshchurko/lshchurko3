
namespace sorting_homework8.Comparer
{
    internal class FullNameComparer:IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
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
}
