using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public string Product {  get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public int Quantity { get; set; }
        public bool Completed { get; set; }


    }
}