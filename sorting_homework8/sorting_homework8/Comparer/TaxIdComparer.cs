namespace sorting_homework8.Comparer
{
    internal class TaxIdComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.TaxId > y.TaxId)
            {
                return 1;
            }
            else if (x.TaxId == y.TaxId)
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
