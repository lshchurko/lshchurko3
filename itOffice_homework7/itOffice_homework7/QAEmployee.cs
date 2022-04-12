
namespace itOffice_homework7
{
     class QAEmployee:Employee
    {
      public string QaTool { get; set; }

        public QAEmployee(string fName, string jPosition, string qTool):base(fName,jPosition)
        {
            QaTool = qTool;
        }
    }
}
