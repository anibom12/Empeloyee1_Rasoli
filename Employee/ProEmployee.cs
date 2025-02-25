

namespace EmployeeService;

public class ProEmployee: Employee
{
    public override double Salary()
    {
        return base.Salary() * 1.5;
    }
}
