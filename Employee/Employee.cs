namespace EmployeeService
{
    public abstract class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        private string? nationalCode;
        public string NationalCode
        {
            get => nationalCode;
            set
            {
                if (IsValidNationalCode(value))
                {
                    nationalCode = value;
                }
                else
                {
                    throw new ArgumentException("Invalid national code.");
                }
            }
        }

        public SaleryParameters SaleryParameters { get; set; } = new SaleryParameters();

        public void SetData(double baseSalary, int level, int totalHours, int extraTime)
        {
            SaleryParameters.BaseSalery = baseSalary;
            SaleryParameters.Level = level;
            SaleryParameters.TotalHourse = totalHours;
            SaleryParameters.ExtraTime = extraTime;
        }

        private bool IsValidNationalCode(string nationalCode)
        {
            if (nationalCode.Length != 10)
                return false;

            if (!long.TryParse(nationalCode, out _))
                return false;

            int[] digits = new int[10];
            for (int i = 0; i < 10; i++)
                digits[i] = int.Parse(nationalCode[i].ToString());

            int controlDigit = digits[9];
            int sum = 0;
            for (int i = 0; i < 9; i++)
                sum += digits[i] * (10 - i);

            int remainder = sum % 11;

            return (remainder < 2 && controlDigit == remainder) || (remainder >= 2 && controlDigit == 11 - remainder);
        }

        public virtual double Salary()
        {
            return SaleryParameters.BaseSalery * (1 + SaleryParameters.Level / 10) * SaleryParameters.TotalHourse +
                   SaleryParameters.BaseSalery * SaleryParameters.ExtraTime * (1 + SaleryParameters.Level / 10) * 1.2;
        }

        public virtual int InsuranceYears()
        {
            return SaleryParameters.Level * 2;
        }

        public override string ToString()
        {
            return $"Hello {FullName}, your National Code is: {NationalCode}, your salary is: ${Salary()}, your insurance years are: {InsuranceYears()}";
        }
    }
}
