using Memento.Interfaces.Commands;
using Memento.Interfaces.Receivers;
using Memento.Mementos;
using Memento.Models;

namespace Memento.Commands
{
    public class EmployeeCommand : ICommand
    {
        private int _id;
        private readonly IEmployeeManagerReceiver _receiver;
        private Employee? _employee;
        public EmployeeCommand(
            int id,
            Employee? employee,
            IEmployeeManagerReceiver receiver)
        {
            _id = id;
            _employee = employee;
            _receiver = receiver;
        }

        /// <summary>
        /// Originator.
        /// </summary>
        /// <returns></returns>
        public EmployeeManagerMemento CreateMemento() => new EmployeeManagerMemento(_id, _employee);

        /// <summary>
        /// Originator.
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(EmployeeManagerMemento memento)
        {
            _id = memento.ManagerId;
            _employee = memento.Employee;
        }
        public bool CanExecute()
        {
            if (_employee == null)
            {
                return false;
            }

            if (_receiver.Exists(_id, _employee.Id))
            {
                return false;
            }

            return true;
        }

        public void Execute()
        {
            if (_employee == null)
            {
                return;
            }

            _receiver.Add(_id, _employee);
        }

        public void Undo()
        {
            if (_employee == null)
            {
                return;
            }

            _receiver.Remove(_id, _employee);
        }
    }
}
