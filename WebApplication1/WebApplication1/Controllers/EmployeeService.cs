using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>();

            // Create 10 instances of each type of employee
            for (int i = 0; i < 10; i++)
            {
                employees.Add(new HourlyEmployee());
                employees.Add(new SalariedEmployee());
                employees.Add(new Manager());
            }
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void Work(int employeeIndex, int days)
        {
            if (employeeIndex >= 0 && employeeIndex < employees.Count)
            {
                employees[employeeIndex].Work(days);
            }
        }

        public void TakeVacation(int employeeIndex, float days)
        {
            if (employeeIndex >= 0 && employeeIndex < employees.Count)
            {
                employees[employeeIndex].TakeVacation(days);
            }
        }
    }
}
