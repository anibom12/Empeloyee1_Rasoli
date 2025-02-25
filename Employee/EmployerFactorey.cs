using System.Security.Cryptography.X509Certificates;

namespace EmployeeService
{
    public static class EmployerFactory
    {
        public static Employee CreateEmployee(string? employeeType, string? nationalCode)
        {
            try
            {
                switch (employeeType.ToLower().Replace(" ", ""))
                {
                    case "simpleemployee":
                        return new SimpleEmployee { NationalCode = nationalCode };

                    case "proemployee":
                        return new ProEmployee { NationalCode = nationalCode };

                    case "simplemanager":
                        return new SimpleManager { NationalCode = nationalCode };

                    case "promanager":
                        return new ProManager { NationalCode = nationalCode };

                    default:
                        throw new ArgumentException("Invalid employee type");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
