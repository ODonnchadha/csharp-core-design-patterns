using Command.Models;

namespace Command.Interfaces.Receivers
{
    /// <summary>
    /// Receiver.
    /// </summary>
    public interface IEmployeeManagerReceiver
    {
        void Add(int managerId, Employee employee);
        void Remove(int managerId, Employee employee);
        bool Exists(int managerId, int employeeId);
        string Write();
    }
}
