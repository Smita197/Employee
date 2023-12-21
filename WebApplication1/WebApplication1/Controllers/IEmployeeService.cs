using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        void Work(int employeeIndex, int days);
        void TakeVacation(int employeeIndex, float days);
    }
}