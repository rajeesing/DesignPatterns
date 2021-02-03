using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.SalesOrder
{
    public class SalesOrderCommand : ICommand
    {
        public async Task<bool> Execute(IEnumerable<IModel> model)
        {
            //TODO: Write a logic to insert into the database
            return await Task.FromResult(true);

        }
    }
}
