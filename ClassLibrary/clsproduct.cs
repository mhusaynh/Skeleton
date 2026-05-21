using System;

namespace ClassLibrary
{
    public class clsproduct
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}