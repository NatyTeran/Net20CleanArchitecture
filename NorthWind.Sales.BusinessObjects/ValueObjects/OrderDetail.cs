using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.BusinessObjects.ValueObjects
{
    public record struct OrderDetail(
        int ProductId, decimal UnitPrice, short Quantity);
}
