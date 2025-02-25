

using System.Security.Cryptography;

namespace EmployeeService;

public class SimpleEmployee: Employee
{
    public override double Salary()
    {
        return base.Salary() * 1;
    }
    


}

