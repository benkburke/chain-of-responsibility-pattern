namespace ChainOfResponsibilityPattern.Domain
{
    public abstract class Employee
    {
        protected Employee NextEmployee;

        protected void Next(Employee employee)
        {
            NextEmployee = employee;
        }

        public abstract void Handle(Report report);
    }
}
