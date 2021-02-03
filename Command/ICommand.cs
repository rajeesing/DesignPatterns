using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public interface ICommand
    {
        Task<bool> Execute(IEnumerable<IModel> model);
    }
}
