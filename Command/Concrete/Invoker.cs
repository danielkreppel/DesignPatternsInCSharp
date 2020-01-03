using CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Concrete
{
    public class Invoker
    {
        private Command _command;

        public Invoker(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand() => _command.Execute();
    }
}
