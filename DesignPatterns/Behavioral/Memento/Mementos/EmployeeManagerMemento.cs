using Memento.Models;

namespace Memento.Mementos
{
    public class EmployeeManagerMemento
    {
        public int ManagerId { get; private set; }
        public Employee? Employee { get; private set; }

        public EmployeeManagerMemento(int id, Employee? e)
        {
            ManagerId = id;
            Employee = e;
        }
    }
}
