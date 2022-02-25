
namespace NorthWind.Sales.Presenters
{
    internal class CreateOrderPresenter : ICreateOrderPresenter
    {
        public int OrderId { get; private set; }

        public ValueTask Handle(int orderId)
        {
            OrderId = orderId;
            return ValueTask.CompletedTask;
        }
    }
}
