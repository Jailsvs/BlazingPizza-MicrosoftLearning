using BlazingPizza.Shared.Constants;

namespace BlazingPizza;

public class OrderWithStatus
{
    public readonly static TimeSpan PreparationDuration = TimeSpan.FromSeconds(10);
    public readonly static TimeSpan DeliveryDuration = TimeSpan.FromMinutes(1); // Unrealistic, but more interesting to watch

    public Order Order { get; set; }

    public string StatusText { get; set; }

    public bool IsDelivered => StatusText == StatusConstants.Entregue;

    public static OrderWithStatus FromOrder(Order order)
    {
        // To simulate a real backend process, we fake status updates based on the amount
        // of time since the order was placed
        string statusText;
        var dispatchTime = order.CreatedTime.Add(PreparationDuration);

        if (DateTime.Now < dispatchTime)
        {
            statusText = StatusConstants.EmPreparo;
        }
        else if (DateTime.Now < dispatchTime + DeliveryDuration)
        {
            statusText = StatusConstants.SaiuEntrega;
        }
        else
        {
            statusText = StatusConstants.Entregue;
        }

        return new OrderWithStatus
        {
            Order = order,
            StatusText = statusText
        };
    }


}
