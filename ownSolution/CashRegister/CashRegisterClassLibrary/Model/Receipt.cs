using System;
using System.Collections.Generic;
using System.Text;

namespace CashRegisterClassLibrary.Model
{
    public class Receipt
    {
        public int ID { get; set; }

        public long ReceiptTimestamp { get; set; }

        public decimal TotalPrice { get; set; }

        public List<ReceiptLine> ReceiptLines { get; set; }

    }
}
