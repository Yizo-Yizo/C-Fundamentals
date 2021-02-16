using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quatity { get; set; }

        // Retrieve one order item.
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order

            return new OrderItem();
        }

        // Save the current order.
        public bool Save()
        {
            // Code that saves the defined order.

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quatity <= 0)
                isValid = false;

            if (ProductId <= 0)
                isValid = false;

            if (PurchasePrice == null)
                isValid = false;

            return isValid;
        }
    }
}
