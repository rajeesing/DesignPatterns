using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public interface ICommandInvoker
    {
        ICommand GetCommand(Type commandType);
    }
}
