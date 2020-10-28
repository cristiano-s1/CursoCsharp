using System;
using Pedido.Entities.Enums;//Import Enums
using System.Collections.Generic; //Import List
using System.Globalization;//Import CultureInfo
using System.Text;//Import StringBuilder

namespace Pedido.Entities
{
    class Order
    {
        //Propriedades
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }//Associando a classe Client, e que é do tipo Client
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();//Lista de itens / Já estanciei a lista para que ela não seja nula


        //Construtor padrão
        public Order()
        {

        }


        //Contrutor com argumentos
        //Sempre que estiver uma associação para muitos, no caso aqui é o Contracts não incluir no construtor.
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = Client;
        }


        //Método adicionar
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        //Método remover
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }


        //Método total
        public double Total()
        {
            double sum = 0.0;

            //Percorrer a lista de itens e acresentar a soma so valor total
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }


        //ToString usando o StringBuilder
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
