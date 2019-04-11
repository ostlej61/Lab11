using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDictionary
{
    public class Employee
    {
        //variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}, Id: {2}", FirstName, LastName, Id);
        }

        #region Constructors
        //default constructor
        public Employee()
        {

        }

        //custom constructor
        public Employee(string inFName, string inLName, int inId)
        {
            FirstName = inFName;
            LastName = inLName;
            Id = inId;
        }
        #endregion


    }
}
