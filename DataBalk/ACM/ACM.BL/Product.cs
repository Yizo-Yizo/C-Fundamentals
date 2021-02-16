using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        // Constructors
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        // Properties
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces(); 
            }
            set
            {
                _productName = value;
            }
        }

        public string Log() =>
            $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        // Override toString method from object class
        public override string ToString() => ProductName;

        // Validates the product data.
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;

            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
