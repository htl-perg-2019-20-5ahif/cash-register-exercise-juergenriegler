using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegisterClassLibrary.Model
{
    public class ReceiptLine
    {
        public int ID { get; set; }

        public int ProductID {get; set;}

        public Product BoughtProduct { get; set; }

        public int Amount { get; set; }

        public decimal TotalPrice { get; set; }

        public int ReceiptID { get; set; }
        
        public Receipt Receipt { get; set; }
    }
}
