namespace Pedido.Entities.Enums
{
    enum OrderStatus : int //Para tipo inteiro
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
