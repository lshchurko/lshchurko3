﻿namespace sorting_homework8
{
    class Office
    {
        List<Employee> _employees;

        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }
        public Office()
        {
            _employees = new List<Employee>();
        }
    }
}
