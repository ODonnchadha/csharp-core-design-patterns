using Memento.Interfaces.Commands;
using Memento.Interfaces.Receivers;
using Memento.Models;

namespace Memento.Commands
{
    public class EmployeeCommand : ICommand
    {
        private readonly int _id;
        private readonly IEmployeeManagerReceiver _receiver;
        private readonly Employee? _employee;
        public EmployeeCommand(
            int id,
            Employee? employee,
            IEmployeeManagerReceiver receiver)
        {
            _id = id;
            _employee = employee;
            _receiver = receiver;
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
