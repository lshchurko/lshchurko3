
namespace sorting_homework8.Comparer
{
    internal class LengthComparer: IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.FullName.Length > y.FullName.Length)
            {
                return 1;
            }
            else if (x.FullName.Length == y.FullName.Length)
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
