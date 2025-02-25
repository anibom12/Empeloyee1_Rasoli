

namespace EmployeeService;

public class ProManager:Employee
{
    public override double Salary()
    {
        return base.Salary() * 2;
    }
}
