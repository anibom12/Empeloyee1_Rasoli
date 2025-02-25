
namespace EmployeeService;

public class SimpleManager: Employee
{
    public override double Salary()
    {
        return base.Salary() * 1.7;
    }
}
