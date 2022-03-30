using Command.Interfaces.Receivers;
using Command.Models;
using System.Text;

namespace Command.Receivers
{
    /// <summary>
    /// Receiver.
    /// </summary>
    public class EmployeeManagerReceiver : IEmployeeManagerReceiver
    {
        private List<Manager> _managers = new()
        {
            new Manager(1, "JAMES JOYCE"),
            new Manager(2, "FLANN O'BRIEN")
        };

        public void Add(int managerId, Employee employee) => 
            _managers.First(m => m.Id == managerId).Employees.Add(employee);

        public bool Exists(int managerId, int employeeId) =>
            _managers.First(m => m.Id == managerId).
            Employees.Any(e => e.Id == employeeId);

        public void Remove(int managerId, Employee employee) =>
            _managers.First(m => m.Id == managerId).Employees.Remove(employee);

        public string Write()
        {
            StringBuilder sb = new StringBuilder { };

            foreach (var manager in _managers)
            {
                sb.Append($"MANAGER {manager.Id}, {manager.Name} ");

                if (manager.Employees.Any())
                {
                    foreach(var employee in manager.Employees)
                    {
                        sb.Append($"EMPLOYEE {employee.Id}, {employee.Name} ");
                    }
                }
            }

            return sb.ToString().Trim();
        }
    }
}
