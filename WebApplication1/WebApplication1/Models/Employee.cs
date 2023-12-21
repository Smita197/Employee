namespace WebApplication1.Models
{
    public abstract class Employee
    {
        public float VacationDays { get; protected set; } = 0;

        public abstract void Work(int days);

        public abstract void TakeVacation(float days);
    }

    public class HourlyEmployee : Employee
    {
        public override void Work(int days)
        {
            VacationDays += (days <= 260) ? 10 : 0;
        }

        public override void TakeVacation(float days)
        {
            VacationDays -= (days <= VacationDays) ? days : 0;
        }
    }

    public class SalariedEmployee : Employee
    {
        public override void Work(int days)
        {
            VacationDays += (days <= 260) ? 15 : 0;
        }

        public override void TakeVacation(float days)
        {
            VacationDays -= (days <= VacationDays) ? days : 0;
        }
    }

    public class Manager : SalariedEmployee
    {
        public override void Work(int days)
        {
            VacationDays += (days <= 260) ? 30 : 0;
        }
    }
}
