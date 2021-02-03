using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command.SalesOrder
{
    public class SalesOrderModel : IModel
    {
        public int SalesOrderId { get; set; }
        public DateTime SalesOrderDate { get; set; }
    }
}
